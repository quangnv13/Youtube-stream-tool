using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_dl_ffmpeg_tool.Helper
{
    public static class NotificationHelper
    {
        public static void Error(string error)
        {
            MessageBox.Show(null , error, "Có lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }

        public static void Notice(string notice)
        {
            MessageBox.Show(null, notice, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Confirm(string message)
        {
            return MessageBox.Show(null, message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
