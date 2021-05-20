using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bot;
using InstagramApiSharp;

namespace instagramBot
{
    public partial class frmDirectList : Form
    {
        public frmDirectList()
        {
            InitializeComponent();
        }

        private async void frmDirectList_Load(object sender, EventArgs e)
        {


            lblLoad.Visible = true;

            dgvDirectList.Visible = false;

            btnsend.Visible = false;

            var rankedRecipients = await ApiManage.instaApi.MessagingProcessor.GetRankedRecipientsAsync();



            if (rankedRecipients.Succeeded)
            {
                dgvDirectList.Visible = true;
                lblLoad.Visible = false;
                btnsend.Visible = true;

            }

            for (int i = 0; i < rankedRecipients.Value.Threads.Count; i++)
            {
                dgvDirectList.Rows.Add(rankedRecipients.Value.Threads[i].Users[0].UserName.ToString(), rankedRecipients.Value.Threads[i].Users[0].FullName.ToString());
            }

        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            frmDirect direct = new frmDirect()
            {
                user = dgvDirectList.CurrentRow.Cells[0].Value.ToString(),

            };
            direct.ShowDialog();
        }
    }
}
