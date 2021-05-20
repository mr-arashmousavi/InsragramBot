using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bot
{
    public partial class showFollowing : Form
    {
        public showFollowing()
        {
            InitializeComponent();
        }

        private async void showFollowing_Load(object sender, EventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();


            lblLoad.Visible = true;
            dgvFolloing.Visible = false;
            dgvBlock.Visible = false;
            grpIn.Visible = false;

            followingorblock(userInfo);

            await blockUsers(userInfo);
        }



        private async void followingorblock(IResult<InstaUserEdit> userInfo)
        {
            var followings = await ApiManage.instaApi.UserProcessor.GetUserFollowingAsync(userInfo.Value.Username,
                PaginationParameters.MaxPagesToLoad(1));



            if (followings.Value.Count == 0)
            {
                MessageBox.Show("هی هی هیجی هم که فالو نداری بیشین تا بیان فالوت کنن \n سادی لو  ",
                    "این یک هشتار است از کبرای 11",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                lblLoad.Visible = false;
                dgvFolloing.Visible = true;
                grpIn.Visible = true;

                dgvFolloing.Rows.Clear();
                dgvFolloing.Refresh();
            }
            else
            {
                lblLoad.Visible = false;
                dgvFolloing.Visible = true;
                grpIn.Visible = true;

                dgvFolloing.Rows.Clear();
                dgvFolloing.Refresh();

                foreach (var following in followings.Value)
                {
                    dgvFolloing.Rows.Add(following.UserName, following.FullName);
                }
            }

        }





        private async Task blockUsers(IResult<InstaUserEdit> userInfo)
        {
            var blockAll = await ApiManage.instaApi.UserProcessor.GetBlockedUsersAsync(PaginationParameters.Empty);


            if (blockAll.Succeeded)
            {
                lblLoad.Visible = false;
                dgvBlock.Visible = true;

                dgvBlock.Rows.Clear();
                dgvBlock.Refresh();

                foreach (var blocks in blockAll.Value.BlockedList)
                {
                    dgvBlock.Rows.Add(blocks.UserName);
                }
            }
        }

        private async void btnFollow_Click(object sender, EventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();

            var user = await ApiManage.instaApi.UserProcessor.GetUserAsync(txtUserName.Text);
            var follow = await ApiManage.instaApi.UserProcessor.FollowUserAsync(user.Value.Pk);
            if (follow.Succeeded)
            {
                lblLoad.Text = $"{user.Value.FullName}دیدی فالوت کردم یاد بگیر || عجب چیزی شدم من دیدیم دیم ";
                MessageBox.Show($"{user.Value.FullName}دیدی فالوت کردم یاد بگیر \n عجب چیزی شدم من دیدیم دیم ",
                    "من آمدم به دنیا ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                lblLoad.Visible = true;
                followingorblock(userInfo);
            }
        }

        private async void btnUnFollow_Click(object sender, EventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();

            var user = await ApiManage.instaApi.UserProcessor.GetUserAsync(txtUserName.Text);
            var follow = await ApiManage.instaApi.UserProcessor.UnFollowUserAsync(user.Value.Pk);
            if (follow.Succeeded)
            {
                lblLoad.Text = $"آخی ببم {user.Value.FullName} زدم آن فالوش کردم حالم جا اومد ";
                MessageBox.Show($"آخی ببم {user.Value.FullName} زدم آن فالوش کردم حالم جا اومد ", "من آمدم به دنیا ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                lblLoad.Visible = true;
                followingorblock(userInfo);
            }
        }

        private async void btnBlock_Click(object sender, EventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();

            var user = await ApiManage.instaApi.UserProcessor.GetUserAsync(txtUserName.Text);

            var block = await ApiManage.instaApi.UserProcessor.BlockUserAsync(user.Value.Pk);

            if (block.Succeeded)
            {
                lblLoad.Text = $"آخی ببم {user.Value.FullName} زدم بلکش کردم حالم جا اومد ";

                MessageBox.Show($"آخی ببم {user.Value.FullName} زدم بلکش کردم حالم جا اومد ", "من آمدم به دنیا ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                lblLoad.Visible = true;

                blockUsers(userInfo);
                followingorblock(userInfo);

            }
        }

        private async void btnUnBlock_Click(object sender, EventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();

            var user = await ApiManage.instaApi.UserProcessor.GetUserAsync(txtUserName.Text);

            var block = await ApiManage.instaApi.UserProcessor.UnBlockUserAsync(user.Value.Pk);

            if (block.Succeeded)
            {
                lblLoad.Text = $"شانست زد {user.Value.FullName} نمیدونم چرا از بلک درت اوردم ";

                MessageBox.Show($"شانست زد {user.Value.FullName} نمیدونم چرا از بلک درت اوردم ", "من آمدم به دنیا ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                lblLoad.Visible = true;

                blockUsers(userInfo);
                followingorblock(userInfo);


            }
        }


        private void dgvBlock_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = dgvBlock.CurrentRow.Cells[0].Value.ToString();

        }

        private void dgvFolloing_SelectionChanged(object sender, EventArgs e)
        {
            txtUserName.Text = dgvFolloing.CurrentRow.Cells[0].Value.ToString();

        }

        private void btnShowPosts_Click(object sender, EventArgs e)
        {
            frmShowPosts posts = new frmShowPosts()
            {
                UserName = txtUserName.Text
            };
            posts.ShowDialog();
        }
    }
}
