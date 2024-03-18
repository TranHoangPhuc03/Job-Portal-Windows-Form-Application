using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class UCCompanyHome : UserControl
    {
        public UCCompanyHome()
        {
            InitializeComponent();
            btnAllJob.PerformClick();
        }

        public void btnAllJob_Click(object sender, EventArgs e)
        {
            pnlNumberOfApplicants.Controls.Clear();
            List<UCCompanyJob> list = new List<UCCompanyJob>();
            for (int i = 0; i <= 20; i++)
            {
                UCCompanyJob uCCompanyJob = new UCCompanyJob();
                uCCompanyJob.LblID.Text = i.ToString();
                uCCompanyJob.LblNameJob.Text ="Job " + i.ToString();
                uCCompanyJob.LblPostDate.Text = DateTime.Now.AddDays(-i).ToShortDateString();
                uCCompanyJob.LblExpirationDate.Text = DateTime.Now.AddDays(i).ToShortDateString();
                uCCompanyJob.LblSalary.Text = (i*100).ToString();
                list.Add(uCCompanyJob);
                pnlNumberOfApplicants.Controls.Add(list[i]);
            }
        }

        private void btnRecruitment_Click(object sender, EventArgs e)
        {
            FCompanyJobEdit fCompanyJobEdit = new FCompanyJobEdit();
            fCompanyJobEdit.Show();
        }
    }
}
