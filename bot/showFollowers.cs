using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp;

namespace bot
{
    public partial class showFollowers : Form
    {
        public showFollowers()
        {
            InitializeComponent();
        }

        private async void showFollowers_Load(object sender, EventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();


            lblLoad.Visible = true;
            dgvFollowers.Visible = false;
            btnSend.Visible = false;
            btnShowPosts.Visible = false;





            await followrs(userInfo);
        }
        private async Task followrs(IResult<InstaUserEdit> userInfo)
        {
            var followers = await ApiManage.instaApi.UserProcessor.GetUserFollowersAsync(userInfo.Value.Username,
                PaginationParameters.MaxPagesToLoad(1));


            if (followers.Value.Count == 0)
            {
                MessageBox.Show("هیچی دیگه خداروشکر کسی که فالوت نداره \n منو میخوای چکار ها  ",
                    "این یک هشتار است از کبرای 11",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }
            else
            {
                lblLoad.Visible = false;
                dgvFollowers.Visible = true;
                btnSend.Visible = true;
                btnShowPosts.Visible = true;

                dgvFollowers.Rows.Clear();
                dgvFollowers.Refresh();

                foreach (var follow in followers.Value)
                {
                    dgvFollowers.Rows.Add(follow.UserName, follow.FullName, follow.IsPrivate ? "خصوصی " : "عمومی");
                }
            }
        }




        private async void btnsend_Click(object sender, EventArgs e)
        {


            if (dgvFollowers.SelectedRows.Count > 2)
            {

                var userName1 =
                    await ApiManage.instaApi.UserProcessor.GetUserAsync(dgvFollowers.SelectedRows[0].Cells[0].Value
                        .ToString());
              
                var userName2 =
                    await ApiManage.instaApi.UserProcessor.GetUserAsync(dgvFollowers.SelectedRows[1].Cells[0].Value
                        .ToString());
               
                var userName3 =
                    await ApiManage.instaApi.UserProcessor.GetUserAsync(dgvFollowers.SelectedRows[2].Cells[0].Value
                        .ToString());
               
                var userName4 =
                    await ApiManage.instaApi.UserProcessor.GetUserAsync(dgvFollowers.SelectedRows[3].Cells[0].Value
                        .ToString());
               
                var userName5 =
                    await ApiManage.instaApi.UserProcessor.GetUserAsync(dgvFollowers.SelectedRows[4].Cells[0].Value
                        .ToString());
               
                frmDirect direct = new frmDirect()
                {
                    user1 = userName1,
                    user2 = userName2,
                    user3 = userName3,
                    user4 = userName4,
                    user5 = userName5,

                };
                direct.ShowDialog();
            }
            else
            {
                frmDirect direct = new frmDirect()
                {
                    user = dgvFollowers.CurrentRow.Cells[0].Value.ToString(),

                };
                direct.ShowDialog();
            }
        }

        private void btnShowPosts_Click(object sender, EventArgs e)
        {
            frmShowPosts posts = new frmShowPosts()
            {
                UserName = dgvFollowers.CurrentRow.Cells[0].Value.ToString()
            };
            posts.ShowDialog();
        }
    }
}
