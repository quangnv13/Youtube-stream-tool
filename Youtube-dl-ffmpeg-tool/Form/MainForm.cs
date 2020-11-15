using AutoMapper;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Youtube_dl_ffmpeg_tool.Helper;
using Youtube_dl_ffmpeg_tool.Models;

namespace Youtube_dl_ffmpeg_tool
{
    public partial class MainForm : Form
    {
        private BindingList<Playlist> playlists = new BindingList<Playlist>();
        private CreatePlayListDialog createPlaylistDialog;
        private AddMediaDialog addMediaDialog;
        private AddLivestreamBroadcast addLivestreamBroadcastDialog;
        private BindingList<LivestreamBroadcast> livestreamBroadcasts = new BindingList<LivestreamBroadcast>();
        public MainForm()
        {
            InitializeComponent();
            FirstLoad();
        }

        private void FirstLoad()
        {
            DataHelper.InitDataHelper();
            txtSavePath.Text = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "downloaded");
            LogHelper.Form = this;
            LogHelper.ListBox = lbxLog;
            updateLivesBroadcastSource();
        }

        private void btnChangeSavePath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtSavePath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            var downloadThread = new Thread(() => YoutubeDlHelper.Download(txtMediaLinkDownload.Text, txtSavePath.Text));
            downloadThread.Start();
        }

        private void btnCreateStream_Click(object sender, EventArgs e)
        {
            if(addLivestreamBroadcastDialog != null)
            {
                addLivestreamBroadcastDialog.Close();
            }
            addLivestreamBroadcastDialog = new AddLivestreamBroadcast();
            addLivestreamBroadcastDialog.Show();
            addLivestreamBroadcastDialog.FormClosed += AddLivestreamBroadcastDialog_FormClosed;
        }

        private void AddLivestreamBroadcastDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(addLivestreamBroadcastDialog.Title) && !string.IsNullOrWhiteSpace(addLivestreamBroadcastDialog.Description))
            {
                var broadcast = YoutubeApiHelper.CreateLiveBroadcast(addLivestreamBroadcastDialog.Title, addLivestreamBroadcastDialog.Description, addLivestreamBroadcastDialog.MadeForKids);
                var livestream = YoutubeApiHelper.CreateLiveStream(addLivestreamBroadcastDialog.Title, addLivestreamBroadcastDialog.Description, addLivestreamBroadcastDialog.Format, addLivestreamBroadcastDialog.Fps);
                YoutubeApiHelper.ConnectStreamToBroadcast(livestream.Id, broadcast.Id);
                var newLivebroadcast = new LivestreamBroadcast() 
                { 
                    LiveBroadcastDescription = addLivestreamBroadcastDialog.Description, 
                    LiveBroadcastTitle = addLivestreamBroadcastDialog.Title, 
                    LiveStreamBroadcastId = broadcast.Id, 
                    Playlist = addLivestreamBroadcastDialog.Playlist,
                    PlaylistName = addLivestreamBroadcastDialog.Playlist.PlaylistName,
                    LiveStreamId = livestream.Id, 
                    LivestreamName = livestream.Cdn.IngestionInfo.StreamName, 
                    LivestreamStatus = broadcast.Status.LifeCycleStatus , 
                    MadeForKids = (bool)broadcast.Status.MadeForKids,
                    Format = addLivestreamBroadcastDialog.Format,
                    Fps = addLivestreamBroadcastDialog.Fps
                };
                livestreamBroadcasts.Add(newLivebroadcast);
                updateLivesBroadcastSource();
            }
        }

        private async void LoadData()
        {
            playlists = DataHelper.LoadPlayList();
            lbxPlaylist.DataSource = playlists;
            lbxPlaylist.DisplayMember = "PlaylistName";

            dgvMediaLink.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvMediaLink.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            var isConnected = await YoutubeApiHelper.ConnectYoutube();
            if (isConnected)
            {
                LogHelper.AddLog($"Connected to your youtube channel");
                grbLivestream.Text = "Connected";
                grbLivestream.Enabled = true;
            }
            else
            {
                LogHelper.AddLog("Authenticate failed");
                grbLivestream.Text = "No connect";
                grbLivestream.Enabled = false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLiveToBroadcast_Click(object sender, EventArgs e)
        {

        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            if (createPlaylistDialog != null)
            {
                createPlaylistDialog.Close();
            }
            createPlaylistDialog = new CreatePlayListDialog();
            createPlaylistDialog.Show();
            createPlaylistDialog.FormClosed += CreatePlaylistDialog_FormClosed;
        }

        private void CreatePlaylistDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(createPlaylistDialog.PlaylistName))
            {
                try
                {
                    var playlist = new Playlist() { PlaylistName = createPlaylistDialog.PlaylistName };
                    DataHelper.AddPlaylist(playlist);
                    playlists.Add(playlist);
                }
                catch(Exception ex)
                {
                    NotificationHelper.Notice("Không thể thêm playlist này");
                    NotificationHelper.Notice(ex.Message);
                }
            }
        }

        private void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            if(lbxPlaylist.SelectedItem == null)
            {
                NotificationHelper.Notice("Chưa chọn playlist để xóa");
                return;
            }

            if(NotificationHelper.Confirm("Bạn có muốn xóa playlist này?") == DialogResult.Yes)
            {
                try
                {
                    var playlist = lbxPlaylist.SelectedItem as Playlist;
                    DataHelper.DeletePlaylist(playlist.PlaylistId);
                    playlists.Remove(lbxPlaylist.SelectedItem as Playlist);
                    updateMediaSource(null);
                }
                catch(Exception ex)
                {
                    NotificationHelper.Notice("Không thể xóa playlist này");
                    NotificationHelper.Notice(ex.Message);
                }
            }
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            if (lbxPlaylist.SelectedItem == null)
            {
                NotificationHelper.Notice("Chưa chọn playlist để thêm media");
                return;
            }

            if(addMediaDialog != null)
            {
                addMediaDialog.Close();
            }
            addMediaDialog = new AddMediaDialog();
            addMediaDialog.Show();
            addMediaDialog.FormClosed += AddMediaDialog_FormClosed;
        }

        private void AddMediaDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(addMediaDialog.MediaLink) && !string.IsNullOrWhiteSpace(addMediaDialog.MediaName) && addMediaDialog.RepeatTime > 0)
            {
                var selectedPlaylist = playlists.FirstOrDefault(pl => pl.PlaylistId == (lbxPlaylist.SelectedItem as Playlist).PlaylistId);
                if(selectedPlaylist != null)
                {
                    var newMedia = new Media() 
                    {
                        MediaLink = addMediaDialog.MediaLink, 
                        MediaName = addMediaDialog.MediaName, 
                        MediaTypeId = addMediaDialog.MediaTypeId, 
                        PlaylistId = selectedPlaylist.PlaylistId,
                        RepeatTime = addMediaDialog.RepeatTime 
                    };
                    try
                    {
                        DataHelper.AddMedia(newMedia);
                        updateMediaSource(DataHelper.GetMedias(selectedPlaylist.PlaylistId));
                    }
                    catch(Exception ex)
                    {
                        NotificationHelper.Notice("Không thể thêm media");
                        NotificationHelper.Notice(ex.Message);
                    }
                }
            }
        }

        private void lbxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxPlaylist.SelectedItem != null && (lbxPlaylist.SelectedItem as Playlist) != null)
            {
                updateMediaSource(DataHelper.GetMedias((lbxPlaylist.SelectedItem as Playlist).PlaylistId));
            }
            else
            {
                dgvMediaLink.DataSource = new BindingList<Media>();
                dgvMediaLink.Update();
                dgvMediaLink.Refresh();
            }
        }

        private void updateMediaSource(BindingList<Media> medias)
        {
            if(medias != null)
            {
                dgvMediaLink.DataSource = medias;
            }
            else
            {
                dgvMediaLink.DataSource = new BindingList<Media>();
            }
            dgvMediaLink.Columns["playlistIdColumn"].Visible = false;
            dgvMediaLink.Columns["mediaIdColumn"].Visible = false;
            foreach(DataGridViewRow row in dgvMediaLink.Rows)
            {
                switch(row.Cells["mediaTypeColumn"].Value)
                {
                    case 1:
                        row.Cells["type"].Value = "Từ file trên máy";
                        break;
                    case 2:
                        row.Cells["type"].Value = "Từ link";
                        break;
                    case 3:
                        row.Cells["type"].Value = "Từ livestream đang có";
                        break;
                    default:
                        break;
                }
            }
            dgvMediaLink.Update();
            dgvMediaLink.Refresh();
        }

        private void updateLivesBroadcastSource()
        {
            dgvLivebroadcast.DataSource = livestreamBroadcasts;
            dgvLivebroadcast.Columns[1].Visible = false;
            dgvLivebroadcast.Columns[2].Visible = false;
            dgvLivebroadcast.Update();
            dgvLivebroadcast.Refresh();
        }

        private void btnDeleteMedia_Click(object sender, EventArgs e)
        {
            if (dgvMediaLink.SelectedRows == null)
            {
                NotificationHelper.Notice("Chưa chọn media để xóa");
                return;
            }
            else
            {
                if(dgvMediaLink.SelectedRows.Count > 0)
                {
                    var currentSelectedMedia = dgvMediaLink.SelectedRows[0].DataBoundItem as Media;
                    if (currentSelectedMedia != null)
                    {
                        if (NotificationHelper.Confirm("Bạn có muốn xóa media này?") == DialogResult.Yes)
                        {
                            try
                            {
                                DataHelper.DeleteMedia(currentSelectedMedia.MediaId);
                                var selectedPlaylist = playlists.FirstOrDefault(pl => pl.PlaylistId == (lbxPlaylist.SelectedItem as Playlist).PlaylistId);
                                if (selectedPlaylist != null)
                                {
                                    updateMediaSource(DataHelper.GetMedias(selectedPlaylist.PlaylistId));
                                }
                            }
                            catch (Exception ex)
                            {
                                NotificationHelper.Notice("Không thể xóa media này");
                                NotificationHelper.Notice(ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void btnDeleteBroadcast_Click(object sender, EventArgs e)
        {
            if(dgvLivebroadcast.SelectedRows == null)
            {
                NotificationHelper.Notice("Chưa chọn livestream để xóa");
                return;
            } 
            else
            {
                var currentSelectedLive = dgvLivebroadcast.SelectedRows[0].DataBoundItem as LivestreamBroadcast;
                if (NotificationHelper.Confirm("Bạn có muốn xóa livestream này?") == DialogResult.Yes)
                {
                    livestreamBroadcasts.Remove(currentSelectedLive);
                    updateLivesBroadcastSource();
                }
            }
        }

        private async void btnPublishLiveBroadcast_Click(object sender, EventArgs e)
        {
            await PublishLive();
        }

        private async Task PublishLive()
        {
            if (dgvLivebroadcast.SelectedRows == null)
            {
                NotificationHelper.Notice("Chưa chọn livestream để publish");
            }
            else
            {
                var currentSelectedLive = dgvLivebroadcast.SelectedRows[0].DataBoundItem as LivestreamBroadcast;
                if(currentSelectedLive != null)
                {
                    if (NotificationHelper.Confirm("Bạn có muốn publish livestream này?") == DialogResult.Yes)
                    {
                        foreach (var media in DataHelper.GetMedias(currentSelectedLive.Playlist.PlaylistId))
                        {
                            switch (media.MediaTypeId)
                            {
                                case 1:
                                    LiveFromMediaSource(media.MediaLink, currentSelectedLive.Format, currentSelectedLive.Fps, currentSelectedLive.LivestreamName);
                                    break;
                                case 2:
                                    await LiveFromMediaLink(media.MediaLink, currentSelectedLive.Format, currentSelectedLive.Fps, currentSelectedLive.LivestreamName);
                                    break;
                                case 3:
                                    LiveFromLiveStream(media.MediaLink, currentSelectedLive.Format, currentSelectedLive.Fps, currentSelectedLive.LivestreamName);
                                    break;
                                default:
                                    LogHelper.AddLog("Media in playlist can't map type");
                                    break;
                            }
                            var result = await YoutubeApiHelper.GoLiveBroadcast(currentSelectedLive.LiveStreamBroadcastId, currentSelectedLive.LiveStreamId);
                            if(!result)
                            {
                                NotificationHelper.Notice("Không thể publish livestream");
                                FfmpegHelper.StopFFmpegProcess(currentSelectedLive.LivestreamName);
                                LogHelper.AddLog("Stop ffmpeg process");
                            }
                        }
                    }
                }
            }
        }

        private async Task LiveFromMediaLink(string mediaLink, string resolution, int fps, string outputRtmp)
        {
            var data = await YoutubeDlHelper.GetMediaStreamLink(mediaLink);
            FfmpegHelper.PushLivestreamFromMediaLink(data, resolution, fps, outputRtmp);
        }

        private void LiveFromLiveStream(string mediaLink, string resolution, int fps, string outputRtmp)
        {
            var data = YoutubeDlHelper.GetMediaLivestreamLink(mediaLink);
            FfmpegHelper.PushLivestreamFromLivestream(data, resolution, fps, outputRtmp);
        }

        private void LiveFromMediaSource(string mediaLink, string resolution, int fps, string outputRtmp)
        {
            FfmpegHelper.PushLivestreamFromLocalFile(mediaLink, resolution, fps, outputRtmp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ffmpegProcess = new Process();
            int maxRate = 1000;
            string bufsize = "768k";
            string buf = "768k";

            string[] processArgs = new string[]
            {
                "-re",
                "-i " +"\"" + $"{richTextBox1.Text}"+ "\"",
                "-i",
                "\"" +$"{richTextBox2.Text}"+"\"",
                "-pix_fmt yuv420p -vsync 1 -threads 0 -vcodec libx264",
                $"-r 30 -g 60 -sc_threshold 0 -b:v {buf} -bufsize {bufsize} -maxrate {maxRate}k",
                "-preset veryfast -profile:v baseline -tune film -acodec aac -b:a 128k -ac 2 -ar 48000 -af",
                "\"aresample=async=1:min_hard_comp = 0.100000:first_pts = 0\" -bsf:v h264_mp4toannexb -f flv",
                textBox1.Text
            };
            string processArgsJoin = string.Join(" ", processArgs);
            LogHelper.AddLog($"Excuting command: ffmpeg {processArgsJoin}");
            ffmpegProcess.StartInfo = new ProcessStartInfo("ffmpeg", processArgsJoin);
            ffmpegProcess.StartInfo.UseShellExecute = false;
            ffmpegProcess.StartInfo.CreateNoWindow = true;
            ffmpegProcess.StartInfo.RedirectStandardOutput = true;
            ffmpegProcess.StartInfo.RedirectStandardError = true;
            ffmpegProcess.ErrorDataReceived += new DataReceivedEventHandler((object send, DataReceivedEventArgs ee) =>
            {
                string output = ee.Data;
                if (!string.IsNullOrWhiteSpace(ee.Data))
                {
                    LogHelper.AddLog(output);
                }
            });
            ffmpegProcess.Start();
            ffmpegProcess.BeginOutputReadLine();
            ffmpegProcess.BeginErrorReadLine();
            LogHelper.AddLog("Start ffmpeg process");
        }
    }
}

