using InstagramApiSharp;
using InstagramApiSharp.Classes.Models;
using instagramBot;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using FMessegeBox;

namespace bot
{
    public partial class frmProf : Form
    {
        public frmProf()
        {
            InitializeComponent();
        }

        private async void frmProf_Load(object sender, EventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();




            #region ChengeUi

            txtFullname.ReadOnly = true;
            txtUserName.ReadOnly = true;
            txtSite.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtNumber.ReadOnly = true;
            txtFollowing.ReadOnly = true;
            txtFollowerd.ReadOnly = true;
            txtPotos.ReadOnly = true;
            txtNumber.RightToLeft = RightToLeft.No;


            grpFollow.Visible = false;
            grpInfo.Visible = false;
            grpStory.Visible = false;
            grpDirect.Visible = false;
            pcImage.Visible = false;

            lodingLbl.Visible = true;



            lblStory.Visible = false;

            var full = userInfo.Value.FullName != "" ? userInfo.Value.FullName : userInfo.Value.Username;


            this.Text = $"خوش آمدید {full} ";


            #endregion



            for (int i = 0; i < 100; i++)
            {
                progressBar1.Percentage = i;

            }

            timeLoad.Enabled = true;


            backPross.DoWork += BackPross_DoWork;
            backPross.WorkerReportsProgress = true;
            backPross.RunWorkerAsync();



        }

        private async void BackPross_DoWork(object sender, DoWorkEventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();

            #region getFollowers/Following

            var following = await ApiManage.instaApi.UserProcessor.GetUserFollowingAsync(userInfo.Value.Username,
                PaginationParameters.MaxPagesToLoad(1));

            var followers = await ApiManage.instaApi.UserProcessor.GetUserFollowersAsync(userInfo.Value.Username,
                PaginationParameters.MaxPagesToLoad(1));


            var userPosts = await ApiManage.instaApi.UserProcessor.GetUserMediaAsync(username: userInfo.Value.Username,
                PaginationParameters.Empty);

            #endregion

            #region InfoRmation

            pcImage.Load(ApiManage.instaApi.GetLoggedUser().LoggedInUser.ProfilePicUrl);



            var userName = userInfo.Value.Username;
            var fullNmae = userInfo.Value.FullName;
            var email = userInfo.Value.Email;
            var site = userInfo.Value.ExternalUrl;
            var Number = userInfo.Value.PhoneNumber;


            #endregion

            #region SetAllText


            txtFullname.Invoke((MethodInvoker)delegate
            {
                txtFullname.Text = fullNmae;
            });
            txtUserName.Invoke((MethodInvoker)delegate
            {
                txtUserName.Text = userName;

            });

            txtEmail.Invoke((MethodInvoker)delegate
            {
                txtEmail.Text = email;

            });
            txtSite.Invoke((MethodInvoker)delegate
            {
                txtSite.Text = !string.IsNullOrEmpty(site) ? site : "سایت نداری ";

            });

            txtNumber.Invoke((MethodInvoker)delegate
            {
                txtNumber.Text = Number;

            });
            #endregion

            #region Invoker

            if (followers.Succeeded)
            {
                if (following.Succeeded)
                {
                    if (userPosts.Succeeded)
                    {
                        this.lodingLbl.Invoke((MethodInvoker)delegate
                        {
                            lodingLbl.Visible = false;

                        });
                        this.progressBar1.Invoke((MethodInvoker)delegate
                        {
                            progressBar1.Visible = false;
                        });

                        this.grpInfo.Invoke((MethodInvoker)delegate
                        {
                            grpInfo.Visible = true;
                        });
                        this.grpDirect.Invoke((MethodInvoker)delegate
                        {
                            grpDirect.Visible = true;
                        });
                        this.grpFollow.Invoke((MethodInvoker)delegate
                        {
                            grpFollow.Visible = true;
                        });

                        this.grpStory.Invoke((MethodInvoker)delegate
                        {
                            grpStory.Visible = true;
                        });

                        this.pcImage.Invoke((MethodInvoker)delegate
                        {
                            pcImage.Visible = true;
                        });

                        this.txtPotos.Invoke((MethodInvoker)delegate
                        {
                            txtPotos.Text = userPosts.Value.Count.ToString();
                        });
                        this.txtFollowing.Invoke((MethodInvoker)delegate
                        {
                            txtFollowing.Text = following.Value.Count.ToString();

                        });

                        txtFollowerd.Invoke((MethodInvoker)delegate
                        {
                            txtFollowerd.Text = followers.Value.Count.ToString();

                        });
                    }
                }
            }

            #endregion
        }

        private async void btnSendImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "تصویر را انتخاب کنید ";
            op.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            grpStory.Visible = false;
            lblStory.Visible = true;

            progressBar1.Visible = true;

            for (int i = 0; i < 100; i++)
            {
                progressBar1.percentage = i;

            }

            timeLoad.Enabled = true;

            if (op.ShowDialog() == DialogResult.OK)
            {
                var image = new InstaImage()
                {
                    Uri = op.FileName,
                };
                var res = await ApiManage.instaApi.StoryProcessor.UploadStoryPhotoAsync(image, txtCaption.Text);
                if (res.Succeeded)
                {
                    MessageBox.Show("عکس با موفقیت آپلود شد ");
                    grpStory.Visible = true;
                    lblStory.Visible = false;
                    progressBar1.Percentage = 100;
                    progressBar1.Visible = false;
                }
                else
                {
                    MessageBox.Show($"آپلود انجام نشد به دلیل \n {res.Info.Message}");
                    grpStory.Visible = true;
                    lblStory.Visible = false;
                    progressBar1.Percentage = 100;
                    progressBar1.Visible = false;

                }
            }
        }

        private async void btnVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog()
            {
                Title = "فالی فیلم را انتخاب کنید ",
                Filter =
                "All Videos Files |*.dat; *.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm",
            };



            grpStory.Visible = false;
            lblStory.Visible = true;

            progressBar1.Visible = true;

            for (int i = 0; i < 100; i++)
            {
                progressBar1.percentage = i;

            }

            timeLoad.Enabled = true;



            if (op.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog imageDialog = new OpenFileDialog()
                {
                    Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                    Title = "ارسال تصویر شاخص"
                };
                if (imageDialog.ShowDialog() == DialogResult.OK)
                {
                    string imageUri = imageDialog.FileName;
                    string videoUri = op.FileName;


                    var video = new InstaVideoUpload()
                    {
                        Video = new InstaVideo(videoUri, 0, 0),
                        VideoThumbnail = new InstaImage(imageUri, 0, 0)
                    };
                    var res = await ApiManage.instaApi.StoryProcessor.UploadStoryVideoAsync(video, txtCaption.Text);
                    if (res.Succeeded)
                    {
                        MessageBox.Show("فیلم  با موفقیت آپلود شد ");
                        grpStory.Visible = true;
                        lblStory.Visible = false;
                        progressBar1.Percentage = 100;
                        progressBar1.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show($"آپلود انجام نشد به دلیل \n {res.Info.Message}");

                        grpStory.Visible = true;
                        lblStory.Visible = false;
                        progressBar1.Percentage = 100;
                        progressBar1.Visible = false;
                    }
                }

            }

          

         

           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            (new frmEdit()).ShowDialog();
            (new frmLogin()).Show();
            this.Close();
        }

        private async void btnJson_Click(object sender, EventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();



            #region InfoRmation




            var userName = userInfo.Value.Username;
            var fullNmae = userInfo.Value.FullName;
            var email = userInfo.Value.Email;
            var site = userInfo.Value.ExternalUrl;
            var Number = userInfo.Value.PhoneNumber;
            var prof = userInfo.Value.ProfilePicUrl;

            #endregion



            #region getFollowers/Following/Photos

            var following = await ApiManage.instaApi.UserProcessor.GetUserFollowingAsync(userInfo.Value.Username,
                PaginationParameters.MaxPagesToLoad(1));

            var followers = await ApiManage.instaApi.UserProcessor.GetUserFollowersAsync(userInfo.Value.Username,
                PaginationParameters.MaxPagesToLoad(1));


            var userPosts = await ApiManage.instaApi.UserProcessor.GetUserMediaAsync(username: userInfo.Value.Username,
                PaginationParameters.Empty);

            #endregion



            SaveFileDialog save = new SaveFileDialog()
            {
                Filter = "|*.json",
                Title = "ذخیره فایل ",
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                var select = save.FileName;

                var path = @select;




                UserJsonConvert userJson = new UserJsonConvert()
                {
                    fullName = fullNmae,
                    userName = userName,
                    webPage = !string.IsNullOrEmpty(site) ? site : "No Web Active",
                    number = Number,
                    email = email,
                    imageProfile = prof,
                    images = userPosts.Value,
                    followers = followers.Value,
                    followings = following.Value,
                };



                string jsonUser = JsonConvert.SerializeObject(userJson);


                File.WriteAllText(path, jsonUser);


                MessageBox.Show($"فایل شما در مسیر {path} ذخیره شد ", "ذخیره ", MessageBoxButtons.OK,
                    MessageBoxIcon.Information,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign|MessageBoxOptions.RtlReading);

            }
            else
            {
                MessageBox.Show("فایل رو کجا بریزم کاکوی گولم ");
            }
        }

        private void btnShowfollowing_Click(object sender, EventArgs e)
        {
            (new showFollowing()).ShowDialog();

        }

        private void btnShowFollowers_Click(object sender, EventArgs e)
        {
            (new showFollowers()).ShowDialog();

        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            (new frmActivity()).ShowDialog();

        }

        private void btnSubmitPost_Click(object sender, EventArgs e)
        {
            (new frmPosts()).ShowDialog();


        }

        private void direct_Click(object sender, EventArgs e)
        {
            (new frmDirectList()).ShowDialog();

        }

        private async void btnPostes_Click(object sender, EventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();
            (new frmChengeUser()).ShowDialog();

        }

        private void timeLoad_Tick(object sender, EventArgs e)
        {

        }

        private async void frmProf_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private async void frmProf_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            var userInfo = await ApiManage.instaApi.AccountProcessor.GetRequestForEditProfileAsync();
            if (FMessegeBox.FarsiMessegeBox.Show($"{userInfo.Value.FullName} میخوای ولم کنی ","خروح",FMessegeBoxButtons.YesNo,FMessegeBoxIcons.Information,FMessegeBoxDefaultButton.button1) == DialogResult.Yes)
            {
                Application.Exit();                
            }
        }
    }
}
