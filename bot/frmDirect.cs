using FMessegeBox;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using String = System.String;

namespace bot
{
    public partial class frmDirect : Form
    {
        public string user;
        public IResult<InstaUser> user1;
        public IResult<InstaUser> user2;
        public IResult<InstaUser> user3;
        public IResult<InstaUser> user4;
        public IResult<InstaUser> user5;

        public frmDirect()
        {
            InitializeComponent();
        }

        private void frmDirect_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user))
            {
                #region Visible

                txtUserName1.Visible = true;
                txtUserName2.Visible = true;
                txtUserName3.Visible = true;
                txtUserName4.Visible = true;    
                lblUserName1.Visible = true;
                lblUserName2.Visible = true;
                lblUserName3.Visible = true;
                lblUserName4.Visible = true;

                #endregion

                #region SetText

                txtUserName.Text = user1.Value.UserName;
                txtUserName1.Text = user2.Value.UserName;
                txtUserName2.Text = user3.Value.UserName;
                txtUserName3.Text = user4.Value.UserName;
                txtUserName4.Text = user5.Value.UserName;

                btnSend.Text = "ارسال چندگانه ";

                #endregion
            }
            else
            {
                txtUserName.Text = user.ToString();

                #region Visible

                txtUserName1.Visible = false;
                txtUserName2.Visible = false;
                txtUserName3.Visible = false;
                txtUserName4.Visible = false;
                lblUserName1.Visible = false;
                lblUserName2.Visible = false;
                lblUserName3.Visible = false;
                lblUserName4.Visible = false;

                #endregion

            }
        }

        

        private async void xuiButton1_Click(object sender, EventArgs e)
        {




            if (String.IsNullOrEmpty(this.user))
            {
                #region ListUsers

                var usersList = new List<string>();

                usersList.Add(user1.Value.Pk.ToString());
                usersList.Add(user2.Value.Pk.ToString());
                usersList.Add(user3.Value.Pk.ToString());
                usersList.Add(user4.Value.Pk.ToString());
                usersList.Add(user5.Value.Pk.ToString());

                #endregion


                var recipients = string.Join(",", usersList);


                var directText = await ApiManage.instaApi.MessagingProcessor
                    .SendDirectTextAsync(recipients, null, txtCaption.Text);

                if (directText.Succeeded)
                {
                    FMessegeBox.FarsiMessegeBox.Show($"آخی خستم کردی یه خسته نباشی بگو لاقل به اینا یه پیامی دادم \n" +
                                                       $" {user1.Value.UserName} || " +
                                                       $"{user2.Value.UserName} ||" +
                                                       $" {user3.Value.UserName} || " +
                                                       $"{user4.Value.UserName} || " +
                                                       $"{user5.Value.UserName} "
                          , "حوصله سر رفته ", FMessegeBoxButtons.Ok, FMessegeBoxIcons.Information);

                }
                else
                {
                    FMessegeBox.FarsiMessegeBox.Show("خستمه نمیتونم پیام بدم اونم 5 تا اوووووووو", "خسته هستم ",
                        FMessegeBoxButtons.Ok, FMessegeBoxIcons.Information);
                }
            }
            else
            {
                var user = await ApiManage.instaApi.UserProcessor.GetUserAsync(txtUserName.Text);





                var direct =
                    await ApiManage.instaApi.MessagingProcessor.SendDirectTextAsync(user.Value.Pk.ToString(), null, txtCaption.Text);
                if (direct.Succeeded)
                {


                    FMessegeBox.FarsiMessegeBox.Show($"منم ربات خوب بازیگوش پیام دادم به ایشون {user.Value.FullName} ",
                        "ارسال شد", FMessegeBoxButtons.Ok, FMessegeBoxIcons.Information);
                }
            }
        }
    }
}
