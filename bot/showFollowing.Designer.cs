
namespace bot
{
    partial class showFollowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showFollowing));
            this.grpIn = new System.Windows.Forms.GroupBox();
            this.btnUnBlock = new XanderUI.XUIButton();
            this.btnBlock = new XanderUI.XUIButton();
            this.btnUnFollow = new XanderUI.XUIButton();
            this.btnFollow = new XanderUI.XUIButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.grpBlock = new System.Windows.Forms.GroupBox();
            this.dgvBlock = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFolloing = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowPosts = new XanderUI.XUIButton();
            this.grpIn.SuspendLayout();
            this.grpBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlock)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolloing)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIn
            // 
            this.grpIn.Controls.Add(this.btnShowPosts);
            this.grpIn.Controls.Add(this.btnUnBlock);
            this.grpIn.Controls.Add(this.btnBlock);
            this.grpIn.Controls.Add(this.btnUnFollow);
            this.grpIn.Controls.Add(this.btnFollow);
            this.grpIn.Controls.Add(this.txtUserName);
            this.grpIn.Controls.Add(this.label1);
            this.grpIn.Location = new System.Drawing.Point(12, 12);
            this.grpIn.Name = "grpIn";
            this.grpIn.Size = new System.Drawing.Size(466, 153);
            this.grpIn.TabIndex = 0;
            this.grpIn.TabStop = false;
            // 
            // btnUnBlock
            // 
            this.btnUnBlock.BackgroundColor = System.Drawing.Color.White;
            this.btnUnBlock.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnUnBlock.ButtonImage")));
            this.btnUnBlock.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnUnBlock.ButtonText = "آن بلاک ";
            this.btnUnBlock.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnUnBlock.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUnBlock.CornerRadius = 5;
            this.btnUnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnUnBlock.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUnBlock.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnUnBlock.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUnBlock.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUnBlock.Location = new System.Drawing.Point(19, 98);
            this.btnUnBlock.Name = "btnUnBlock";
            this.btnUnBlock.Size = new System.Drawing.Size(133, 35);
            this.btnUnBlock.TabIndex = 5;
            this.btnUnBlock.TextColor = System.Drawing.Color.Black;
            this.btnUnBlock.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUnBlock.Click += new System.EventHandler(this.btnUnBlock_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.BackgroundColor = System.Drawing.Color.White;
            this.btnBlock.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnBlock.ButtonImage")));
            this.btnBlock.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnBlock.ButtonText = "بلاک ";
            this.btnBlock.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnBlock.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnBlock.CornerRadius = 5;
            this.btnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBlock.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBlock.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnBlock.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnBlock.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnBlock.Location = new System.Drawing.Point(325, 98);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(133, 35);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.TextColor = System.Drawing.Color.Black;
            this.btnBlock.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnUnFollow
            // 
            this.btnUnFollow.BackgroundColor = System.Drawing.Color.White;
            this.btnUnFollow.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnUnFollow.ButtonImage")));
            this.btnUnFollow.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnUnFollow.ButtonText = "آن فالو ";
            this.btnUnFollow.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnUnFollow.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUnFollow.CornerRadius = 5;
            this.btnUnFollow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnUnFollow.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUnFollow.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnUnFollow.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnUnFollow.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnUnFollow.Location = new System.Drawing.Point(19, 63);
            this.btnUnFollow.Name = "btnUnFollow";
            this.btnUnFollow.Size = new System.Drawing.Size(133, 29);
            this.btnUnFollow.TabIndex = 3;
            this.btnUnFollow.TextColor = System.Drawing.Color.Black;
            this.btnUnFollow.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnUnFollow.Click += new System.EventHandler(this.btnUnFollow_Click);
            // 
            // btnFollow
            // 
            this.btnFollow.BackgroundColor = System.Drawing.Color.White;
            this.btnFollow.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnFollow.ButtonImage")));
            this.btnFollow.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnFollow.ButtonText = "فالو";
            this.btnFollow.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnFollow.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFollow.CornerRadius = 5;
            this.btnFollow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnFollow.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFollow.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnFollow.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnFollow.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnFollow.Location = new System.Drawing.Point(325, 63);
            this.btnFollow.Name = "btnFollow";
            this.btnFollow.Size = new System.Drawing.Size(133, 29);
            this.btnFollow.TabIndex = 2;
            this.btnFollow.TextColor = System.Drawing.Color.Black;
            this.btnFollow.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFollow.Click += new System.EventHandler(this.btnFollow_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(79, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(300, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری";
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(112, 168);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(230, 14);
            this.lblLoad.TabIndex = 6;
            this.lblLoad.Text = "صبر بده جون خودت اطلاعات بیاد کاکوی گلم ";
            // 
            // grpBlock
            // 
            this.grpBlock.Controls.Add(this.dgvBlock);
            this.grpBlock.Location = new System.Drawing.Point(258, 198);
            this.grpBlock.Name = "grpBlock";
            this.grpBlock.Size = new System.Drawing.Size(226, 440);
            this.grpBlock.TabIndex = 7;
            this.grpBlock.TabStop = false;
            this.grpBlock.Text = "بلاک شده ها";
            // 
            // dgvBlock
            // 
            this.dgvBlock.AllowUserToAddRows = false;
            this.dgvBlock.AllowUserToDeleteRows = false;
            this.dgvBlock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBlock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.fullName});
            this.dgvBlock.Location = new System.Drawing.Point(7, 22);
            this.dgvBlock.Name = "dgvBlock";
            this.dgvBlock.ReadOnly = true;
            this.dgvBlock.Size = new System.Drawing.Size(213, 403);
            this.dgvBlock.TabIndex = 0;
            this.dgvBlock.SelectionChanged += new System.EventHandler(this.dgvBlock_SelectionChanged);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFolloing);
            this.groupBox1.Location = new System.Drawing.Point(3, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 440);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دنبال کنندگان ";
            // 
            // dgvFolloing
            // 
            this.dgvFolloing.AllowUserToAddRows = false;
            this.dgvFolloing.AllowUserToDeleteRows = false;
            this.dgvFolloing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFolloing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFolloing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvFolloing.Location = new System.Drawing.Point(7, 22);
            this.dgvFolloing.Name = "dgvFolloing";
            this.dgvFolloing.ReadOnly = true;
            this.dgvFolloing.Size = new System.Drawing.Size(224, 403);
            this.dgvFolloing.TabIndex = 0;
            this.dgvFolloing.SelectionChanged += new System.EventHandler(this.dgvFolloing_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "نام کاربری";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "نام کامل";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // btnShowPosts
            // 
            this.btnShowPosts.BackgroundColor = System.Drawing.Color.White;
            this.btnShowPosts.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnShowPosts.ButtonImage")));
            this.btnShowPosts.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.btnShowPosts.ButtonText = "پست ها ";
            this.btnShowPosts.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnShowPosts.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnShowPosts.CornerRadius = 5;
            this.btnShowPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnShowPosts.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowPosts.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnShowPosts.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnShowPosts.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnShowPosts.Location = new System.Drawing.Point(174, 98);
            this.btnShowPosts.Name = "btnShowPosts";
            this.btnShowPosts.Size = new System.Drawing.Size(133, 35);
            this.btnShowPosts.TabIndex = 6;
            this.btnShowPosts.TextColor = System.Drawing.Color.Black;
            this.btnShowPosts.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnShowPosts.Click += new System.EventHandler(this.btnShowPosts_Click);
            // 
            // showFollowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBlock);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.grpIn);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "showFollowing";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "نمایش دنبال کنندهگان ";
            this.Load += new System.EventHandler(this.showFollowing_Load);
            this.grpIn.ResumeLayout(false);
            this.grpIn.PerformLayout();
            this.grpBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFolloing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIn;
        private XanderUI.XUIButton btnUnBlock;
        private XanderUI.XUIButton btnBlock;
        private XanderUI.XUIButton btnUnFollow;
        private XanderUI.XUIButton btnFollow;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.GroupBox grpBlock;
        private System.Windows.Forms.DataGridView dgvBlock;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFolloing;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private XanderUI.XUIButton btnShowPosts;
    }
}