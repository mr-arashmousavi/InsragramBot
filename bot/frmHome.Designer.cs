
namespace bot
{
    partial class frmProf
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
            this.grpFollow = new System.Windows.Forms.GroupBox();
            this.btnShowFollowers = new System.Windows.Forms.Button();
            this.btnShowfollowing = new System.Windows.Forms.Button();
            this.txtPotos = new System.Windows.Forms.TextBox();
            this.txtFollowerd = new System.Windows.Forms.TextBox();
            this.txtFollowing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnJson = new XanderUI.XUIButton();
            this.btnEdit = new XanderUI.XUIButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grpStory = new System.Windows.Forms.GroupBox();
            this.btnSendImage = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.btnSubmitPost = new XanderUI.XUIButton();
            this.grpDirect = new System.Windows.Forms.GroupBox();
            this.btnPostes = new XanderUI.XUIButton();
            this.btnActive = new XanderUI.XUIButton();
            this.direct = new XanderUI.XUIButton();
            this.progressBar1 = new XanderUI.XUICircleProgressBar();
            this.lodingLbl = new System.Windows.Forms.Label();
            this.lblStory = new System.Windows.Forms.Label();
            this.backPross = new System.ComponentModel.BackgroundWorker();
            this.timeLoad = new System.Windows.Forms.Timer(this.components);
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Timer(this.components);
            this.formDropShadow1 = new XanderUI.FormDropShadow();
            this.grpFollow.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.grpStory.SuspendLayout();
            this.grpDirect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFollow
            // 
            this.grpFollow.Controls.Add(this.btnShowFollowers);
            this.grpFollow.Controls.Add(this.btnShowfollowing);
            this.grpFollow.Controls.Add(this.txtPotos);
            this.grpFollow.Controls.Add(this.txtFollowerd);
            this.grpFollow.Controls.Add(this.txtFollowing);
            this.grpFollow.Controls.Add(this.label3);
            this.grpFollow.Controls.Add(this.label2);
            this.grpFollow.Controls.Add(this.label1);
            this.grpFollow.Location = new System.Drawing.Point(138, 12);
            this.grpFollow.Name = "grpFollow";
            this.grpFollow.Size = new System.Drawing.Size(319, 99);
            this.grpFollow.TabIndex = 1;
            this.grpFollow.TabStop = false;
            // 
            // btnShowFollowers
            // 
            this.btnShowFollowers.Location = new System.Drawing.Point(6, 60);
            this.btnShowFollowers.Name = "btnShowFollowers";
            this.btnShowFollowers.Size = new System.Drawing.Size(100, 23);
            this.btnShowFollowers.TabIndex = 7;
            this.btnShowFollowers.Text = "نمایش followers";
            this.btnShowFollowers.UseVisualStyleBackColor = true;
            this.btnShowFollowers.Click += new System.EventHandler(this.btnShowFollowers_Click);
            // 
            // btnShowfollowing
            // 
            this.btnShowfollowing.Location = new System.Drawing.Point(6, 26);
            this.btnShowfollowing.Name = "btnShowfollowing";
            this.btnShowfollowing.Size = new System.Drawing.Size(100, 23);
            this.btnShowfollowing.TabIndex = 6;
            this.btnShowfollowing.Text = "نمایش following";
            this.btnShowfollowing.UseVisualStyleBackColor = true;
            this.btnShowfollowing.Click += new System.EventHandler(this.btnShowfollowing_Click);
            // 
            // txtPotos
            // 
            this.txtPotos.Location = new System.Drawing.Point(126, 61);
            this.txtPotos.Name = "txtPotos";
            this.txtPotos.Size = new System.Drawing.Size(39, 22);
            this.txtPotos.TabIndex = 5;
            // 
            // txtFollowerd
            // 
            this.txtFollowerd.Location = new System.Drawing.Point(186, 61);
            this.txtFollowerd.Name = "txtFollowerd";
            this.txtFollowerd.Size = new System.Drawing.Size(39, 22);
            this.txtFollowerd.TabIndex = 4;
            // 
            // txtFollowing
            // 
            this.txtFollowing.Location = new System.Drawing.Point(263, 61);
            this.txtFollowing.Name = "txtFollowing";
            this.txtFollowing.Size = new System.Drawing.Size(39, 22);
            this.txtFollowing.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "پست ها ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "پیروان ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "دنبال میکنید";
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnJson);
            this.grpInfo.Controls.Add(this.btnEdit);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.txtNumber);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.txtEmail);
            this.grpInfo.Controls.Add(this.txtSite);
            this.grpInfo.Controls.Add(this.txtFullname);
            this.grpInfo.Controls.Add(this.txtUserName);
            this.grpInfo.Location = new System.Drawing.Point(12, 108);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(439, 162);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "اطلاعات شما ";
            // 
            // btnJson
            // 
            this.btnJson.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJson.ButtonImage = global::bot.Properties.Resources.json;
            this.btnJson.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnJson.ButtonText = "";
            this.btnJson.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnJson.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnJson.CornerRadius = 5;
            this.btnJson.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnJson.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnJson.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnJson.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnJson.Location = new System.Drawing.Point(282, 111);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(33, 33);
            this.btnJson.TabIndex = 10;
            this.btnJson.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnJson.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.ButtonImage = global::bot.Properties.Resources.download;
            this.btnEdit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnEdit.ButtonText = "";
            this.btnEdit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnEdit.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.CornerRadius = 5;
            this.btnEdit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEdit.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEdit.Location = new System.Drawing.Point(372, 111);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(33, 33);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 14);
            this.label8.TabIndex = 9;
            this.label8.Text = "موبایل";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(6, 113);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "سایت ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "ایمیل";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "نام کامل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "نام کاربری";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 32);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(6, 74);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(100, 22);
            this.txtSite.TabIndex = 2;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(252, 74);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(100, 22);
            this.txtFullname.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(252, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 0;
            // 
            // grpStory
            // 
            this.grpStory.Controls.Add(this.btnSendImage);
            this.grpStory.Controls.Add(this.label9);
            this.grpStory.Controls.Add(this.txtCaption);
            this.grpStory.Controls.Add(this.btnSubmitPost);
            this.grpStory.Location = new System.Drawing.Point(12, 276);
            this.grpStory.Name = "grpStory";
            this.grpStory.Size = new System.Drawing.Size(436, 110);
            this.grpStory.TabIndex = 3;
            this.grpStory.TabStop = false;
            this.grpStory.Text = "استوری و پست ";
            // 
            // btnSendImage
            // 
            this.btnSendImage.Location = new System.Drawing.Point(203, 72);
            this.btnSendImage.Name = "btnSendImage";
            this.btnSendImage.Size = new System.Drawing.Size(216, 23);
            this.btnSendImage.TabIndex = 8;
            this.btnSendImage.Text = "تصویر ";
            this.btnSendImage.UseVisualStyleBackColor = true;
            this.btnSendImage.Click += new System.EventHandler(this.btnSendImage_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "عنوان ";
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(204, 44);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(215, 22);
            this.txtCaption.TabIndex = 11;
            // 
            // btnSubmitPost
            // 
            this.btnSubmitPost.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmitPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitPost.ButtonImage = global::bot.Properties.Resources.posts1;
            this.btnSubmitPost.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSubmitPost.ButtonText = "پست بفرست ";
            this.btnSubmitPost.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSubmitPost.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmitPost.CornerRadius = 5;
            this.btnSubmitPost.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSubmitPost.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSubmitPost.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmitPost.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSubmitPost.Location = new System.Drawing.Point(6, 21);
            this.btnSubmitPost.Name = "btnSubmitPost";
            this.btnSubmitPost.Size = new System.Drawing.Size(162, 65);
            this.btnSubmitPost.TabIndex = 0;
            this.btnSubmitPost.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmitPost.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSubmitPost.Click += new System.EventHandler(this.btnSubmitPost_Click);
            // 
            // grpDirect
            // 
            this.grpDirect.Controls.Add(this.btnPostes);
            this.grpDirect.Controls.Add(this.btnActive);
            this.grpDirect.Controls.Add(this.direct);
            this.grpDirect.Location = new System.Drawing.Point(15, 392);
            this.grpDirect.Name = "grpDirect";
            this.grpDirect.Size = new System.Drawing.Size(433, 91);
            this.grpDirect.TabIndex = 4;
            this.grpDirect.TabStop = false;
            this.grpDirect.Text = "دستورات ";
            // 
            // btnPostes
            // 
            this.btnPostes.BackgroundColor = System.Drawing.Color.White;
            this.btnPostes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPostes.ButtonImage = global::bot.Properties.Resources.direct;
            this.btnPostes.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnPostes.ButtonText = "لیست پست ها ";
            this.btnPostes.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnPostes.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnPostes.CornerRadius = 5;
            this.btnPostes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPostes.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPostes.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnPostes.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnPostes.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnPostes.Location = new System.Drawing.Point(279, 20);
            this.btnPostes.Name = "btnPostes";
            this.btnPostes.Size = new System.Drawing.Size(114, 65);
            this.btnPostes.TabIndex = 16;
            this.btnPostes.TextColor = System.Drawing.Color.Black;
            this.btnPostes.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPostes.Click += new System.EventHandler(this.btnPostes_Click);
            // 
            // btnActive
            // 
            this.btnActive.BackgroundColor = System.Drawing.Color.White;
            this.btnActive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActive.ButtonImage = global::bot.Properties.Resources.direct;
            this.btnActive.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnActive.ButtonText = "آخرین فعالیت ها ";
            this.btnActive.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnActive.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnActive.CornerRadius = 5;
            this.btnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnActive.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnActive.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnActive.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnActive.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnActive.Location = new System.Drawing.Point(150, 20);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(114, 65);
            this.btnActive.TabIndex = 15;
            this.btnActive.TextColor = System.Drawing.Color.Black;
            this.btnActive.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // direct
            // 
            this.direct.BackgroundColor = System.Drawing.Color.White;
            this.direct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.direct.ButtonImage = global::bot.Properties.Resources.direct;
            this.direct.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.direct.ButtonText = "لیست دایرکت ها ";
            this.direct.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.direct.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.direct.CornerRadius = 5;
            this.direct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.direct.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.direct.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.direct.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.direct.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.direct.Location = new System.Drawing.Point(6, 20);
            this.direct.Name = "direct";
            this.direct.Size = new System.Drawing.Size(124, 65);
            this.direct.TabIndex = 14;
            this.direct.TextColor = System.Drawing.Color.Black;
            this.direct.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.direct.Click += new System.EventHandler(this.direct_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.AnimationSpeed = 5;
            this.progressBar1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.progressBar1.FilledColorAlpha = 130;
            this.progressBar1.FilledThickness = 40;
            this.progressBar1.IsAnimated = false;
            this.progressBar1.Location = new System.Drawing.Point(-5, 453);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Percentage = 0;
            this.progressBar1.ShowText = true;
            this.progressBar1.Size = new System.Drawing.Size(200, 123);
            this.progressBar1.TabIndex = 5;
            this.progressBar1.TextColor = System.Drawing.Color.Gray;
            this.progressBar1.TextSize = 25;
            this.progressBar1.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.progressBar1.UnfilledThickness = 24;
            // 
            // lodingLbl
            // 
            this.lodingLbl.AutoSize = true;
            this.lodingLbl.Location = new System.Drawing.Point(237, 496);
            this.lodingLbl.Name = "lodingLbl";
            this.lodingLbl.Size = new System.Drawing.Size(182, 14);
            this.lodingLbl.TabIndex = 6;
            this.lodingLbl.Text = "در حال بارگزاری هستم دوست من ";
            // 
            // lblStory
            // 
            this.lblStory.AutoSize = true;
            this.lblStory.Location = new System.Drawing.Point(331, 519);
            this.lblStory.Name = "lblStory";
            this.lblStory.Size = new System.Drawing.Size(41, 14);
            this.lblStory.TabIndex = 7;
            this.lblStory.Text = "صبر ...";
            // 
            // timeLoad
            // 
            this.timeLoad.Interval = 5000;
            this.timeLoad.Tick += new System.EventHandler(this.timeLoad_Tick);
            // 
            // pcImage
            // 
            this.pcImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcImage.Location = new System.Drawing.Point(12, 3);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(111, 99);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImage.TabIndex = 8;
            this.pcImage.TabStop = false;
            // 
            // formDropShadow1
            // 
            this.formDropShadow1.EffectedForm = this;
            this.formDropShadow1.ShadowAngle = 2;
            // 
            // frmProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 544);
            this.Controls.Add(this.pcImage);
            this.Controls.Add(this.lblStory);
            this.Controls.Add(this.lodingLbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.grpDirect);
            this.Controls.Add(this.grpStory);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpFollow);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProf";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "frmHome";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProf_FormClosed_1);
            this.Load += new System.EventHandler(this.frmProf_Load);
            this.grpFollow.ResumeLayout(false);
            this.grpFollow.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpStory.ResumeLayout(false);
            this.grpStory.PerformLayout();
            this.grpDirect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpFollow;
        private System.Windows.Forms.Button btnShowFollowers;
        private System.Windows.Forms.Button btnShowfollowing;
        private System.Windows.Forms.TextBox txtPotos;
        private System.Windows.Forms.TextBox txtFollowerd;
        private System.Windows.Forms.TextBox txtFollowing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtUserName;
        private XanderUI.XUIButton btnEdit;
        private XanderUI.XUIButton btnJson;
        private System.Windows.Forms.GroupBox grpStory;
        private XanderUI.XUIButton btnSubmitPost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.Button btnSendImage;
        private System.Windows.Forms.GroupBox grpDirect;
        private XanderUI.XUIButton direct;
        private XanderUI.XUIButton btnPostes;
        private XanderUI.XUIButton btnActive;
        private System.Windows.Forms.Label lblStory;
        private System.Windows.Forms.Label lodingLbl;
        private XanderUI.XUICircleProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backPross;
        private System.Windows.Forms.Timer timeLoad;
        private System.Windows.Forms.PictureBox pcImage;
        private System.Windows.Forms.Timer close;
        public XanderUI.FormDropShadow formDropShadow1;
    }
}