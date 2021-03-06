﻿namespace Youtube_dl_ffmpeg_tool
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.btnCreateStream = new System.Windows.Forms.Button();
            this.grbLivestream = new System.Windows.Forms.GroupBox();
            this.btnPublishLiveBroadcast = new System.Windows.Forms.Button();
            this.btnDeleteBroadcast = new System.Windows.Forms.Button();
            this.dgvLivebroadcast = new System.Windows.Forms.DataGridView();
            this.liveBroadcastColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playlistComlumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.liveBroadcastTitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livestreamDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playlistColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livestreamNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madeForKidsColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.livestreamStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fpsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteMedia = new System.Windows.Forms.Button();
            this.dgvMediaLink = new System.Windows.Forms.DataGridView();
            this.mediaNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playlistIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaLinkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeatTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbxPlaylist = new System.Windows.Forms.ListBox();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnDeletePlaylist = new System.Windows.Forms.Button();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMediaLinkDownload = new System.Windows.Forms.TextBox();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnChangeSavePath = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbLivestream.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivebroadcast)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediaLink)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(10, 29);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(134, 32);
            this.btnCreatePlaylist.TabIndex = 0;
            this.btnCreatePlaylist.Text = "Create playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // btnCreateStream
            // 
            this.btnCreateStream.Location = new System.Drawing.Point(10, 28);
            this.btnCreateStream.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateStream.Name = "btnCreateStream";
            this.btnCreateStream.Size = new System.Drawing.Size(189, 94);
            this.btnCreateStream.TabIndex = 9;
            this.btnCreateStream.Text = "Create live broadcast";
            this.btnCreateStream.UseVisualStyleBackColor = true;
            this.btnCreateStream.Click += new System.EventHandler(this.btnCreateStream_Click);
            // 
            // grbLivestream
            // 
            this.grbLivestream.Controls.Add(this.btnPublishLiveBroadcast);
            this.grbLivestream.Controls.Add(this.btnDeleteBroadcast);
            this.grbLivestream.Controls.Add(this.dgvLivebroadcast);
            this.grbLivestream.Controls.Add(this.btnCreateStream);
            this.grbLivestream.Location = new System.Drawing.Point(8, 449);
            this.grbLivestream.Name = "grbLivestream";
            this.grbLivestream.Size = new System.Drawing.Size(1722, 571);
            this.grbLivestream.TabIndex = 15;
            this.grbLivestream.TabStop = false;
            this.grbLivestream.Text = "lblStatus";
            // 
            // btnPublishLiveBroadcast
            // 
            this.btnPublishLiveBroadcast.Location = new System.Drawing.Point(208, 28);
            this.btnPublishLiveBroadcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPublishLiveBroadcast.Name = "btnPublishLiveBroadcast";
            this.btnPublishLiveBroadcast.Size = new System.Drawing.Size(189, 49);
            this.btnPublishLiveBroadcast.TabIndex = 21;
            this.btnPublishLiveBroadcast.Text = "Publish live";
            this.btnPublishLiveBroadcast.UseVisualStyleBackColor = true;
            this.btnPublishLiveBroadcast.Click += new System.EventHandler(this.btnPublishLiveBroadcast_Click);
            // 
            // btnDeleteBroadcast
            // 
            this.btnDeleteBroadcast.Location = new System.Drawing.Point(208, 86);
            this.btnDeleteBroadcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteBroadcast.Name = "btnDeleteBroadcast";
            this.btnDeleteBroadcast.Size = new System.Drawing.Size(189, 35);
            this.btnDeleteBroadcast.TabIndex = 20;
            this.btnDeleteBroadcast.Text = "Delete";
            this.btnDeleteBroadcast.UseVisualStyleBackColor = true;
            this.btnDeleteBroadcast.Click += new System.EventHandler(this.btnDeleteBroadcast_Click);
            // 
            // dgvLivebroadcast
            // 
            this.dgvLivebroadcast.AllowUserToDeleteRows = false;
            this.dgvLivebroadcast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivebroadcast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.liveBroadcastColumn,
            this.playlistComlumn,
            this.liveBroadcastTitleColumn,
            this.livestreamDescriptionColumn,
            this.playlistColumn,
            this.livestreamNameColumn,
            this.madeForKidsColumn,
            this.livestreamStatusColumn,
            this.formatColumn,
            this.fpsColumn});
            this.dgvLivebroadcast.Location = new System.Drawing.Point(10, 129);
            this.dgvLivebroadcast.MultiSelect = false;
            this.dgvLivebroadcast.Name = "dgvLivebroadcast";
            this.dgvLivebroadcast.RowHeadersWidth = 62;
            this.dgvLivebroadcast.RowTemplate.Height = 28;
            this.dgvLivebroadcast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivebroadcast.Size = new System.Drawing.Size(1706, 434);
            this.dgvLivebroadcast.TabIndex = 16;
            // 
            // liveBroadcastColumn
            // 
            this.liveBroadcastColumn.DataPropertyName = "LivestreamBroadcastId";
            this.liveBroadcastColumn.HeaderText = "Mã";
            this.liveBroadcastColumn.MinimumWidth = 8;
            this.liveBroadcastColumn.Name = "liveBroadcastColumn";
            this.liveBroadcastColumn.ReadOnly = true;
            this.liveBroadcastColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.liveBroadcastColumn.Width = 120;
            // 
            // playlistComlumn
            // 
            this.playlistComlumn.DataPropertyName = "PlaylistName";
            this.playlistComlumn.HeaderText = "Playlist";
            this.playlistComlumn.MinimumWidth = 8;
            this.playlistComlumn.Name = "playlistComlumn";
            this.playlistComlumn.Width = 200;
            // 
            // liveBroadcastTitleColumn
            // 
            this.liveBroadcastTitleColumn.DataPropertyName = "LiveBroadcastTitle";
            this.liveBroadcastTitleColumn.HeaderText = "Tiêu đề";
            this.liveBroadcastTitleColumn.MinimumWidth = 8;
            this.liveBroadcastTitleColumn.Name = "liveBroadcastTitleColumn";
            this.liveBroadcastTitleColumn.ReadOnly = true;
            this.liveBroadcastTitleColumn.Width = 150;
            // 
            // livestreamDescriptionColumn
            // 
            this.livestreamDescriptionColumn.DataPropertyName = "LiveBroadcastDescription";
            this.livestreamDescriptionColumn.HeaderText = "Mô tả";
            this.livestreamDescriptionColumn.MinimumWidth = 8;
            this.livestreamDescriptionColumn.Name = "livestreamDescriptionColumn";
            this.livestreamDescriptionColumn.Width = 150;
            // 
            // playlistColumn
            // 
            this.playlistColumn.DataPropertyName = "Playlist";
            this.playlistColumn.HeaderText = "Playlist";
            this.playlistColumn.MinimumWidth = 8;
            this.playlistColumn.Name = "playlistColumn";
            this.playlistColumn.Visible = false;
            this.playlistColumn.Width = 150;
            // 
            // livestreamNameColumn
            // 
            this.livestreamNameColumn.DataPropertyName = "LivestreamName";
            this.livestreamNameColumn.HeaderText = "Khóa luồng";
            this.livestreamNameColumn.MinimumWidth = 8;
            this.livestreamNameColumn.Name = "livestreamNameColumn";
            this.livestreamNameColumn.ReadOnly = true;
            this.livestreamNameColumn.Width = 150;
            // 
            // madeForKidsColumn
            // 
            this.madeForKidsColumn.DataPropertyName = "MadeForKids";
            this.madeForKidsColumn.HeaderText = "Trẻ em";
            this.madeForKidsColumn.MinimumWidth = 8;
            this.madeForKidsColumn.Name = "madeForKidsColumn";
            this.madeForKidsColumn.Width = 80;
            // 
            // livestreamStatusColumn
            // 
            this.livestreamStatusColumn.DataPropertyName = "LivestreamStatus";
            this.livestreamStatusColumn.HeaderText = "Trạng thái";
            this.livestreamStatusColumn.MinimumWidth = 8;
            this.livestreamStatusColumn.Name = "livestreamStatusColumn";
            this.livestreamStatusColumn.ReadOnly = true;
            this.livestreamStatusColumn.Width = 80;
            // 
            // formatColumn
            // 
            this.formatColumn.DataPropertyName = "Format";
            this.formatColumn.HeaderText = "Định dạng";
            this.formatColumn.MinimumWidth = 8;
            this.formatColumn.Name = "formatColumn";
            this.formatColumn.Width = 80;
            // 
            // fpsColumn
            // 
            this.fpsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fpsColumn.DataPropertyName = "Fps";
            this.fpsColumn.HeaderText = "Fps";
            this.fpsColumn.MinimumWidth = 8;
            this.fpsColumn.Name = "fpsColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1774, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Logs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteMedia);
            this.groupBox1.Controls.Add(this.dgvMediaLink);
            this.groupBox1.Controls.Add(this.lbxPlaylist);
            this.groupBox1.Controls.Add(this.btnAddVideo);
            this.groupBox1.Controls.Add(this.btnDeletePlaylist);
            this.groupBox1.Controls.Add(this.btnCreatePlaylist);
            this.groupBox1.Location = new System.Drawing.Point(8, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1716, 420);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Playlist";
            // 
            // btnDeleteMedia
            // 
            this.btnDeleteMedia.Location = new System.Drawing.Point(456, 29);
            this.btnDeleteMedia.Name = "btnDeleteMedia";
            this.btnDeleteMedia.Size = new System.Drawing.Size(134, 32);
            this.btnDeleteMedia.TabIndex = 8;
            this.btnDeleteMedia.Text = "Delete media";
            this.btnDeleteMedia.UseVisualStyleBackColor = true;
            this.btnDeleteMedia.Click += new System.EventHandler(this.btnDeleteMedia_Click);
            // 
            // dgvMediaLink
            // 
            this.dgvMediaLink.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvMediaLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMediaLink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mediaNameColumn,
            this.type,
            this.mediaTypeColumn,
            this.playlistIdColumn,
            this.mediaIdColumn,
            this.mediaLinkColumn,
            this.repeatTimeColumn});
            this.dgvMediaLink.Location = new System.Drawing.Point(316, 69);
            this.dgvMediaLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMediaLink.MultiSelect = false;
            this.dgvMediaLink.Name = "dgvMediaLink";
            this.dgvMediaLink.RowHeadersWidth = 62;
            this.dgvMediaLink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMediaLink.Size = new System.Drawing.Size(1392, 343);
            this.dgvMediaLink.TabIndex = 7;
            // 
            // mediaNameColumn
            // 
            this.mediaNameColumn.DataPropertyName = "MediaName";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mediaNameColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.mediaNameColumn.HeaderText = "Tên";
            this.mediaNameColumn.MinimumWidth = 8;
            this.mediaNameColumn.Name = "mediaNameColumn";
            this.mediaNameColumn.Width = 300;
            // 
            // type
            // 
            this.type.HeaderText = "Đầu vào";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.Width = 200;
            // 
            // mediaTypeColumn
            // 
            this.mediaTypeColumn.DataPropertyName = "MediaTypeId";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mediaTypeColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.mediaTypeColumn.HeaderText = "Kiểu đầu vào";
            this.mediaTypeColumn.MinimumWidth = 8;
            this.mediaTypeColumn.Name = "mediaTypeColumn";
            this.mediaTypeColumn.Visible = false;
            this.mediaTypeColumn.Width = 200;
            // 
            // playlistIdColumn
            // 
            this.playlistIdColumn.DataPropertyName = "PlaylistId";
            this.playlistIdColumn.HeaderText = "Column1";
            this.playlistIdColumn.MinimumWidth = 8;
            this.playlistIdColumn.Name = "playlistIdColumn";
            this.playlistIdColumn.Visible = false;
            this.playlistIdColumn.Width = 150;
            // 
            // mediaIdColumn
            // 
            this.mediaIdColumn.DataPropertyName = "MediaId";
            this.mediaIdColumn.HeaderText = "Column1";
            this.mediaIdColumn.MinimumWidth = 8;
            this.mediaIdColumn.Name = "mediaIdColumn";
            this.mediaIdColumn.Visible = false;
            this.mediaIdColumn.Width = 150;
            // 
            // mediaLinkColumn
            // 
            this.mediaLinkColumn.DataPropertyName = "MediaLink";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mediaLinkColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.mediaLinkColumn.HeaderText = "Đường dẫn";
            this.mediaLinkColumn.MinimumWidth = 8;
            this.mediaLinkColumn.Name = "mediaLinkColumn";
            this.mediaLinkColumn.Width = 300;
            // 
            // repeatTimeColumn
            // 
            this.repeatTimeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.repeatTimeColumn.DataPropertyName = "RepeatTime";
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.repeatTimeColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.repeatTimeColumn.HeaderText = "Lặp lại";
            this.repeatTimeColumn.MinimumWidth = 8;
            this.repeatTimeColumn.Name = "repeatTimeColumn";
            // 
            // lbxPlaylist
            // 
            this.lbxPlaylist.FormattingEnabled = true;
            this.lbxPlaylist.ItemHeight = 20;
            this.lbxPlaylist.Location = new System.Drawing.Point(10, 69);
            this.lbxPlaylist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxPlaylist.Name = "lbxPlaylist";
            this.lbxPlaylist.Size = new System.Drawing.Size(271, 344);
            this.lbxPlaylist.TabIndex = 6;
            this.lbxPlaylist.SelectedIndexChanged += new System.EventHandler(this.lbxPlaylist_SelectedIndexChanged);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Location = new System.Drawing.Point(316, 29);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(134, 32);
            this.btnAddVideo.TabIndex = 5;
            this.btnAddVideo.Text = "Add media";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.Location = new System.Drawing.Point(150, 29);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(134, 32);
            this.btnDeletePlaylist.TabIndex = 3;
            this.btnDeletePlaylist.Text = "Delete playlist";
            this.btnDeletePlaylist.UseVisualStyleBackColor = true;
            this.btnDeletePlaylist.Click += new System.EventHandler(this.btnDeletePlaylist_Click);
            // 
            // lbxLog
            // 
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.HorizontalScrollbar = true;
            this.lbxLog.ItemHeight = 20;
            this.lbxLog.Location = new System.Drawing.Point(1779, 42);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.Size = new System.Drawing.Size(554, 1024);
            this.lbxLog.TabIndex = 18;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(18, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1749, 1068);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grbLivestream);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1741, 1035);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Youtube stream";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1741, 1035);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Download";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMediaLinkDownload);
            this.groupBox2.Controls.Add(this.txtSavePath);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnDownload);
            this.groupBox2.Controls.Add(this.btnChangeSavePath);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1431, 180);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get media";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Media link";
            // 
            // txtMediaLinkDownload
            // 
            this.txtMediaLinkDownload.Location = new System.Drawing.Point(92, 18);
            this.txtMediaLinkDownload.Name = "txtMediaLinkDownload";
            this.txtMediaLinkDownload.Size = new System.Drawing.Size(1315, 26);
            this.txtMediaLinkDownload.TabIndex = 1;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Enabled = false;
            this.txtSavePath.Location = new System.Drawing.Point(92, 65);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(1210, 26);
            this.txtSavePath.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Save path";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(10, 123);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(99, 32);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnChangeSavePath
            // 
            this.btnChangeSavePath.Location = new System.Drawing.Point(1310, 62);
            this.btnChangeSavePath.Name = "btnChangeSavePath";
            this.btnChangeSavePath.Size = new System.Drawing.Size(99, 32);
            this.btnChangeSavePath.TabIndex = 5;
            this.btnChangeSavePath.Text = "Change";
            this.btnChangeSavePath.UseVisualStyleBackColor = true;
            this.btnChangeSavePath.Click += new System.EventHandler(this.btnChangeSavePath_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1741, 1035);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Help";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(662, 138);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Facebook";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(662, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 20);
            this.label11.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Email: quangnv1311@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Phone: +84 965927626";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(662, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Created by QuangNV";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.richTextBox2);
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage4.Size = new System.Drawing.Size(1741, 1035);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(736, 160);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(148, 146);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(532, 160);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(148, 146);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(532, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2346, 1085);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbxLog);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stream tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbLivestream.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivebroadcast)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMediaLink)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.Button btnCreateStream;
        private System.Windows.Forms.GroupBox grbLivestream;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLivebroadcast;
        private System.Windows.Forms.ListBox lbxLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMediaLinkDownload;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnChangeSavePath;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeleteBroadcast;
        private System.Windows.Forms.DataGridView dgvMediaLink;
        private System.Windows.Forms.ListBox lbxPlaylist;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.Button btnDeletePlaylist;
        private System.Windows.Forms.Button btnDeleteMedia;
        private System.Windows.Forms.Button btnPublishLiveBroadcast;
        private System.Windows.Forms.DataGridViewTextBoxColumn liveBroadcastColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playlistComlumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn liveBroadcastTitleColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livestreamDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playlistColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livestreamNameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn madeForKidsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livestreamStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fpsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playlistIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaLinkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeatTimeColumn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

