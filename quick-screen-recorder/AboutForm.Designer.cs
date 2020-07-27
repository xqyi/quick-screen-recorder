namespace quick_screen_recorder
{
	partial class AboutForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
            this.components = new System.ComponentModel.Container();
            this.productLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.developerLink = new System.Windows.Forms.LinkLabel();
            this.infoGroup = new QuickLibrary.QlibGroupBox();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.pagesGroup = new QuickLibrary.QlibGroupBox();
            this.aboutTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.infoGroup.SuspendLayout();
            this.pagesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(6, 28);
            this.productLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(72, 15);
            this.productLabel.TabIndex = 27;
            this.productLabel.Text = "小黑鸟快录";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(6, 49);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 15);
            this.versionLabel.TabIndex = 28;
            this.versionLabel.Text = "Version";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(6, 76);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(235, 30);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.Text = "小黑鸟快录是一款快速录制视频和PPT等\r\n素材的专业AI工具\r\n";
            // 
            // developerLink
            // 
            this.developerLink.AutoSize = true;
            this.developerLink.Location = new System.Drawing.Point(6, 28);
            this.developerLink.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.developerLink.Name = "developerLink";
            this.developerLink.Size = new System.Drawing.Size(163, 15);
            this.developerLink.TabIndex = 2;
            this.developerLink.TabStop = true;
            this.developerLink.Text = "北京飞鸟视界科技有限公司\r\n";
            this.aboutTooltip.SetToolTip(this.developerLink, "Open developer page in browser");
            this.developerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.developerLink_LinkClicked);
            // 
            // infoGroup
            // 
            this.infoGroup.AutoSize = true;
            this.infoGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.infoGroup.Controls.Add(this.licenseLabel);
            this.infoGroup.Controls.Add(this.versionLabel);
            this.infoGroup.Controls.Add(this.productLabel);
            this.infoGroup.Controls.Add(this.descriptionLabel);
            this.infoGroup.Location = new System.Drawing.Point(9, 98);
            this.infoGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.infoGroup.Name = "infoGroup";
            this.infoGroup.Size = new System.Drawing.Size(247, 155);
            this.infoGroup.TabIndex = 34;
            this.infoGroup.TabStop = false;
            this.infoGroup.Text = "信息";
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Location = new System.Drawing.Point(6, 118);
            this.licenseLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(228, 15);
            this.licenseLabel.TabIndex = 37;
            this.licenseLabel.Text = "版权所有：北京飞鸟视界科技有限公司";
            // 
            // pagesGroup
            // 
            this.pagesGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pagesGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pagesGroup.Controls.Add(this.developerLink);
            this.pagesGroup.Location = new System.Drawing.Point(9, 333);
            this.pagesGroup.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.pagesGroup.Name = "pagesGroup";
            this.pagesGroup.Size = new System.Drawing.Size(254, 65);
            this.pagesGroup.TabIndex = 37;
            this.pagesGroup.TabStop = false;
            this.pagesGroup.Text = "官网";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::quick_screen_recorder.Properties.Resources.bitbug_favicon_32;
            this.logoPictureBox.Location = new System.Drawing.Point(9, 9);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(256, 80);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(274, 404);
            this.Controls.Add(this.pagesGroup);
            this.Controls.Add(this.infoGroup);
            this.Controls.Add(this.logoPictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutForm_KeyDown);
            this.infoGroup.ResumeLayout(false);
            this.infoGroup.PerformLayout();
            this.pagesGroup.ResumeLayout(false);
            this.pagesGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label productLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.LinkLabel developerLink;
		private QuickLibrary.QlibGroupBox infoGroup;
		private QuickLibrary.QlibGroupBox pagesGroup;
		private System.Windows.Forms.Label licenseLabel;
		private System.Windows.Forms.ToolTip aboutTooltip;
	}
}
