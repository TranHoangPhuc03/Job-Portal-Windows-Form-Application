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
            this.Dock = DockStyle.Fill;
        }

        public Guna2Button BtnAllJob { get => btnAllJob; }

        public void UCCompanyHome_Load(object sender, EventArgs e)
        {
            JobPostDao jobPostDao = new JobPostDao();
            fillDataToPanel(jobPostDao.FindAllJobPostByCompanyId(Session.accountId));
            
        }
        public void fillDataToPanel(List<JobPost> jobPosts)
        {
            this.pnlJobPostedList.Controls.Clear();
            JobPostDao jobPostDao = new JobPostDao();
            int cnt = 1;
            foreach (JobPost jobPost in jobPosts)
            {
                int nApplicants = jobPostDao.CountUserAppliedForOneJob(jobPost.Id);
                UCCompanyJob uCCompanyJob = new UCCompanyJob(jobPost, cnt++, nApplicants);
                int currentRow = this.pnlJobPostedList.RowCount - 1;
                this.pnlJobPostedList.Controls.Add(uCCompanyJob, currentRow, 0);
                this.pnlJobPostedList.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                this.pnlJobPostedList.RowCount++;
            }
        }
        private void btnRecruitment_Click(object sender, EventArgs e)
        {
            FCompanyJobEdit fCompanyJobEdit = new FCompanyJobEdit();
            fCompanyJobEdit.Show();
        }

        private void btnStillRecruitment_Click(object sender, EventArgs e)  
        {
            JobPostDao jobPostDao = new JobPostDao();
            List<JobPost> jobPosts = jobPostDao.FindAllJobPostByCompanyId(Session.accountId);
            List<JobPost> filtered = jobPosts.Where(row => row.ExpireDate >= DateTime.Today).ToList();
            fillDataToPanel(filtered);
        }

        private void btnExpiration_Click(object sender, EventArgs e)
        {
            JobPostDao jobPostDao = new JobPostDao();
            List<JobPost> jobPosts = jobPostDao.FindAllJobPostByCompanyId(Session.accountId);
            List<JobPost> filtered = jobPosts.Where(row => row.ExpireDate < DateTime.Today).ToList();
            fillDataToPanel(filtered);
        }
    }
}
