
namespace instagramBot
{
    partial class frmActivity
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
            this.grvActivity = new System.Windows.Forms.GroupBox();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grvActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // grvActivity
            // 
            this.grvActivity.Controls.Add(this.dgvActivity);
            this.grvActivity.Location = new System.Drawing.Point(12, 41);
            this.grvActivity.Name = "grvActivity";
            this.grvActivity.Size = new System.Drawing.Size(389, 486);
            this.grvActivity.TabIndex = 1;
            this.grvActivity.TabStop = false;
            // 
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.text,
            this.time,
            this.hours});
            this.dgvActivity.Location = new System.Drawing.Point(6, 21);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.RowTemplate.Height = 25;
            this.dgvActivity.Size = new System.Drawing.Size(377, 447);
            this.dgvActivity.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(389, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // text
            // 
            this.text.HeaderText = "متن ";
            this.text.Name = "text";
            this.text.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "تاریخ ";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // hours
            // 
            this.hours.HeaderText = "ساعت ";
            this.hours.Name = "hours";
            this.hours.ReadOnly = true;
            this.hours.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // frmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 552);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.grvActivity);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmActivity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نمایش فعالیت های شما ";
            this.Load += new System.EventHandler(this.frmActivity_Load);
            this.grvActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grvActivity;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
    }
}