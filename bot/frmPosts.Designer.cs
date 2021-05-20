
namespace instagramBot
{
    partial class frmPosts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLoad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtCapthion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLoad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnVideo);
            this.groupBox1.Controls.Add(this.btnImage);
            this.groupBox1.Controls.Add(this.txtTag);
            this.groupBox1.Controls.Add(this.txtCapthion);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعیین پست ";
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(336, 67);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(67, 14);
            this.lblLoad.TabIndex = 6;
            this.lblLoad.Text = "صبور باشید ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "توضیحات ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "تگ :";
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(336, 116);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(75, 23);
            this.btnVideo.TabIndex = 3;
            this.btnVideo.Text = "فیلم ";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(439, 116);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(75, 23);
            this.btnImage.TabIndex = 2;
            this.btnImage.Text = "تصویر";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(336, 38);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(100, 22);
            this.txtTag.TabIndex = 1;
            // 
            // txtCapthion
            // 
            this.txtCapthion.Location = new System.Drawing.Point(40, 38);
            this.txtCapthion.Multiline = true;
            this.txtCapthion.Name = "txtCapthion";
            this.txtCapthion.Size = new System.Drawing.Size(260, 102);
            this.txtCapthion.TabIndex = 0;
            // 
            // frmPosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 183);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPosts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ارسال پست ";
            this.Load += new System.EventHandler(this.frmPosts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtCapthion;
        private System.Windows.Forms.Label lblLoad;
    }
}