using Google.Apis.YouTube.v3.Data;
using System;
using System.Windows.Forms;

namespace Youtube_dl_ffmpeg_tool.Helper
{
    public static class ThreadHelper
    {
        delegate void SetTextCallback(Form f, Control ctrl, string text);
        delegate void AddLogCallback(Form f, ListBox ctrl, string log);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetText(Form form, Control ctrl, string text)
        {
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }

        /// <summary>
        /// Append text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="playlist"></param>
        public static void AddLog(Form form, ListBox ctrl, string log)
        {
            if (ctrl.InvokeRequired)
            {
                AddLogCallback d = new AddLogCallback(AddLog);
                form.Invoke(d, new object[] { form, ctrl, log });
            }
            else
            {
                if(ctrl.Items.Count > 200)
                {
                    ctrl.Items.Clear();
                    ctrl.Items.Add($"[{DateTime.Now}] -- Auto Cleaned log");
                }
                ctrl.Items.Add(log);
                ctrl.SelectedIndex = ctrl.Items.Count - 1;
            }
        }
    }
}
