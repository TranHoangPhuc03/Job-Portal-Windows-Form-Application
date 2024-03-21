using FindJobApplication.Daos;
using FindJobApplication.Models;
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
            JobPostDao jobPostDao = new JobPostDao();
            DataTable dt = jobPostDao.findByCompanyId(Global.loginId);
            List<UCCompanyJob> listUCCompanyJob = new List<UCCompanyJob>();
            foreach (DataRow row in dt.Rows)
            {
                UCCompanyJob uCCompanyJob = new UCCompanyJob();
                //uCCompanyJob.LblID.Text = row["id"].ToString();
                uCCompanyJob.LblNameJob.Text = row["title"].ToString();
                uCCompanyJob.LblPostDate.Text = row["post_date"].ToString();
                uCCompanyJob.LblExpirationDate.Text = row["expire_date"].ToString();
                uCCompanyJob.LblSalary.Text = row["salary"].ToString();
                listUCCompanyJob.Add(uCCompanyJob);
            }
            this.fillDataToPanel(listUCCompanyJob);
        }
        public void fillDataToPanel<T>(List<T> dataControlList)
        {
            pnlNumberOfApplicants.Controls.Clear();
            foreach (Object obj in dataControlList)
            {
                this.pnlNumberOfApplicants.Controls.Add((Control)obj);
            }
        }
        private void btnRecruitment_Click(object sender, EventArgs e)
        {
            FCompanyJobEdit fCompanyJobEdit = new FCompanyJobEdit();
            fCompanyJobEdit.Show();
        }
    }
}
