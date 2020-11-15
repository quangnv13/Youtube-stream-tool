using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_dl_ffmpeg_tool
{
    public partial class CreatePlayListDialog : Form
    {
        public string PlaylistName { get; set; }
        public CreatePlayListDialog()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPlaylistName.Text.Trim()))
            {
                MessageBox.Show("Playlist name can't empty");
                return;
            }
            PlaylistName = txtPlaylistName.Text;
            this.Close() ;
        }

        private void CreatePlayListDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
