using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_dl_ffmpeg_tool.Helper
{
    public static class LogHelper
    {
        public static ListBox ListBox { get; set; }
        public static Form Form { get; set; }

        public static void AddLog(string log)
        {
            ThreadHelper.AddLog(Form, ListBox, $"[{DateTime.Now.ToString("dd/MM/yyyy HH:MM:ss")}] -- {log}");
        }
    }
}
