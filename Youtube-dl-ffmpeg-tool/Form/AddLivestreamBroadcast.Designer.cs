namespace Youtube_dl_ffmpeg_tool
{
    partial class AddLivestreamBroadcast
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLivestreamBroadcast));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtDescription = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkMadeForKids = new System.Windows.Forms.CheckBox();
            this.cbxPlaylist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxFormat = new System.Windows.Forms.ComboBox();
            this.cbxFps = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.Name = "txtTitle";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // rtDescription
            // 
            resources.ApplyResources(this.rtDescription, "rtDescription");
            this.rtDescription.Name = "rtDescription";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkMadeForKids
            // 
            resources.ApplyResources(this.chkMadeForKids, "chkMadeForKids");
            this.chkMadeForKids.Name = "chkMadeForKids";
            this.chkMadeForKids.UseVisualStyleBackColor = true;
            // 
            // cbxPlaylist
            // 
            this.cbxPlaylist.FormattingEnabled = true;
            resources.ApplyResources(this.cbxPlaylist, "cbxPlaylist");
            this.cbxPlaylist.Name = "cbxPlaylist";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cbxFormat
            // 
            this.cbxFormat.FormattingEnabled = true;
            resources.ApplyResources(this.cbxFormat, "cbxFormat");
            this.cbxFormat.Name = "cbxFormat";
            // 
            // cbxFps
            // 
            this.cbxFps.FormattingEnabled = true;
            resources.ApplyResources(this.cbxFps, "cbxFps");
            this.cbxFps.Name = "cbxFps";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // AddLivestreamBroadcast
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbxFps);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxFormat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxPlaylist);
            this.Controls.Add(this.chkMadeForKids);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.MaximizeBox = false;
            this.Name = "AddLivestreamBroadcast";
            this.Load += new System.EventHandler(this.AddLivestreamBroadcast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkMadeForKids;
        private System.Windows.Forms.ComboBox cbxPlaylist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxFormat;
        private System.Windows.Forms.ComboBox cbxFps;
        private System.Windows.Forms.Label label5;
    }
}