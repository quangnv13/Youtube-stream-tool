namespace Youtube_dl_ffmpeg_tool
{
    partial class AddMediaDialog
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMediaName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMediaLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxMediaType = new System.Windows.Forms.ComboBox();
            this.numRepeatTime = new System.Windows.Forms.NumericUpDown();
            this.btnSelectMediaFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeatTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(255, 265);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Tạo";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMediaName
            // 
            this.txtMediaName.Location = new System.Drawing.Point(141, 74);
            this.txtMediaName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMediaName.Name = "txtMediaName";
            this.txtMediaName.Size = new System.Drawing.Size(448, 26);
            this.txtMediaName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên";
            // 
            // txtMediaLink
            // 
            this.txtMediaLink.Location = new System.Drawing.Point(141, 128);
            this.txtMediaLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMediaLink.Name = "txtMediaLink";
            this.txtMediaLink.Size = new System.Drawing.Size(325, 26);
            this.txtMediaLink.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đường dẫn/Url";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lặp lại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = " Kiểu đầu vào";
            // 
            // cbxMediaType
            // 
            this.cbxMediaType.FormattingEnabled = true;
            this.cbxMediaType.Location = new System.Drawing.Point(141, 23);
            this.cbxMediaType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMediaType.Name = "cbxMediaType";
            this.cbxMediaType.Size = new System.Drawing.Size(448, 28);
            this.cbxMediaType.TabIndex = 11;
            this.cbxMediaType.SelectedIndexChanged += new System.EventHandler(this.cbxMediaType_SelectedIndexChanged);
            // 
            // numRepeatTime
            // 
            this.numRepeatTime.Location = new System.Drawing.Point(141, 195);
            this.numRepeatTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numRepeatTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRepeatTime.Name = "numRepeatTime";
            this.numRepeatTime.Size = new System.Drawing.Size(448, 26);
            this.numRepeatTime.TabIndex = 12;
            this.numRepeatTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSelectMediaFile
            // 
            this.btnSelectMediaFile.Location = new System.Drawing.Point(477, 123);
            this.btnSelectMediaFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectMediaFile.Name = "btnSelectMediaFile";
            this.btnSelectMediaFile.Size = new System.Drawing.Size(112, 35);
            this.btnSelectMediaFile.TabIndex = 13;
            this.btnSelectMediaFile.Text = "Chọn";
            this.btnSelectMediaFile.UseVisualStyleBackColor = true;
            this.btnSelectMediaFile.Click += new System.EventHandler(this.btnSelectMediaFile_Click);
            // 
            // AddMediaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 334);
            this.Controls.Add(this.btnSelectMediaFile);
            this.Controls.Add(this.numRepeatTime);
            this.Controls.Add(this.cbxMediaType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMediaLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMediaName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddMediaDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMediaDialog";
            this.Load += new System.EventHandler(this.AddMediaDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numRepeatTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMediaName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMediaLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxMediaType;
        private System.Windows.Forms.NumericUpDown numRepeatTime;
        private System.Windows.Forms.Button btnSelectMediaFile;
    }
}