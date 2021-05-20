
namespace bot
{
    partial class frmChengeUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChengeUser));
            this.btnOther = new XanderUI.XUIButton();
            this.btnMyPosts = new XanderUI.XUIButton();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.btnFollowing = new XanderUI.XUIButton();
            this.btnFollowers = new XanderUI.XUIButton();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn = new XanderUI.XUIButton();
            this.grpUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOther
            // 
            this.btnOther.BackgroundColor = System.Drawing.Color.White;
            this.btnOther.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnOther.ButtonImage")));
            this.btnOther.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnOther.ButtonText = "پست های کاربر دیگری رو میخوام ";
            this.btnOther.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnOther.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnOther.CornerRadius = 5;
            this.btnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnOther.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOther.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnOther.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnOther.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnOther.Location = new System.Drawing.Point(69, 22);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(235, 50);
            this.btnOther.TabIndex = 1;
            this.btnOther.TextColor = System.Drawing.Color.Black;
            this.btnOther.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnMyPosts
            // 
            this.btnMyPosts.BackgroundColor = System.Drawing.Color.White;
            this.btnMyPosts.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnMyPosts.ButtonImage")));
            this.btnMyPosts.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnMyPosts.ButtonText = "پست های خودم رو میخوام ";
            this.btnMyPosts.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnMyPosts.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMyPosts.CornerRadius = 5;
            this.btnMyPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnMyPosts.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMyPosts.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnMyPosts.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnMyPosts.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnMyPosts.Location = new System.Drawing.Point(350, 22);
            this.btnMyPosts.Name = "btnMyPosts";
            this.btnMyPosts.Size = new System.Drawing.Size(200, 50);
            this.btnMyPosts.TabIndex = 0;
            this.btnMyPosts.TextColor = System.Drawing.Color.Black;
            this.btnMyPosts.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnMyPosts.Click += new System.EventHandler(this.btnMyPosts_Click);
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.btn);
            this.grpUser.Controls.Add(this.label1);
            this.grpUser.Controls.Add(this.txtUser);
            this.grpUser.Controls.Add(this.btnFollowing);
            this.grpUser.Controls.Add(this.btnFollowers);
            this.grpUser.Location = new System.Drawing.Point(50, 78);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(500, 116);
            this.grpUser.TabIndex = 2;
            this.grpUser.TabStop = false;
            // 
            // btnFollowing
            // 
            this.btnFollowing.BackgroundColor = System.Drawing.Color.White;
            this.btnFollowing.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnFollowing.ButtonImage")));
            this.btnFollowing.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnFollowing.ButtonText = "از فالووینگ ها ";
            this.btnFollowing.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnFollowing.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFollowing.CornerRadius = 5;
            this.btnFollowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnFollowing.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFollowing.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnFollowing.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFollowing.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnFollowing.Location = new System.Drawing.Point(95, 20);
            this.btnFollowing.Name = "btnFollowing";
            this.btnFollowing.Size = new System.Drawing.Size(147, 31);
            this.btnFollowing.TabIndex = 4;
            this.btnFollowing.TextColor = System.Drawing.Color.Black;
            this.btnFollowing.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFollowing.Click += new System.EventHandler(this.btnFollowing_Click);
            // 
            // btnFollowers
            // 
            this.btnFollowers.BackgroundColor = System.Drawing.Color.White;
            this.btnFollowers.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnFollowers.ButtonImage")));
            this.btnFollowers.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnFollowers.ButtonText = "از فالوور ها ";
            this.btnFollowers.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnFollowers.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFollowers.CornerRadius = 5;
            this.btnFollowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnFollowers.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFollowers.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnFollowers.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFollowers.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnFollowers.Location = new System.Drawing.Point(300, 20);
            this.btnFollowers.Name = "btnFollowers";
            this.btnFollowers.Size = new System.Drawing.Size(110, 31);
            this.btnFollowers.TabIndex = 3;
            this.btnFollowers.TextColor = System.Drawing.Color.Black;
            this.btnFollowers.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFollowers.Click += new System.EventHandler(this.btnFollowers_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(212, 83);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(167, 21);
            this.txtUser.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام کاربری";
            // 
            // btn
            // 
            this.btn.BackgroundColor = System.Drawing.Color.White;
            this.btn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn.ButtonImage")));
            this.btn.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btn.ButtonText = "کاربر وارد شده";
            this.btn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btn.CornerRadius = 5;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btn.Location = new System.Drawing.Point(59, 73);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(147, 31);
            this.btn.TabIndex = 7;
            this.btn.TextColor = System.Drawing.Color.Black;
            this.btn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btn.Click += new System.EventHandler(this.xuiButton1_Click);
            // 
            // frmChengeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 194);
            this.Controls.Add(this.grpUser);
            this.Controls.Add(this.btnOther);
            this.Controls.Add(this.btnMyPosts);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChengeUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب نوع ";
            this.Load += new System.EventHandler(this.frmChengeUser_Load);
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIButton btnMyPosts;
        private XanderUI.XUIButton btnOther;
        private System.Windows.Forms.GroupBox grpUser;
        private XanderUI.XUIButton btnFollowing;
        private XanderUI.XUIButton btnFollowers;
        private XanderUI.XUIButton btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
    }
}