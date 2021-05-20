using InstagramApiSharp;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using bot;

namespace instagramBot
{
    public partial class frmActivity : Form
    {
        public frmActivity()
        {
            InitializeComponent();
        }

        private void frmActivity_Load(object sender, EventArgs e)
        {
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
            backgroundWorker1.RunWorkerAsync();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = progressBar1.Maximum;
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

        }

        private async void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var resentActivity =
                 ApiManage.instaApi.UserProcessor.GetRecentActivityFeedAsync(PaginationParameters.MaxPagesToLoad(1));



            progressBar1.Invoke((MethodInvoker)delegate
           {
               progressBar1.Maximum = resentActivity.Result.Value.Items.Count;
           });

            for (int i = 0; i < resentActivity.Result.Value.Items.Count; i++)
            {



                dgvActivity.Invoke((MethodInvoker)delegate
               {
                   dgvActivity.Rows.Add(!string.IsNullOrEmpty(resentActivity.Result.Value.Items[i].Text) ? resentActivity.Result.Value.Items[i].Text :
                           "ایستات الکی لاک میزنه والا ",
                       $"{resentActivity.Result.Value.Items[i].TimeStamp.Year} / " + 
                       $"{resentActivity.Result.Value.Items[i].TimeStamp.Month} / " +
                       $"{resentActivity.Result.Value.Items[i].TimeStamp.Day}",

                       $"{resentActivity.Result.Value.Items[i].TimeStamp.Second} : " +
                       $"{resentActivity.Result.Value.Items[i].TimeStamp.Minute} : " +
                       $"{resentActivity.Result.Value.Items[i].TimeStamp.Hour}");
               });
                backgroundWorker1.ReportProgress(i + 1);
            }


        }
    }
}
