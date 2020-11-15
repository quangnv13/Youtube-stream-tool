using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Youtube_dl_ffmpeg_tool.Helper
{
    public static class YoutubeApiHelper
    {
        private static YouTubeService youtubeService;
        public static async Task<bool> ConnectYoutube()
        {
            UserCredential credential;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.Youtube },
                    "user",
                    CancellationToken.None
                );
            }

            if (credential != null)
            {
                {
                    youtubeService = new YouTubeService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = "Stream-tool"
                    });

                    if (youtubeService != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static LiveStream CreateLiveStream(string title, string description, string resolution = "1080p", int frameRate = 30)
        {
            var livestream = new LiveStream
            {
                Snippet = new LiveStreamSnippet
                {
                    Title = title,
                    Description = description
                },
                Cdn = new CdnSettings
                {
                    IngestionType = "rtmp",
                    Resolution = resolution,
                    FrameRate = $"{frameRate}fps"
                },
                ContentDetails = new LiveStreamContentDetails
                {
                    IsReusable = true
                }
            };
            var request = youtubeService.LiveStreams.Insert(livestream, "snippet,cdn,contentDetails,status");
            var response = request.Execute();
            return response;
        }
        public static LiveBroadcast CreateLiveBroadcast(string title, string description, bool madeForKids)
        {
            var broadcast = new LiveBroadcast
            {
                Kind = "youtube#liveBroadcast",
                Snippet = new LiveBroadcastSnippet
                {
                    Title = title,
                    Description = description,
                    ScheduledStartTime = DateTime.Now.ToString("yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz")
                },
                Status = new LiveBroadcastStatus { PrivacyStatus = "public", SelfDeclaredMadeForKids = madeForKids }
            };
            var request = youtubeService.LiveBroadcasts.Insert(broadcast, "snippet,status");
            var response = request.Execute();
            return response;
        }
        public static LiveBroadcast GetInfoLiveBroadcast(string broadcastId)
        {
            var request = youtubeService.LiveBroadcasts.List("snippet,contentDetails,status");
            request.Id = broadcastId;
            var response = request.Execute();
            if(response.Items.Count > 0)
            {
                return response.Items[0];
            }
            return null;
        }

        public static LiveStream GetInfoLivestream(string streamId)
        {
            var request = youtubeService.LiveStreams.List("snippet,contentDetails,status,cdn");
            request.Id = streamId;
            var response = request.Execute();
            if (response.Items.Count > 0)
            {
                return response.Items[0];
            }
            return null;
        }
        public static LiveBroadcast ConnectStreamToBroadcast(string livestreamId, string broadcastId)
        {
            var request = youtubeService.LiveBroadcasts.Bind(broadcastId, "id,contentDetails");
            request.StreamId = livestreamId;
            var response = request.Execute();
            return response;
        }
        private static async Task<bool> PublishLive(string livestreamId, string broadcastId)
        {
            LogHelper.AddLog($"Kiểm tra trạng thái livestream: {broadcastId}");
            var getLiveStreamRequest = youtubeService.LiveStreams.List("status");
            getLiveStreamRequest.Id = livestreamId;
            var livestreamResponse = getLiveStreamRequest.Execute();
            if (livestreamResponse.Items.Count > 0)
            {
                LogHelper.AddLog($"Livestream đã được khởi tạo");
                LiveStream livestream = livestreamResponse.Items[0];
                while (livestream.Status.StreamStatus != "active")
                {
                    LogHelper.AddLog($"Đang chờ luồng livestream sẵn sàng.");
                    await Task.Delay(2000);
                    livestream = getLiveStreamRequest.Execute().Items[0];
                }

                var getBroadcastRequest = youtubeService.LiveBroadcasts.List("status");
                getBroadcastRequest.Id = broadcastId;
                var broadcastResponse = getBroadcastRequest.Execute();
                if (broadcastResponse.Items.Count > 0)
                {
                    LiveBroadcast liveBroadcast = broadcastResponse.Items[0];
                    while (liveBroadcast.Status.LifeCycleStatus != "ready")
                    {
                        if (liveBroadcast.Status.LifeCycleStatus == "complete")
                        {
                            // Status can not complete
                            LogHelper.AddLog($"Luồng đã kết thúc không thể tiếp tục!");
                            return false;
                        }
                        LogHelper.AddLog($"Đang chờ luồng livestream sẵn sàng..");
                        await Task.Delay(2000);
                        liveBroadcast = getBroadcastRequest.Execute().Items[0];
                    }

                    var transitionLiveBroadcastToTestingRequest = youtubeService.LiveBroadcasts.Transition(broadcastId, LiveBroadcastsResource.TransitionRequest.BroadcastStatusEnum.Testing, "status");
                    transitionLiveBroadcastToTestingRequest.Execute();
                    liveBroadcast = getBroadcastRequest.Execute().Items[0];
                    while (liveBroadcast.Status.LifeCycleStatus != "testing")
                    {
                        if (liveBroadcast.Status.LifeCycleStatus == "complete")
                        {
                            // Status can not complete
                            LogHelper.AddLog($"Luồng đã kết thúc không thể tiếp tục!");
                            return false;
                        }
                        LogHelper.AddLog($"Đang chờ luồng livestream sẵn sàng...");
                        await Task.Delay(2000);
                        liveBroadcast = getBroadcastRequest.Execute().Items[0];
                    }

                    var transitionLiveBroadcastToLiveRequest = youtubeService.LiveBroadcasts.Transition(broadcastId, LiveBroadcastsResource.TransitionRequest.BroadcastStatusEnum.Live, "status");
                    transitionLiveBroadcastToLiveRequest.Execute();
                    liveBroadcast = getBroadcastRequest.Execute().Items[0];
                    while (liveBroadcast.Status.LifeCycleStatus != "live")
                    {
                        if (liveBroadcast.Status.LifeCycleStatus == "complete")
                        {
                            // Status can not complete
                            LogHelper.AddLog($"Luồng đã kết thúc không thể tiếp tục!");
                            return false;
                        }
                        LogHelper.AddLog($"Đang đăng livestream broadcast...");
                        await Task.Delay(2000);
                        liveBroadcast = getBroadcastRequest.Execute().Items[0];
                    }
                    LogHelper.AddLog("Đã đăng livestream broadcast");
                    return true;
                }
            }
            else
            {
                LogHelper.AddLog($"Livestream chưa được tạo trên broadcast: {broadcastId}");
            }
            return false;
        }
        public static async Task<bool> GoLiveBroadcast(string broadcastId, string livestreamId)
        {
            if(youtubeService == null)
            {
                NotificationHelper.Notice("Chưa kết nối với youtube channel! Vui lòng kết nối tới youtube channel!");
                LogHelper.AddLog("No connect to youtube channel");
                LogHelper.AddLog("Connecting to youtube channel"); ;
                var result = await ConnectYoutube();
                if(!result) 
                {
                    LogHelper.AddLog("Không thể kết nối với youtube channel");
                    NotificationHelper.Error("Không thể kết nối với youtube channel");
                    return false;
                }
            }
            if(youtubeService != null)
            {
                return await PublishLive(livestreamId, broadcastId);
            }
            LogHelper.AddLog($"Có lỗi xảy ra khi xử lý luồng livestream");
            return false;
        }
    }
}
