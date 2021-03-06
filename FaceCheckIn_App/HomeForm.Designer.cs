﻿using AForge.Video.DirectShow;

namespace FaceCheckIn_App
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.UserFace_Page = new System.Windows.Forms.TabControl();
            this.Tab_User = new System.Windows.Forms.TabPage();
            this.videoSourcePlayer_UserSignIn = new AForge.Controls.VideoSourcePlayer();
            this.uploadFiles_btn = new System.Windows.Forms.Button();
            this.folderBrowser_btn = new System.Windows.Forms.Button();
            this.ImageFolderAddress_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.FacelistView = new System.Windows.Forms.ListView();
            this.imageLists = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.signIn_btn = new System.Windows.Forms.Button();
            this.ScratchPicture_btn = new System.Windows.Forms.Button();
            this.activeCamara_btn = new System.Windows.Forms.Button();
            this.loadImage_btn = new System.Windows.Forms.Button();
            this.userId_tb = new System.Windows.Forms.TextBox();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.groupId_tb = new System.Windows.Forms.TextBox();
            this.groupIdLabel = new System.Windows.Forms.Label();
            this.UserName_tb = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.Tab_SignIn = new System.Windows.Forms.TabPage();
            this.delete_btn = new System.Windows.Forms.Button();
            this.users_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faceSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tab_CheckIn = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckResult_rtb = new System.Windows.Forms.RichTextBox();
            this.ConfirmCheckIn_btn = new System.Windows.Forms.Button();
            this.videoSourcePlayer_UserCheckIn = new AForge.Controls.VideoSourcePlayer();
            this.ofdOpenImageFile = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.UserFace_Page.SuspendLayout();
            this.Tab_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.Tab_SignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceSearchBindingSource)).BeginInit();
            this.Tab_CheckIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserFace_Page
            // 
            this.UserFace_Page.Controls.Add(this.Tab_User);
            this.UserFace_Page.Controls.Add(this.Tab_SignIn);
            this.UserFace_Page.Controls.Add(this.Tab_CheckIn);
            this.UserFace_Page.Location = new System.Drawing.Point(16, 9);
            this.UserFace_Page.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserFace_Page.Name = "UserFace_Page";
            this.UserFace_Page.SelectedIndex = 0;
            this.UserFace_Page.Size = new System.Drawing.Size(1484, 1030);
            this.UserFace_Page.TabIndex = 0;
            this.UserFace_Page.SelectedIndexChanged += new System.EventHandler(this.UserFace_Page_SelectedIndexChanged);
            // 
            // Tab_User
            // 
            this.Tab_User.AllowDrop = true;
            this.Tab_User.Controls.Add(this.videoSourcePlayer_UserSignIn);
            this.Tab_User.Controls.Add(this.uploadFiles_btn);
            this.Tab_User.Controls.Add(this.folderBrowser_btn);
            this.Tab_User.Controls.Add(this.ImageFolderAddress_tb);
            this.Tab_User.Controls.Add(this.label4);
            this.Tab_User.Controls.Add(this.RemoveBtn);
            this.Tab_User.Controls.Add(this.FacelistView);
            this.Tab_User.Controls.Add(this.label3);
            this.Tab_User.Controls.Add(this.label2);
            this.Tab_User.Controls.Add(this.label1);
            this.Tab_User.Controls.Add(this.Cancel_btn);
            this.Tab_User.Controls.Add(this.signIn_btn);
            this.Tab_User.Controls.Add(this.ScratchPicture_btn);
            this.Tab_User.Controls.Add(this.activeCamara_btn);
            this.Tab_User.Controls.Add(this.loadImage_btn);
            this.Tab_User.Controls.Add(this.userId_tb);
            this.Tab_User.Controls.Add(this.UserIdLabel);
            this.Tab_User.Controls.Add(this.pboxImage);
            this.Tab_User.Controls.Add(this.groupId_tb);
            this.Tab_User.Controls.Add(this.groupIdLabel);
            this.Tab_User.Controls.Add(this.UserName_tb);
            this.Tab_User.Controls.Add(this.UserNameLabel);
            this.Tab_User.Location = new System.Drawing.Point(8, 39);
            this.Tab_User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tab_User.Name = "Tab_User";
            this.Tab_User.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tab_User.Size = new System.Drawing.Size(1468, 983);
            this.Tab_User.TabIndex = 0;
            this.Tab_User.Text = "用户注册";
            this.Tab_User.UseVisualStyleBackColor = true;
            // 
            // videoSourcePlayer_UserSignIn
            // 
            this.videoSourcePlayer_UserSignIn.Location = new System.Drawing.Point(983, 358);
            this.videoSourcePlayer_UserSignIn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.videoSourcePlayer_UserSignIn.Name = "videoSourcePlayer_UserSignIn";
            this.videoSourcePlayer_UserSignIn.Size = new System.Drawing.Size(382, 377);
            this.videoSourcePlayer_UserSignIn.TabIndex = 38;
            this.videoSourcePlayer_UserSignIn.TabStop = false;
            this.videoSourcePlayer_UserSignIn.Text = "videoSourcePlayer_UserSignIn";
            this.videoSourcePlayer_UserSignIn.VideoSource = null;
            // 
            // uploadFiles_btn
            // 
            this.uploadFiles_btn.Location = new System.Drawing.Point(884, 252);
            this.uploadFiles_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uploadFiles_btn.Name = "uploadFiles_btn";
            this.uploadFiles_btn.Size = new System.Drawing.Size(82, 40);
            this.uploadFiles_btn.TabIndex = 37;
            this.uploadFiles_btn.Text = "上传";
            this.uploadFiles_btn.UseVisualStyleBackColor = true;
            this.uploadFiles_btn.Click += new System.EventHandler(this.uploadFiles_btn_Click);
            // 
            // folderBrowser_btn
            // 
            this.folderBrowser_btn.Location = new System.Drawing.Point(762, 254);
            this.folderBrowser_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.folderBrowser_btn.Name = "folderBrowser_btn";
            this.folderBrowser_btn.Size = new System.Drawing.Size(92, 38);
            this.folderBrowser_btn.TabIndex = 36;
            this.folderBrowser_btn.Text = "浏览";
            this.folderBrowser_btn.UseVisualStyleBackColor = true;
            this.folderBrowser_btn.Click += new System.EventHandler(this.folderBrowser_btn_Click);
            // 
            // ImageFolderAddress_tb
            // 
            this.ImageFolderAddress_tb.Location = new System.Drawing.Point(266, 254);
            this.ImageFolderAddress_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImageFolderAddress_tb.Name = "ImageFolderAddress_tb";
            this.ImageFolderAddress_tb.Size = new System.Drawing.Size(492, 35);
            this.ImageFolderAddress_tb.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "文件夹路径：";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(282, 306);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(128, 46);
            this.RemoveBtn.TabIndex = 33;
            this.RemoveBtn.Text = "删除选中";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // FacelistView
            // 
            this.FacelistView.LargeImageList = this.imageLists;
            this.FacelistView.Location = new System.Drawing.Point(116, 358);
            this.FacelistView.Margin = new System.Windows.Forms.Padding(0);
            this.FacelistView.Name = "FacelistView";
            this.FacelistView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FacelistView.Size = new System.Drawing.Size(851, 492);
            this.FacelistView.TabIndex = 32;
            this.FacelistView.UseCompatibleStateImageBehavior = false;
            // 
            // imageLists
            // 
            this.imageLists.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLists.ImageStream")));
            this.imageLists.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLists.Images.SetKeyName(0, "");
            this.imageLists.Images.SetKeyName(1, "");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(616, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(612, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(612, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "*";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(426, 306);
            this.Cancel_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(132, 46);
            this.Cancel_btn.TabIndex = 28;
            this.Cancel_btn.Text = "清空";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // signIn_btn
            // 
            this.signIn_btn.Location = new System.Drawing.Point(116, 869);
            this.signIn_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signIn_btn.Name = "signIn_btn";
            this.signIn_btn.Size = new System.Drawing.Size(132, 42);
            this.signIn_btn.TabIndex = 27;
            this.signIn_btn.Text = "注册";
            this.signIn_btn.UseVisualStyleBackColor = true;
            this.signIn_btn.Click += new System.EventHandler(this.signIn_btn_Click);
            // 
            // ScratchPicture_btn
            // 
            this.ScratchPicture_btn.Location = new System.Drawing.Point(1234, 306);
            this.ScratchPicture_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ScratchPicture_btn.Name = "ScratchPicture_btn";
            this.ScratchPicture_btn.Size = new System.Drawing.Size(132, 48);
            this.ScratchPicture_btn.TabIndex = 26;
            this.ScratchPicture_btn.Text = "抓取照片";
            this.ScratchPicture_btn.UseVisualStyleBackColor = true;
            this.ScratchPicture_btn.Click += new System.EventHandler(this.CatchPicture_btn_Click);
            // 
            // activeCamara_btn
            // 
            this.activeCamara_btn.Location = new System.Drawing.Point(983, 306);
            this.activeCamara_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activeCamara_btn.Name = "activeCamara_btn";
            this.activeCamara_btn.Size = new System.Drawing.Size(152, 48);
            this.activeCamara_btn.TabIndex = 26;
            this.activeCamara_btn.Text = "打开摄像头";
            this.activeCamara_btn.UseVisualStyleBackColor = true;
            this.activeCamara_btn.Click += new System.EventHandler(this.activeCamara_btn_Click);
            // 
            // loadImage_btn
            // 
            this.loadImage_btn.Location = new System.Drawing.Point(116, 306);
            this.loadImage_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadImage_btn.Name = "loadImage_btn";
            this.loadImage_btn.Size = new System.Drawing.Size(132, 48);
            this.loadImage_btn.TabIndex = 25;
            this.loadImage_btn.Text = "添加图片";
            this.loadImage_btn.UseVisualStyleBackColor = true;
            this.loadImage_btn.Click += new System.EventHandler(this.loadImage_btn_Click);
            // 
            // userId_tb
            // 
            this.userId_tb.Location = new System.Drawing.Point(262, 114);
            this.userId_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userId_tb.Name = "userId_tb";
            this.userId_tb.Size = new System.Drawing.Size(344, 35);
            this.userId_tb.TabIndex = 24;
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(120, 114);
            this.UserIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(106, 24);
            this.UserIdLabel.TabIndex = 23;
            this.UserIdLabel.Text = "用户ID：";
            // 
            // pboxImage
            // 
            this.pboxImage.Location = new System.Drawing.Point(124, 360);
            this.pboxImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(342, 164);
            this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxImage.TabIndex = 22;
            this.pboxImage.TabStop = false;
            // 
            // groupId_tb
            // 
            this.groupId_tb.Location = new System.Drawing.Point(262, 40);
            this.groupId_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupId_tb.Name = "groupId_tb";
            this.groupId_tb.Size = new System.Drawing.Size(344, 35);
            this.groupId_tb.TabIndex = 21;
            // 
            // groupIdLabel
            // 
            this.groupIdLabel.AutoSize = true;
            this.groupIdLabel.Location = new System.Drawing.Point(120, 44);
            this.groupIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupIdLabel.Name = "groupIdLabel";
            this.groupIdLabel.Size = new System.Drawing.Size(118, 24);
            this.groupIdLabel.TabIndex = 20;
            this.groupIdLabel.Text = "用户组ID:";
            // 
            // UserName_tb
            // 
            this.UserName_tb.Location = new System.Drawing.Point(266, 188);
            this.UserName_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserName_tb.Name = "UserName_tb";
            this.UserName_tb.Size = new System.Drawing.Size(344, 35);
            this.UserName_tb.TabIndex = 19;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(118, 188);
            this.UserNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(106, 24);
            this.UserNameLabel.TabIndex = 18;
            this.UserNameLabel.Text = "用户名：";
            // 
            // Tab_SignIn
            // 
            this.Tab_SignIn.Controls.Add(this.delete_btn);
            this.Tab_SignIn.Controls.Add(this.users_dataGridView);
            this.Tab_SignIn.Location = new System.Drawing.Point(8, 39);
            this.Tab_SignIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tab_SignIn.Name = "Tab_SignIn";
            this.Tab_SignIn.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tab_SignIn.Size = new System.Drawing.Size(1468, 983);
            this.Tab_SignIn.TabIndex = 1;
            this.Tab_SignIn.Text = "人脸库管理";
            this.Tab_SignIn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(14, 39);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(124, 43);
            this.delete_btn.TabIndex = 1;
            this.delete_btn.Text = "删除";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // users_dataGridView
            // 
            this.users_dataGridView.AutoGenerateColumns = false;
            this.users_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupidDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.userinfoDataGridViewTextBoxColumn});
            this.users_dataGridView.DataSource = this.faceSearchBindingSource;
            this.users_dataGridView.Location = new System.Drawing.Point(4, 83);
            this.users_dataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.users_dataGridView.MultiSelect = false;
            this.users_dataGridView.Name = "users_dataGridView";
            this.users_dataGridView.RowTemplate.Height = 40;
            this.users_dataGridView.Size = new System.Drawing.Size(1310, 856);
            this.users_dataGridView.TabIndex = 0;
            // 
            // groupidDataGridViewTextBoxColumn
            // 
            this.groupidDataGridViewTextBoxColumn.DataPropertyName = "group_id";
            this.groupidDataGridViewTextBoxColumn.HeaderText = "用户组Id";
            this.groupidDataGridViewTextBoxColumn.Name = "groupidDataGridViewTextBoxColumn";
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "用户Id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // userinfoDataGridViewTextBoxColumn
            // 
            this.userinfoDataGridViewTextBoxColumn.DataPropertyName = "user_info";
            this.userinfoDataGridViewTextBoxColumn.HeaderText = "用户名称";
            this.userinfoDataGridViewTextBoxColumn.Name = "userinfoDataGridViewTextBoxColumn";
            // 
            // faceSearchBindingSource
            // 
            this.faceSearchBindingSource.DataSource = typeof(FaceCheckIn_App.FaceSearch);
            // 
            // Tab_CheckIn
            // 
            this.Tab_CheckIn.Controls.Add(this.label5);
            this.Tab_CheckIn.Controls.Add(this.CheckResult_rtb);
            this.Tab_CheckIn.Controls.Add(this.ConfirmCheckIn_btn);
            this.Tab_CheckIn.Controls.Add(this.videoSourcePlayer_UserCheckIn);
            this.Tab_CheckIn.Location = new System.Drawing.Point(8, 39);
            this.Tab_CheckIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tab_CheckIn.Name = "Tab_CheckIn";
            this.Tab_CheckIn.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tab_CheckIn.Size = new System.Drawing.Size(1468, 983);
            this.Tab_CheckIn.TabIndex = 2;
            this.Tab_CheckIn.Text = "用户签到";
            this.Tab_CheckIn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(933, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 44);
            this.label5.TabIndex = 3;
            this.label5.Text = "签到信息：";
            // 
            // CheckResult_rtb
            // 
            this.CheckResult_rtb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CheckResult_rtb.Location = new System.Drawing.Point(940, 61);
            this.CheckResult_rtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckResult_rtb.Name = "CheckResult_rtb";
            this.CheckResult_rtb.ReadOnly = true;
            this.CheckResult_rtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CheckResult_rtb.Size = new System.Drawing.Size(440, 790);
            this.CheckResult_rtb.TabIndex = 2;
            this.CheckResult_rtb.Text = "";
            // 
            // ConfirmCheckIn_btn
            // 
            this.ConfirmCheckIn_btn.Location = new System.Drawing.Point(290, 862);
            this.ConfirmCheckIn_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ConfirmCheckIn_btn.Name = "ConfirmCheckIn_btn";
            this.ConfirmCheckIn_btn.Size = new System.Drawing.Size(150, 46);
            this.ConfirmCheckIn_btn.TabIndex = 1;
            this.ConfirmCheckIn_btn.Text = "确认签到";
            this.ConfirmCheckIn_btn.UseVisualStyleBackColor = true;
            this.ConfirmCheckIn_btn.Click += new System.EventHandler(this.ConfirmCheckIn_btn_Click);
            // 
            // videoSourcePlayer_UserCheckIn
            // 
            this.videoSourcePlayer_UserCheckIn.Location = new System.Drawing.Point(16, 8);
            this.videoSourcePlayer_UserCheckIn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.videoSourcePlayer_UserCheckIn.Name = "videoSourcePlayer_UserCheckIn";
            this.videoSourcePlayer_UserCheckIn.Size = new System.Drawing.Size(878, 842);
            this.videoSourcePlayer_UserCheckIn.TabIndex = 0;
            this.videoSourcePlayer_UserCheckIn.Text = "videoSourcePlayer_UserCheckIn";
            this.videoSourcePlayer_UserCheckIn.VideoSource = null;
            // 
            // ofdOpenImageFile
            // 
            this.ofdOpenImageFile.FileName = "ofdOpenImageFile";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1528, 1133);
            this.Controls.Add(this.UserFace_Page);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeForm";
            this.Text = "签到系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.UserFace_Page.ResumeLayout(false);
            this.Tab_User.ResumeLayout(false);
            this.Tab_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            this.Tab_SignIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.users_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceSearchBindingSource)).EndInit();
            this.Tab_CheckIn.ResumeLayout(false);
            this.Tab_CheckIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl UserFace_Page;
        private System.Windows.Forms.TabPage Tab_User;
        private System.Windows.Forms.TabPage Tab_SignIn;
        private System.Windows.Forms.TabPage Tab_CheckIn;
        private System.Windows.Forms.Button uploadFiles_btn;
        private System.Windows.Forms.Button folderBrowser_btn;
        private System.Windows.Forms.TextBox ImageFolderAddress_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.ListView FacelistView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button signIn_btn;
        private System.Windows.Forms.Button activeCamara_btn;
        private System.Windows.Forms.Button loadImage_btn;
        private System.Windows.Forms.TextBox userId_tb;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.PictureBox pboxImage;
        private System.Windows.Forms.TextBox groupId_tb;
        private System.Windows.Forms.Label groupIdLabel;
        private System.Windows.Forms.TextBox UserName_tb;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.OpenFileDialog ofdOpenImageFile;
        private System.Windows.Forms.ImageList imageLists;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button ConfirmCheckIn_btn;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer_UserCheckIn;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer_UserSignIn;
        private System.Windows.Forms.Button ScratchPicture_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox CheckResult_rtb;
        private System.Windows.Forms.DataGridView users_dataGridView;
        private System.Windows.Forms.BindingSource faceSearchBindingSource;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userinfoDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}