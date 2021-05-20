using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp.Classes.Models;

namespace bot
{
    public partial class frmChengeUser : Form
    {
        public frmChengeUser()
        {
            InitializeComponent();
        }

        private async void frmChengeUser_Load(object sender, EventArgs e)
        {
            grpUser.Visible = false;

        }

        private static async Task<InstaUserEdit> userInfo()
        {
            var userInformation = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();

            return userInformation.Value;

        }

        private async void btnMyPosts_Click(object sender, EventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();
            frmShowPosts posts = new frmShowPosts()
            {
                UserName = userInfo.Value.Username
            };
            posts.ShowDialog();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            grpUser.Visible = true;

        }

        private void btnFollowers_Click(object sender, EventArgs e)
        {
            (new showFollowers()).ShowDialog();

        }

        private void btnFollowing_Click(object sender, EventArgs e)
        {
            (new showFollowing()).ShowDialog();

        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {
            frmShowPosts posts = new frmShowPosts()
            {
                UserName = txtUser.Text
            };
            posts.ShowDialog();
        }
    }
}
