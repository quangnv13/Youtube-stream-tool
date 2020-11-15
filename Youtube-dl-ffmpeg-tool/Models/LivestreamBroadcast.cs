using Google.Apis.YouTube.v3.Data;

namespace Youtube_dl_ffmpeg_tool.Models
{
    public class LivestreamBroadcast
    {
        public string LiveStreamBroadcastId { get; set; }
        public string LiveStreamId { get; set; }
        public Playlist Playlist { get; set; }
        public string PlaylistName { get; set; }
        public string LiveBroadcastTitle { get; set; }
        public string LiveBroadcastDescription { get; set; }
        public string LivestreamName { get; set; }
        public string LivestreamStatus { get; set; }
        public bool MadeForKids { get; set; }
        public string Format { get; set; }
        public int Fps { get; set; }
    }
}
