using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Logger;
using System;
using System.Windows.Forms;
using XanderUI;

namespace bot
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {


            var device = new AndroidDevice
            {
                // Device name
                AndroidBoardName = "HONOR",
                // Device brand
                DeviceBrand = "HUAWEI",
                // Hardware manufacturer
                HardwareManufacturer = "HUAWEI",
                // Device model
                DeviceModel = "PRA-LA1",
                // Device model identifier
                DeviceModelIdentifier = "PRA-LA1",
                // Firmware brand
                FirmwareBrand = "HWPRA-H",
                // Hardware model
                HardwareModel = "hi6250",
                // Device guid
                DeviceGuid = new Guid("be897499-c663-492e-a125-f4c8d3785ebf"),
                // Phone guid
                PhoneGuid = new Guid("7b72321f-dd9a-425e-b3ee-d4aaf476ec52"),
                // Device id based on Device guid
                DeviceId = ApiRequestMessage.GenerateDeviceIdFromGuid(new Guid("be897499-c663-492e-a125-f4c8d3785ebf")),
                // Resolution
                Resolution = "1080x1812",
                // Dpi
                Dpi = "480dpi",
            };


            lblLoad.Visible = true;
            txtUser_name.Visible = false;
            txt_pass.Visible = false;
            btnLogin.Visible = false;
            label1.Visible = false;
            label2.Visible = false;


            var user = new UserSessionData();
            user.UserName = txtUser_name.Text;
            user.Password = txt_pass.Text;
            ApiManage.instaApi = InstaApiBuilder.CreateBuilder().SetUser(user)
                .UseLogger(new DebugLogger(LogLevel.All))
                .SetDevice(device)
                .SetRequestDelay(RequestDelay.FromSeconds(0, 1)).Build();
            var loginRequst = await ApiManage.instaApi.LoginAsync();

            if (loginRequst.Succeeded)
            {
                this.Hide();
                (new frmProf()).ShowDialog();
                lblLoad.Visible = false;
                txtUser_name.Visible = true;
                txt_pass.Visible = true;
                btnLogin.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                MessageBox.Show("ورود ناموفق بود لطفا دوباره تلاش کنید \n" + loginRequst.Info.Message, "وارد نشدید ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblLoad.Visible = false;
                txtUser_name.Visible = true;
                txt_pass.Visible = true;
                btnLogin.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblLoad.Visible = false;
            lblCopy.Text = "طراح و برنامه نویس   موسوی";

            if (lblCopy.Text != "طراح و برنامه نویس   ☕☕آرش موسوی")
            {
                if (MessageBox.Show("هویی بچه مگر نمیفهمی میگم منو مهندس موسوی زدن \n تازه بری پیشش یه اژدها داره آتیش میزنه برو حتما ببینش \n شبا بهتره  \n بهش پیام بده ازش بخر \n 09015207562 ","هشتاری از ربات " ,
                    MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading|MessageBoxOptions.RightAlign) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void showPass_SwitchStateChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = showPass.SwitchState != XUISwitch.State.Off ? '\0' : '*';

        }
    }
}
