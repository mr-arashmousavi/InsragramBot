using InstagramApiSharp.Enums;
using System;
using System.Windows.Forms;

namespace bot
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void frmEdit_Load(object sender, EventArgs e)
        {
            var editProfile = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();

            txtBio.Text = editProfile.Value.Biography;
            txtEmail.Text = editProfile.Value.Email;
            txtMobile.Text = editProfile.Value.PhoneNumber;
            txtName.Text = editProfile.Value.FullName;
            txtSite.Text = editProfile.Value.ExternalUrl;
            txtUserName.Text = editProfile.Value.Username;
            this.Text = $"شما در حال ویرایش کاربر : {editProfile.Value.FullName}";

            if (editProfile.Value.Gender == InstaGenderType.Male)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;

            }
            pcImage.Load(ApiManage.instaApi.GetLoggedUser().LoggedInUser.ProfilePicUrl);
        }

        private async void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                byte[] picByts = System.IO.File.ReadAllBytes(op.FileName);
                var result = await ApiManage.instaApi.AccountProcessor.ChangeProfilePictureAsync(picByts);
                if (result.Succeeded)
                {
                    pcImage.ImageLocation = op.FileName;
                    MessageBox.Show("تصویر شما تغییر کرد");
                }
                else
                {
                    MessageBox.Show("با مشکلی مواجه شدید \n" + result.Info.Message);
                }
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {


            var editProfile = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();

            var name = txtName.Text;
            var fullname = editProfile.Value.FullName;

            var edit = await ApiManage.instaApi.AccountProcessor
                .EditProfileAsync(txtName.Text,txtBio.Text,
                    txtSite.Text,txtEmail.Text,txtMobile.Text,
                    (rbMale.Checked) ?InstaGenderType.Male : InstaGenderType.Female ,
                    txtUserName.Text);

            var pass = await ApiManage.instaApi.AccountProcessor.ChangePasswordAsync(txtOldPass.Text, txtPass.Text);

            if (edit.Succeeded)
            {
                MessageBox.Show("ویرایش انجام شد");
            }
            else
            {
                MessageBox.Show("خطا \n" + edit.Info.Message);

            }
        }

        private void rdbChengePass_Click(object sender, EventArgs e)
        {
            txtOldPass.Visible = true;
            txtPass.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

        }
    }
}
