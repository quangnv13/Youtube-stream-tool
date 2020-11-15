using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Youtube_dl_ffmpeg_tool.Helper
{
    public static class YoutubeDlHelper
    {
       public static void Download(string mediaLink, string savePath)
       {
            if (string.IsNullOrWhiteSpace(mediaLink))
            {
                LogHelper.AddLog("Start download failed, video link is empty");
                return;
            }
            LogHelper.AddLog("Starting download");
            LogHelper.AddLog($"Downloading Video link: {mediaLink}");
            LogHelper.AddLog($"Save path: {savePath}");
            var youtubeDlProcess = new Process();
            string[] processArgs = new string[2];
            processArgs[0] = $"-o \"{savePath} \\%(title)s{DateTime.Now.Millisecond}.%(ext)s\"";
            processArgs[1] = mediaLink;
            CreateDownloadProcess(processArgs, youtubeDlProcess);
        }

        private static void CreateDownloadProcess(string[] processArgs, Process youtubeDlProcess)
        {
            string processArgsJoin = string.Join(" ", processArgs);
            LogHelper.AddLog($"Excuting command: youtube-dl {processArgsJoin}");
            youtubeDlProcess.StartInfo = new ProcessStartInfo("youtube-dl", processArgsJoin);
            youtubeDlProcess.StartInfo.UseShellExecute = false;
            youtubeDlProcess.StartInfo.CreateNoWindow = true;
            youtubeDlProcess.StartInfo.RedirectStandardOutput = true;
            youtubeDlProcess.StartInfo.RedirectStandardError = true;
            youtubeDlProcess.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            youtubeDlProcess.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            youtubeDlProcess.Start();
            youtubeDlProcess.BeginOutputReadLine();
            youtubeDlProcess.BeginErrorReadLine();
            youtubeDlProcess.WaitForExit();
        }

        private static void OutputHandler(object sender, DataReceivedEventArgs e)
        {
            string output = e.Data;
            if (!string.IsNullOrWhiteSpace(e.Data))
            {
                LogHelper.AddLog(output);
            }
        }

        async public static Task<string[]> GetMediaStreamLink(string mediaLink)
        {
            string[] data = new string[2];
            LogHelper.AddLog("Get media stream info");
            var youtubeDlProcess = new Process();
            youtubeDlProcess.StartInfo = new ProcessStartInfo("youtube-dl", $"--get-url {mediaLink}");
            youtubeDlProcess.StartInfo.UseShellExecute = false;
            youtubeDlProcess.StartInfo.CreateNoWindow = true;
            youtubeDlProcess.StartInfo.RedirectStandardOutput = true;
            youtubeDlProcess.StartInfo.RedirectStandardError = true;
            int i = 0;
            youtubeDlProcess.OutputDataReceived += new DataReceivedEventHandler((sender, e) => {
                string output = e.Data;
                if (!string.IsNullOrWhiteSpace(e.Data))
                {
                    LogHelper.AddLog($"{output}");
                    data[i] = output;
                }
                else
                {
                    youtubeDlProcess.Dispose();
                }
                i++;
            });
            youtubeDlProcess.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            youtubeDlProcess.Start();
            youtubeDlProcess.BeginOutputReadLine();
            youtubeDlProcess.BeginErrorReadLine();
            while (string.IsNullOrWhiteSpace(data[0]) && string.IsNullOrWhiteSpace(data[0]))
            {
                await Task.Delay(500);
            }

            return data;
        }

        public static string GetMediaLivestreamLink(string mediaLink)
        {
            string data = "";
            LogHelper.AddLog("Get media stream info");
            var youtubeDlProcess = new Process();
            youtubeDlProcess.StartInfo = new ProcessStartInfo("youtube-dl", $"--get-url {mediaLink}");
            youtubeDlProcess.StartInfo.UseShellExecute = false;
            youtubeDlProcess.StartInfo.CreateNoWindow = true;
            youtubeDlProcess.StartInfo.RedirectStandardOutput = true;
            youtubeDlProcess.StartInfo.RedirectStandardError = true;
            youtubeDlProcess.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            {
                string output = e.Data;
                if (!string.IsNullOrWhiteSpace(e.Data))
                {
                    data = output;
                }
            });
            youtubeDlProcess.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            youtubeDlProcess.Start();
            youtubeDlProcess.BeginOutputReadLine();
            youtubeDlProcess.BeginErrorReadLine();
            youtubeDlProcess.WaitForExit();
            return data;
        }
    }
}
