using bot;
using InstagramApiSharp.Classes.Models;
using System;
using System.Windows.Forms;

namespace instagramBot
{
    public partial class frmPosts : Form
    {
        public frmPosts()
        {
            InitializeComponent();
        }

        private async void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog()
            {
                Title = "تصویر را انتخاب کنید",
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };
            if (op.ShowDialog() == DialogResult.OK)
            {
                label1.Visible = false;
                label2.Visible = false;
                txtCapthion.Visible = false;
                txtTag.Visible = false;
                btnImage.Visible = false;
                btnVideo.Visible = false;

                lblLoad.Visible = true;




                var media = new InstaImageUpload()
                {
                    Uri = op.FileName,
                };
                media.UserTags.Add(new InstaUserTagUpload()
                {
                    Username = txtTag.Text,

                });
                var res = await ApiManage.instaApi.MediaProcessor.UploadPhotoAsync(media, txtCapthion.Text);
                if (res.Succeeded)
                {
                    lblLoad.Visible = false;

                    label1.Visible = true;
                    label2.Visible = true;
                    txtCapthion.Visible = true;
                    txtTag.Visible = true;
                    btnImage.Visible = true;
                    btnVideo.Visible = true;

                    if (MessageBox.Show("پست شما ارسال شد کار دیگری در این صفحه دارید ", "سوال", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        txtCapthion.Clear();
                        txtTag.Clear();
                    }

                }
                else
                {
                    MessageBox.Show($"پست ارسال نشد {res.Info.Message}");

                }
            }



        }

        private void frmPosts_Load(object sender, EventArgs e)
        {
            lblLoad.Visible = false;

        }




        private async void btnVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog()
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                Title = "ارسال تصویر شاخص"
            };
            if (op.ShowDialog() == DialogResult.OK)
            {

                OpenFileDialog videDialog = new OpenFileDialog()
                {
                    Title = "ویدیو را انتخاب کنید دوست من ",
                    Filter =
                        "All Videos Files |*.dat; *.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                        " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm",

                };
                if (videDialog.ShowDialog() == DialogResult.OK)
                {
                    var video = new InstaVideoUpload()
                    {
                        Video = new InstaVideo(videDialog.FileName, 0, 0),
                        VideoThumbnail = new InstaImage(op.FileName, 0, 0)
                    };
                    video.UserTags.Add(new InstaUserTagUpload()
                    {
                        Username = txtTag.Text
                    });



                    label1.Visible = false;
                    label2.Visible = false;
                    txtCapthion.Visible = false;
                    txtTag.Visible = false;
                    btnImage.Visible = false;
                    btnVideo.Visible = false;

                    lblLoad.Visible = true;

                    var res = await ApiManage.instaApi.MediaProcessor.UploadVideoAsync(video, txtCapthion.Text);

                    if (res.Succeeded)
                    {
                        lblLoad.Visible = false;

                        label1.Visible = true;
                        label2.Visible = true;
                        txtCapthion.Visible = true;
                        txtTag.Visible = true;
                        btnImage.Visible = true;
                        btnVideo.Visible = true;

                        if (MessageBox.Show("پست شما ارسال شد کار دیگری در این صفحه دارید ", "سوال",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information) == DialogResult.No)
                        {
                            this.Close();
                        }
                        else
                        {
                            txtCapthion.Clear();
                            txtTag.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show($"پست ارسال نشد \n {res.Info.Message}");

                    }
                }
                else
                {
                    MessageBox.Show("فیلمت کو پس ");
                }
            }
            else
            {
                MessageBox.Show("تصویر میخوام  کو پس ");

            }





        }
    }
}
