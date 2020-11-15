using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Youtube_dl_ffmpeg_tool.Helper;
using Youtube_dl_ffmpeg_tool.Models;

namespace Youtube_dl_ffmpeg_tool
{
    public partial class AddMediaDialog : Form
    {
        private List<MediaType>  mediaTypes= new List<MediaType>();
        public string MediaName { get; set; }
        public int MediaTypeId { get; set; } = 1;
        public string MediaLink { get; set; }
        public int RepeatTime { get; set; } = 0;
        public AddMediaDialog()
        {
            InitializeComponent();
        }

        private void AddMediaDialog_Load(object sender, EventArgs e)
        {
            btnSelectMediaFile.Hide();
            mediaTypes = DataHelper.GetMediaTypes();
            cbxMediaType.DataSource = mediaTypes;
            cbxMediaType.DisplayMember = "MediaTypeName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMediaName.Text.Trim()))
            {
                NotificationHelper.Notice("Tên không được để trống");
                return;
            }

            if(string.IsNullOrWhiteSpace(txtMediaLink.Text.Trim()))
            {
                NotificationHelper.Notice("Đường dẫn không được để trống");
                return;
            }


            if (cbxMediaType.SelectedItem == null)
            {
                NotificationHelper.Notice("Kiểu đầu vào không được để trống");
                return;
            }

            MediaName = txtMediaName.Text;
            MediaTypeId = (cbxMediaType.SelectedItem as MediaType).MediaTypeId;
            MediaLink = txtMediaLink.Text;
            RepeatTime = (int)numRepeatTime.Value;

            this.Close();
        }

        private void cbxMediaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMediaLink.Text = "";
            if(cbxMediaType.SelectedIndex == 0)
            {
                btnSelectMediaFile.Show();
                txtMediaLink.Enabled = false;
                txtMediaLink.Width = 218;
            }
            else
            {
                btnSelectMediaFile.Hide();
                txtMediaLink.Width = 299;
                txtMediaLink.Enabled = true;
            }
        }

        private void btnSelectMediaFile_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            f.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            try
            {
                DialogResult result = f.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(f.FileName))
                {
                    txtMediaLink.Text = f.FileName;
                }
            }
            catch
            {
                NotificationHelper.Notice("Lỗi hệ thống! Không thể mở file");
            }
        }
    }
}
