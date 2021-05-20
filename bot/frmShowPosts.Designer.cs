
namespace bot
{
    partial class frmShowPosts
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laiks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(506, 629);
            this.webBrowser1.TabIndex = 1;
            // 
            // dgvPosts
            // 
            this.dgvPosts.AllowUserToAddRows = false;
            this.dgvPosts.AllowUserToDeleteRows = false;
            this.dgvPosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.count,
            this.laiks,
            this.comments,
            this.showPost});
            this.dgvPosts.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvPosts.Location = new System.Drawing.Point(512, 0);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.ReadOnly = true;
            this.dgvPosts.Size = new System.Drawing.Size(417, 629);
            this.dgvPosts.TabIndex = 2;
            this.dgvPosts.SelectionChanged += new System.EventHandler(this.dgvPosts_SelectionChanged);
            // 
            // count
            // 
            this.count.HeaderText = "تعداد آلبوم ";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // laiks
            // 
            this.laiks.HeaderText = "تعداد لایک ها ";
            this.laiks.Name = "laiks";
            this.laiks.ReadOnly = true;
            // 
            // comments
            // 
            this.comments.HeaderText = "تعداد کامنت ها ";
            this.comments.Name = "comments";
            this.comments.ReadOnly = true;
            // 
            // showPost
            // 
            this.showPost.HeaderText = "نمایش پست ";
            this.showPost.Name = "showPost";
            this.showPost.ReadOnly = true;
            // 
            // frmShowPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 629);
            this.Controls.Add(this.dgvPosts);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmShowPosts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmShowPosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn laiks;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn showPost;
    }
}