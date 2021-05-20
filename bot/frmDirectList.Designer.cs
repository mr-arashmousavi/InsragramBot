
namespace instagramBot
{
    partial class frmDirectList
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
            this.lblLoad = new System.Windows.Forms.Label();
            this.dgvDirectList = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(91, 23);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(240, 14);
            this.lblLoad.TabIndex = 10;
            this.lblLoad.Text = "صبور باشید تا اطلاعات رو بگیرم چشم 😊😊😊";
            // 
            // dgvDirectList
            // 
            this.dgvDirectList.AllowUserToAddRows = false;
            this.dgvDirectList.AllowUserToDeleteRows = false;
            this.dgvDirectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDirectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.fullName});
            this.dgvDirectList.Location = new System.Drawing.Point(6, 21);
            this.dgvDirectList.Name = "dgvDirectList";
            this.dgvDirectList.ReadOnly = true;
            this.dgvDirectList.RowTemplate.Height = 25;
            this.dgvDirectList.Size = new System.Drawing.Size(373, 394);
            this.dgvDirectList.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.HeaderText = "نام کاربری";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            this.userName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "نام کامل";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDirectList);
            this.groupBox2.Location = new System.Drawing.Point(10, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 415);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(30, 503);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(338, 23);
            this.btnsend.TabIndex = 12;
            this.btnsend.Text = "ادامه دایرکت ";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // frmDirectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 538);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnsend);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDirectList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست دایرکت ها ";
            this.Load += new System.EventHandler(this.frmDirectList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.DataGridView dgvDirectList;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsend;
    }
}