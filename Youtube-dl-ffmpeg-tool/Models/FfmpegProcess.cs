using System.Diagnostics;

namespace Youtube_dl_ffmpeg_tool.Models
{
    public class FfmpegProcess
    {
        public Process Process { get; set; }
        public string LiveStreamName { get; set; }
    }
}
