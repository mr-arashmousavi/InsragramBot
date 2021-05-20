
namespace bot
{
    partial class frmEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdit));
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.rdbChengePass = new XanderUI.XUIRadio();
            this.btnEdit = new XanderUI.XUIButton();
            this.rbMale = new XanderUI.XUIRadio();
            this.rbFemale = new XanderUI.XUIRadio();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnImage = new XanderUI.XUIButton();
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.rdbChengePass);
            this.grpInfo.Controls.Add(this.btnEdit);
            this.grpInfo.Controls.Add(this.rbMale);
            this.grpInfo.Controls.Add(this.rbFemale);
            this.grpInfo.Controls.Add(this.label9);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.txtPass);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.txtOldPass);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.txtBio);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.txtMobile);
            this.grpInfo.Controls.Add(this.label3);
            this.grpInfo.Controls.Add(this.txtSite);
            this.grpInfo.Controls.Add(this.label4);
            this.grpInfo.Controls.Add(this.txtEmail);
            this.grpInfo.Controls.Add(this.label2);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.txtUserName);
            this.grpInfo.Controls.Add(this.btnImage);
            this.grpInfo.Controls.Add(this.pcImage);
            this.grpInfo.Location = new System.Drawing.Point(21, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(363, 567);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            // 
            // rdbChengePass
            // 
            this.rdbChengePass.Checked = false;
            this.rdbChengePass.ForeColor = System.Drawing.Color.Black;
            this.rdbChengePass.Location = new System.Drawing.Point(40, 386);
            this.rdbChengePass.Name = "rdbChengePass";
            this.rdbChengePass.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.rdbChengePass.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.rdbChengePass.RadioStyle = XanderUI.XUIRadio.Style.iOS;
            this.rdbChengePass.Size = new System.Drawing.Size(269, 16);
            this.rdbChengePass.TabIndex = 22;
            this.rdbChengePass.Text = "آیا میخواهید کلمه عبور تغییر دهید ";
            this.rdbChengePass.Click += new System.EventHandler(this.rdbChengePass_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.ButtonImage = global::bot.Properties.Resources.download;
            this.btnEdit.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnEdit.ButtonText = "ویرایش مشخصات ";
            this.btnEdit.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnEdit.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.CornerRadius = 5;
            this.btnEdit.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEdit.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEdit.Location = new System.Drawing.Point(33, 528);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(117, 33);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rbMale
            // 
            this.rbMale.Checked = false;
            this.rbMale.ForeColor = System.Drawing.Color.Black;
            this.rbMale.Location = new System.Drawing.Point(160, 501);
            this.rbMale.Name = "rbMale";
            this.rbMale.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.rbMale.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.rbMale.RadioStyle = XanderUI.XUIRadio.Style.iOS;
            this.rbMale.Size = new System.Drawing.Size(100, 16);
            this.rbMale.TabIndex = 20;
            this.rbMale.Text = "مرد";
            // 
            // rbFemale
            // 
            this.rbFemale.Checked = false;
            this.rbFemale.ForeColor = System.Drawing.Color.Black;
            this.rbFemale.Location = new System.Drawing.Point(33, 501);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.rbFemale.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.rbFemale.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.rbFemale.Size = new System.Drawing.Size(100, 16);
            this.rbFemale.TabIndex = 19;
            this.rbFemale.Text = "خانم ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "جنسیت ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "پسورد جدید ";
            this.label5.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(23, 463);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(210, 22);
            this.txtPass.TabIndex = 16;
            this.txtPass.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "پسورد قدیم ";
            this.label6.Visible = false;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(23, 408);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(210, 22);
            this.txtOldPass.TabIndex = 14;
            this.txtOldPass.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "بیوگرافی";
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(23, 322);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(210, 58);
            this.txtBio.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "مبایل ";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(23, 289);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(210, 22);
            this.txtMobile.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "سایت ";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(23, 249);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(210, 22);
            this.txtSite.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "ایمیل ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(23, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(210, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "نام کامل";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(23, 172);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 22);
            this.txtName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "نام کاربری";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(23, 123);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(210, 22);
            this.txtUserName.TabIndex = 2;
            // 
            // btnImage
            // 
            this.btnImage.BackgroundColor = System.Drawing.Color.White;
            this.btnImage.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnImage.ButtonImage")));
            this.btnImage.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnImage.ButtonText = "ویرایش تصویر";
            this.btnImage.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnImage.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImage.CornerRadius = 5;
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnImage.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImage.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnImage.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnImage.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnImage.Location = new System.Drawing.Point(23, 44);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(110, 50);
            this.btnImage.TabIndex = 1;
            this.btnImage.TextColor = System.Drawing.Color.Black;
            this.btnImage.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // pcImage
            // 
            this.pcImage.Location = new System.Drawing.Point(166, 21);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(127, 86);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImage.TabIndex = 0;
            this.pcImage.TabStop = false;
            this.pcImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 591);
            this.Controls.Add(this.grpInfo);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private XanderUI.XUIButton btnImage;
        private System.Windows.Forms.PictureBox pcImage;
        private XanderUI.XUIRadio rbMale;
        private XanderUI.XUIRadio rbFemale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private XanderUI.XUIButton btnEdit;
        private XanderUI.XUIRadio rdbChengePass;
    }
}