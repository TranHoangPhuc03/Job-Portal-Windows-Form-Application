using FindJobApplication.Daos;
using FindJobApplication.Models;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
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
        }

        public Guna2Button BtnAllJob { get { return btnAllJob; } }

        public void btnAllJob_Click(object sender, EventArgs e)
        {
            pnlNumberOfApplicants.Controls.Clear();
            JobPostDao jobPostDao = new JobPostDao();
            DataTable dt = jobPostDao.findByCompanyId(Global.loginId);
            List<UCCompanyJob> listUCCompanyJob = new List<UCCompanyJob>();
            int cnt = 1;
            foreach (DataRow row in dt.Rows)
            {
                
                UCCompanyJob uCCompanyJob = new UCCompanyJob();
                uCCompanyJob.LblID.Text = (cnt++).ToString();
                uCCompanyJob.LblNameJob.Text = row["title"].ToString();
                uCCompanyJob.LblPostDate.Text = row["post_date"].ToString();
                uCCompanyJob.LblExpirationDate.Text = row["expire_date"].ToString();
                uCCompanyJob.LblSalary.Text = row["salary"].ToString();
                uCCompanyJob.LblCountApplied.Text = ((jobPostDao.countUserApply((int)row["id"])).Rows[0]["number_user_apply"]).ToString();
                uCCompanyJob.Tag = row["id"];
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

        private void btnStillRecruitment_Click(object sender, EventArgs e)
        {
            pnlNumberOfApplicants.Controls.Clear();
            JobPostDao jobPostDao = new JobPostDao();
            DataTable dt = jobPostDao.findByCompanyId(Global.loginId);
            var results = dt.AsEnumerable()
                            .Where(row => row.Field<DateTime>("expire_date") >= DateTime.Now);
            List<UCCompanyJob> listUCCompanyJob = new List<UCCompanyJob>();
            int cnt = 1;
            foreach (DataRow row in results)
            {

                UCCompanyJob uCCompanyJob = new UCCompanyJob();
                uCCompanyJob.LblID.Text = (cnt++).ToString();
                uCCompanyJob.LblNameJob.Text = row["title"].ToString();
                uCCompanyJob.LblPostDate.Text = row["post_date"].ToString();
                uCCompanyJob.LblExpirationDate.Text = row["expire_date"].ToString();
                uCCompanyJob.LblSalary.Text = row["salary"].ToString();
                uCCompanyJob.LblCountApplied.Text = ((jobPostDao.countUserApply((int)row["id"])).Rows[0]["number_user_apply"]).ToString();
                uCCompanyJob.Tag = row["id"];
                listUCCompanyJob.Add(uCCompanyJob);
            }
            this.fillDataToPanel(listUCCompanyJob);
        }

        private void btnExpiration_Click(object sender, EventArgs e)
        {
            pnlNumberOfApplicants.Controls.Clear();
            JobPostDao jobPostDao = new JobPostDao();
            DataTable dt = jobPostDao.findByCompanyId(Global.loginId);
            var results = dt.AsEnumerable()
                            .Where(row => row.Field<DateTime>("expire_date") < DateTime.Now);
            List<UCCompanyJob> listUCCompanyJob = new List<UCCompanyJob>();
            int cnt = 1;
            foreach (DataRow row in results)
            {

                UCCompanyJob uCCompanyJob = new UCCompanyJob();
                uCCompanyJob.LblID.Text = (cnt++).ToString();
                uCCompanyJob.LblNameJob.Text = row["title"].ToString();
                uCCompanyJob.LblPostDate.Text = row["post_date"].ToString();
                uCCompanyJob.LblExpirationDate.Text = row["expire_date"].ToString();
                uCCompanyJob.LblSalary.Text = row["salary"].ToString();
                uCCompanyJob.LblCountApplied.Text = ((jobPostDao.countUserApply((int)row["id"])).Rows[0]["number_user_apply"]).ToString();
                uCCompanyJob.Tag = row["id"];
                listUCCompanyJob.Add(uCCompanyJob);
            }
            this.fillDataToPanel(listUCCompanyJob);
        }
    }
}
