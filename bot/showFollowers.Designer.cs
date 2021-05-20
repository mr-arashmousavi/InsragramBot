
namespace bot
{
    partial class showFollowers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showFollowers));
            this.grpBlock = new System.Windows.Forms.GroupBox();
            this.btnShowPosts = new XanderUI.XUIButton();
            this.btnSend = new XanderUI.XUIButton();
            this.dgvFollowers = new System.Windows.Forms.DataGridView();
            this.lblLoad = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBlock
            // 
            this.grpBlock.Controls.Add(this.btnShowPosts);
            this.grpBlock.Controls.Add(this.btnSend);
            this.grpBlock.Controls.Add(this.dgvFollowers);
            this.grpBlock.Location = new System.Drawing.Point(38, 79);
            this.grpBlock.Name = "grpBlock";
            this.grpBlock.Size = new System.Drawing.Size(385, 458);
            this.grpBlock.TabIndex = 9;
            this.grpBlock.TabStop = false;
            this.grpBlock.Text = "فالوور ها";
            // 
            // btnShowPosts
            // 
            this.btnShowPosts.BackgroundColor = System.Drawing.Color.White;
            this.btnShowPosts.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnShowPosts.ButtonImage")));
            this.btnShowPosts.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnShowPosts.ButtonText = "نمایش پست ها";
            this.btnShowPosts.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnShowPosts.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnShowPosts.CornerRadius = 5;
            this.btnShowPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnShowPosts.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowPosts.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnShowPosts.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnShowPosts.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnShowPosts.Location = new System.Drawing.Point(212, 432);
            this.btnShowPosts.Name = "btnShowPosts";
            this.btnShowPosts.Size = new System.Drawing.Size(139, 26);
            this.btnShowPosts.TabIndex = 6;
            this.btnShowPosts.TextColor = System.Drawing.Color.Black;
            this.btnShowPosts.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowPosts.Click += new System.EventHandler(this.btnShowPosts_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackgroundColor = System.Drawing.Color.White;
            this.btnSend.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSend.ButtonImage")));
            this.btnSend.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnSend.ButtonText = "ارسال دایرکت ";
            this.btnSend.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.btnSend.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnSend.CornerRadius = 5;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSend.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSend.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnSend.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.btnSend.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSend.Location = new System.Drawing.Point(7, 432);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(139, 26);
            this.btnSend.TabIndex = 5;
            this.btnSend.TextColor = System.Drawing.Color.Black;
            this.btnSend.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // dgvFollowers
            // 
            this.dgvFollowers.AllowUserToAddRows = false;
            this.dgvFollowers.AllowUserToDeleteRows = false;
            this.dgvFollowers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFollowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.fullName,
            this.provider});
            this.dgvFollowers.Location = new System.Drawing.Point(7, 22);
            this.dgvFollowers.Name = "dgvFollowers";
            this.dgvFollowers.ReadOnly = true;
            this.dgvFollowers.Size = new System.Drawing.Size(373, 404);
            this.dgvFollowers.TabIndex = 0;
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(107, 46);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(230, 14);
            this.lblLoad.TabIndex = 8;
            this.lblLoad.Text = "صبر بده جون خودت اطلاعات بیاد کاکوی گلم ";
            // 
            // userName
            // 
            this.userName.HeaderText = "نام کاربری";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "نام کامل";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // provider
            // 
            this.provider.HeaderText = "خصوصی";
            this.provider.Name = "provider";
            this.provider.ReadOnly = true;
            // 
            // showFollowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 560);
            this.Controls.Add(this.grpBlock);
            this.Controls.Add(this.lblLoad);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "showFollowers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نمایش دنبال کنندگان ";
            this.Load += new System.EventHandler(this.showFollowers_Load);
            this.grpBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBlock;
        private System.Windows.Forms.DataGridView dgvFollowers;
        private System.Windows.Forms.Label lblLoad;
        private XanderUI.XUIButton btnSend;
        private XanderUI.XUIButton btnShowPosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn provider;
    }
}