
namespace bot
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Clock = new XanderUI.XUIClock();
            this.lblLoad = new System.Windows.Forms.Label();
            this.showPass = new XanderUI.XUISwitch();
            this.lblCopy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "کلمه عبور : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "نام کاربری یا ایمیل : ";
            // 
            // txtUser_name
            // 
            this.txtUser_name.Location = new System.Drawing.Point(22, 10);
            this.txtUser_name.Name = "txtUser_name";
            this.txtUser_name.Size = new System.Drawing.Size(296, 21);
            this.txtUser_name.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(22, 71);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(296, 21);
            this.txt_pass.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(22, 113);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(296, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "ورود ";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Clock
            // 
            this.Clock.CircleThickness = 6;
            this.Clock.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.Clock.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.Clock.FilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.Clock.FilledSecondColor = System.Drawing.Color.DarkOrchid;
            this.Clock.Font = new System.Drawing.Font("Impact", 15F);
            this.Clock.HexagonColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.Clock.Location = new System.Drawing.Point(430, 6);
            this.Clock.Name = "Clock";
            this.Clock.ShowAmPm = false;
            this.Clock.ShowHexagon = true;
            this.Clock.ShowMinutesCircle = true;
            this.Clock.ShowSecondsCircle = true;
            this.Clock.Size = new System.Drawing.Size(120, 130);
            this.Clock.TabIndex = 5;
            this.Clock.Text = "xuiClock1";
            this.Clock.UnfilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(70)))), ((int)(((byte)(85)))));
            this.Clock.UnfilledMinuteColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.Clock.UnfilledSecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(172, 148);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(121, 13);
            this.lblLoad.TabIndex = 6;
            this.lblLoad.Text = "باش تا ببینم کی هستی ";
            // 
            // showPass
            // 
            this.showPass.BackColor = System.Drawing.Color.Transparent;
            this.showPass.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.showPass.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(180)))), ((int)(((byte)(120)))));
            this.showPass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.showPass.Location = new System.Drawing.Point(22, 71);
            this.showPass.Name = "showPass";
            this.showPass.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
            this.showPass.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.showPass.Size = new System.Drawing.Size(60, 30);
            this.showPass.SwitchState = XanderUI.XUISwitch.State.Off;
            this.showPass.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.showPass.TabIndex = 7;
            this.showPass.Text = "xuiSwitch1";
            this.showPass.SwitchStateChanged += new System.EventHandler(this.showPass_SwitchStateChanged);
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Location = new System.Drawing.Point(45, 148);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(0, 13);
            this.lblCopy.TabIndex = 8;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 185);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.lblLoad);
            this.Controls.Add(this.Clock);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txtUser_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ورود به ربات ";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btnLogin;
        private XanderUI.XUIClock Clock;
        private System.Windows.Forms.Label lblLoad;
        private XanderUI.XUISwitch showPass;
        private System.Windows.Forms.Label lblCopy;
    }
}

