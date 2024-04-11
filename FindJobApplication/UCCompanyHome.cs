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
            List<JobPost> jobPosts = jobPostDao.FindAllJobPostByCompanyId(Global.loginId);
            List<UCCompanyJob> listUCCompanyJob = new List<UCCompanyJob>();
            int cnt = 1;
            foreach (JobPost jobPost in jobPosts)
            {
                
                UCCompanyJob uCCompanyJob = new UCCompanyJob();
                uCCompanyJob.LblID.Text = (cnt++).ToString();
                uCCompanyJob.LblNameJob.Text = jobPost.Title;
                uCCompanyJob.LblPostDate.Text = jobPost.PostDate.ToString("dd-MM-yyyy");
                uCCompanyJob.LblExpirationDate.Text = jobPost.ExpireDate.ToString("dd-MM-yyyy");
                uCCompanyJob.LblSalary.Text = jobPost.Salary.ToString();
                uCCompanyJob.LblCountApplied.Text = (jobPostDao.CountUserAppliedForOneJob(jobPost.Id)).ToString();
                uCCompanyJob.Tag = jobPost.Id;
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
            List<JobPost> jobPosts = jobPostDao.FindAllJobPostByCompanyId(Global.loginId);
            var results = jobPosts.Where(jobPost => jobPost.ExpireDate >= DateTime.Now);

            List<UCCompanyJob> listUCCompanyJob = new List<UCCompanyJob>();
            int cnt = 1;
            foreach (JobPost jobPost in results)
            {
                UCCompanyJob uCCompanyJob = new UCCompanyJob();
                uCCompanyJob.LblID.Text = (cnt++).ToString();
                uCCompanyJob.LblNameJob.Text = jobPost.Title;
                uCCompanyJob.LblPostDate.Text = jobPost.PostDate.ToString("dd-MM-yyyy");
                uCCompanyJob.LblExpirationDate.Text = jobPost.ExpireDate.ToString("dd-MM-yyyy");
                uCCompanyJob.LblSalary.Text = jobPost.Salary.ToString();
                uCCompanyJob.LblCountApplied.Text = (jobPostDao.CountUserAppliedForOneJob(jobPost.Id)).ToString();
                uCCompanyJob.Tag = jobPost.Id;
                listUCCompanyJob.Add(uCCompanyJob);
            }
            this.fillDataToPanel(listUCCompanyJob);
        }

        private void btnExpiration_Click(object sender, EventArgs e)
        {
            pnlNumberOfApplicants.Controls.Clear();
            JobPostDao jobPostDao = new JobPostDao();
            List<JobPost> jobPosts = jobPostDao.FindAllJobPostByCompanyId(Global.loginId);
            var results = jobPosts.Where(jobPost => jobPost.ExpireDate < DateTime.Now);

            List<UCCompanyJob> listUCCompanyJob = new List<UCCompanyJob>();
            int cnt = 1;
            foreach (JobPost jobPost in results)
            {
                UCCompanyJob uCCompanyJob = new UCCompanyJob();
                uCCompanyJob.LblID.Text = (cnt++).ToString();
                uCCompanyJob.LblNameJob.Text = jobPost.Title;
                uCCompanyJob.LblPostDate.Text = jobPost.PostDate.ToString("dd-MM-yyyy");
                uCCompanyJob.LblExpirationDate.Text = jobPost.ExpireDate.ToString("dd-MM-yyyy");
                uCCompanyJob.LblSalary.Text = jobPost.Salary.ToString();
                uCCompanyJob.LblCountApplied.Text = (jobPostDao.CountUserAppliedForOneJob(jobPost.Id)).ToString();
                uCCompanyJob.Tag = jobPost.Id;
                listUCCompanyJob.Add(uCCompanyJob);
            }
            this.fillDataToPanel(listUCCompanyJob);
        }
    }
}
