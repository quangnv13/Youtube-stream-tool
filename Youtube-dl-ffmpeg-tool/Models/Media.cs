namespace Youtube_dl_ffmpeg_tool.Models
{
    public class Media
    {
        public int MediaId { get; set; }
        public int PlaylistId { get; set; }
        public int MediaTypeId { get; set; }
        public string MediaName { get; set; }
        public string MediaLink { get; set; }
        public int RepeatTime { get; set; }
    }
}
