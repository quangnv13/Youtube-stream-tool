using System;
using System.ComponentModel;
using System.Windows.Forms;
using Youtube_dl_ffmpeg_tool.Helper;
using Youtube_dl_ffmpeg_tool.Models;

namespace Youtube_dl_ffmpeg_tool
{
    public partial class AddLivestreamBroadcast : Form
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Playlist Playlist { get; set; }
        public bool MadeForKids { get; set; }
        public string Format { get; set; }
        public int Fps { get; set; }
        public AddLivestreamBroadcast()
        {
            InitializeComponent();
        }

        private void AddLivestreamBroadcast_Load(object sender, EventArgs e)
        {
            var formats = new string[] { "1080p", "720p", "480p" };
            cbxFormat.DataSource = formats;
            var fps = new string[] { "30fps", "60fps" };
            cbxFps.DataSource = fps;
            cbxPlaylist.DataSource = DataHelper.LoadPlayList();
            cbxPlaylist.DisplayMember = "PlaylistName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                NotificationHelper.Notice("Không được bỏ trống tiêu đề livestream");
                return;
            }
            if (string.IsNullOrWhiteSpace(rtDescription.Text))
            {
                NotificationHelper.Notice("Không được bỏ trống mô tả livestream");
                return;
            }
            if(cbxPlaylist.SelectedItem == null)
            {
                NotificationHelper.Notice("Chưa chọn playlist để livestream");
                return;
            }    
            if(cbxFormat.SelectedItem == null)
            {
                NotificationHelper.Notice("Chưa chọn định dạng livestream(1080p, 720p,...)");
                return;
            }
            if(cbxFps.SelectedItem == null)
            {
                NotificationHelper.Notice("Chưa chọn khung hình livestream(30fps hoặc 60fps)");
                return;
            }
            Title = txtTitle.Text;
            Description = rtDescription.Text;
            MadeForKids = chkMadeForKids.Checked;
            Playlist = cbxPlaylist.SelectedItem as Playlist;
            Format = cbxFormat.SelectedItem as string;
            Fps = (cbxFps.SelectedItem as string) == "30fps" ? 30 : 60; ;
            Close();
        }
    }
}
