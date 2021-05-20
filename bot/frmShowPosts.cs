using InstagramApiSharp;
using System;
using System.Linq;
using System.Windows.Forms;

namespace bot
{
    public partial class frmShowPosts : Form
    {

        public string UserName;

        public frmShowPosts()
        {
            InitializeComponent();
        }

        private async void frmShowPosts_Load(object sender, EventArgs e)
        {
            this.Text = UserName;
            var userMedias = await ApiManage.instaApi.UserProcessor
                .GetUserMediaAsync(username: UserName, PaginationParameters.MaxPagesToLoad(1));




            string html = "";
            if (userMedias.Succeeded)
            {
                foreach (var item in userMedias.Value)
                {
                    html += $"<hr/>";

                    if (item.Images.Any())
                    {
                        html += $"<div style='width:100%;direction:rtl'>" +
                                $"<img src='{item.Images?[0].Uri}' style='width:100%'/>" +
                                $"<p><span>لایک ها  : {item.LikesCount}   || </span>" +
                                $"<span>نظرات : {item.CommentsCount}  || </span>" +
                                $"<br/>" +
                                $"<span>پست شده در تاریخ : {item.TakenAt.Year} / {item.TakenAt.Month} / {item.TakenAt.Year} " +
                                $" ساعت : " +
                                $"{item.TakenAt.Minute} : " +
                                $"{item.TakenAt.Hour}" +
                                $"<br/>";

                        dgvPosts.Rows.Add("1", item.LikesCount.ToString(), item.CommentsCount.ToString(),item.Images[0].Uri);

                    }
                    else if (item.Carousel.Any())
                    {
                        for (int i = 0; i < item.Carousel.Count; i++)
                        {
                            html +=
                                $"<div style='display: inline'>" +
                                $"<div class=gallery style='border: 1px solid #ccc;margin: 5px;width: 50%;display: inline;direction:rtl;text-align:center'>" +
                                $"<img src='{item.Carousel[0].Images[0].Uri}' style='width: 100%;height: auto;' width='600' height='400'/>" +
                                $"<div class='desc' style='padding: 15px;text-align: center;'>تعداد لایک ها  {item.LikesCount}</div>" +
                                $"</div>" +
                                $"</div>";

                            dgvPosts.Rows.Add(item.Carousel.Count.ToString(), item.LikesCount.ToString(), item.CommentsCount.ToString(),item.Carousel[i].Images[0].Uri);


                        }
                        dgvPosts.Rows.Add("تصویر بعدی", " تصویر بعدی", " تصویر بعدی", "تصویر بعدی");

                    }
                }
                webBrowser1.DocumentText = html;
            }
        }

        private void dgvPosts_SelectionChanged(object sender, EventArgs e)
        {
            var html = "";

            var img = dgvPosts.CurrentRow.Cells[3].Value.ToString();

            html += $"<div style='width:100%;direction:rtl'>" +
                    $"<img src='{img}' style='width:100%'/>" +
                    $"</div>"+
                    $"<br/>";

            webBrowser1.DocumentText = html;
        }
    }
}
