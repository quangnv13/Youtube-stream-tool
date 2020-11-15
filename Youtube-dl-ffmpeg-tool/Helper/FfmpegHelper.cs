using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Youtube_dl_ffmpeg_tool.Models;

namespace Youtube_dl_ffmpeg_tool.Helper
{
    public static class FfmpegHelper
    {
        private static List<FfmpegProcess> ffmpegProcesses = new List<FfmpegProcess>();
        public static void PushLivestreamFromMediaLink(string[] data, string resolution, int fps, string outputRtmp)
        {
            if (data != null)
            {
                if (string.IsNullOrWhiteSpace(data[0]))
                {
                    LogHelper.AddLog("Stream video data is null");
                    return;
                }
                if (string.IsNullOrWhiteSpace(data[1]))
                {
                    LogHelper.AddLog("Stream audio data is null");
                    return;
                }
                var ffmpegProcess = new Process();
                CreateLiveFromSourceUrlProcess(ffmpegProcess, data[0], data[1], resolution, fps, outputRtmp);
            }
        }

        public static void PushLivestreamFromLivestream(string data, string resolution, int fps, string outputRtmp)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                LogHelper.AddLog("Stream video data is null");
                return;
            }
            var ffmpegProcess = new Process();
            CreateLiveFromLivestreamUrlProcess(ffmpegProcess, data, resolution, fps, outputRtmp);
        }

        public static void PushLivestreamFromLocalFile(string path, string resolution, int fps, string outputRtmp)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                LogHelper.AddLog("Stream video data is null");
                return;
            }
            var ffmpegProcess = new Process();
            CreateLiveFromLocalFileProcess(ffmpegProcess, path, resolution, fps, outputRtmp);
        }

        private static void StartProcess(string[] processArgs, Process ffmpegProcess, string outputRtmp)
        {
            string processArgsJoin = string.Join(" ", processArgs);
            LogHelper.AddLog($"Excuting command: ffmpeg {processArgsJoin}");
            ffmpegProcess.StartInfo = new ProcessStartInfo("ffmpeg", processArgsJoin);
            ffmpegProcess.StartInfo.UseShellExecute = false;
            ffmpegProcess.StartInfo.CreateNoWindow = true;
            ffmpegProcess.StartInfo.RedirectStandardOutput = true;
            ffmpegProcess.StartInfo.RedirectStandardError = true;
            ffmpegProcess.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            ffmpegProcess.Start();
            ffmpegProcess.BeginOutputReadLine();
            ffmpegProcess.BeginErrorReadLine();
            LogHelper.AddLog("Start ffmpeg process");
            ffmpegProcesses.Add(new FfmpegProcess() { LiveStreamName = outputRtmp, Process = ffmpegProcess });
        }

        private static void CreateLiveFromLocalFileProcess(Process ffmpegProcess, string path, string resolution, int fps, string outputRtmp)
        {
            int maxRate = 1000;
            string bufsize = "768k";
            string buf = "768k";
            string solution = "1920:1080";
            switch (resolution)
            {
                case "1080p":
                    maxRate = 4500;
                    buf = bufsize = "4000k";
                    break;
                case "720p":
                    maxRate = 2000;
                    buf = bufsize = "1800k";
                    solution = "1280:720";
                    break;
                default:
                    maxRate = 1000;
                    buf = bufsize = "900k";
                    break;
            }
            string[] processArgs = new string[]
            {
                "-re",
                "-i",
                path,
                $"-pix_fmt yuv420p -vsync 1 -threads 0 -vcodec libx264 -vf scale={solution}",
                $"-r {fps} -g 60 -sc_threshold 0 -b:v {buf} -bufsize {bufsize} -maxrate {maxRate}k",
                "-preset veryfast -profile:v baseline -tune film -acodec aac -b:a 128k -ac 2 -ar 48000 -af",
                "\"aresample=async=1:min_hard_comp = 0.100000:first_pts = 0\" -bsf:v h264_mp4toannexb -f flv",
                $"rtmp://a.rtmp.youtube.com/live2/{outputRtmp}"
            };
            StartProcess(processArgs, ffmpegProcess, outputRtmp);
        }

        private static void CreateLiveFromSourceUrlProcess(Process ffmpegProcess, string videoSource, string audioSource, string resolution, int fps, string outputRtmp)
        {
            int maxRate = 1000;
            string bufsize = "768k";
            string buf = "768k";
            string solution = "1920:1080";
            switch (resolution)
            {
                case "1080p":
                    maxRate = 4500;
                    buf = bufsize = "4000k";
                    break;
                case "720p":
                    maxRate = 2000;
                    buf = bufsize = "1800k";
                    solution = "1280:720";
                    break;
                default:
                    maxRate = 1000;
                    buf = bufsize = "900k";
                break;
            }
            string[] processArgs = new string[]
            {
                "-re",
                "-i",
                videoSource,
                "-i",
                audioSource,
                $"-pix_fmt yuv420p -vsync 1 -threads 0 -vcodec libx264 -vf scale={solution}",
                $"-r {fps} -g 60 -sc_threshold 0 -b:v {buf} -bufsize {bufsize} -maxrate {maxRate}k", 
                "-preset veryfast -profile:v baseline -tune film -acodec aac -b:a 128k -ac 2 -ar 48000 -af",
                "\"aresample=async=1:min_hard_comp = 0.100000:first_pts = 0\" -bsf:v h264_mp4toannexb -f flv",
                $"rtmp://a.rtmp.youtube.com/live2/{outputRtmp}"
            };
            StartProcess(processArgs, ffmpegProcess, outputRtmp);
        }

        private static void CreateLiveFromLivestreamUrlProcess(Process ffmpegProcess, string livestreamUrl, string resolution, int fps, string outputRtmp)
        {
            int maxRate = 1000;
            string bufsize = "768k";
            string buf = "768k";
            string solution = "1920:1080";
            switch (resolution)
            {
                case "1080p":
                    maxRate = 4500;
                    buf = bufsize = "4000k";
                    break;
                case "720p":
                    maxRate = 2000;
                    buf = bufsize = "1800k";
                    solution = "1280:720";
                    break;
                default:
                    maxRate = 1000;
                    buf = bufsize = "900k";
                    break;
            }
            string[] processArgs = new string[]
            {
                "-re",
                "-i",
                $"{livestreamUrl}",
                $"-pix_fmt yuv420p -vsync 1 -threads 0 -vcodec libx264 -vf scale={solution}",
                $"-r {fps} -g 60 -sc_threshold 0 -b:v {buf} -bufsize {bufsize} -maxrate {maxRate}k",
                "-preset veryfast -profile:v baseline -tune film -acodec aac -b:a 128k -ac 2 -ar 48000 -af",
                "\"aresample=async=1:min_hard_comp = 0.100000:first_pts = 0\" -bsf:v h264_mp4toannexb -f flv",
                $"rtmp://a.rtmp.youtube.com/live2/{outputRtmp}"
            };
            StartProcess(processArgs, ffmpegProcess, outputRtmp);
        }

        private static void OutputHandler(object sender, DataReceivedEventArgs e)
        {
            string output = e.Data;
            if (!string.IsNullOrWhiteSpace(e.Data))
            {
                LogHelper.AddLog(output);
            }
        }

        public static void StopFFmpegProcess(string outputRtmp)
        {
            ffmpegProcesses.FirstOrDefault(ff => ff.LiveStreamName == outputRtmp)?.Process.Kill();
        }
    }
}
