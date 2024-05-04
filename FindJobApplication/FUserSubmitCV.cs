using FindJobApplication.Daos;
using FindJobApplication.Utils;
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
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FUserSubmitCV : Form
    {
        private int jobId;
        public FUserSubmitCV()
        {
            InitializeComponent();
        }

        public FUserSubmitCV(JobPost jobPost) : this()
        {
            lblNameJob.Text = jobPost.Title;
            jobId = jobPost.Id;
        }

        private void btnSendCv_Click(object sender, EventArgs e)
        {
            JobApplyDao jobApplyDao = new JobApplyDao();
            string coverLetter = rtxtCoverLeter.Text;
            DateTime appliedAt = DateTime.Now;
            UserApplyJob userApplyJob = new UserApplyJob()
            {
                UserId = Session.account.Id,
                JobPostId = jobId,
                CoverLetter = coverLetter,
                AppliedAt = appliedAt,
                StatusId = (int)StatusName.Pending+1
            };
            int result = jobApplyDao.SaveUserApplyJob(userApplyJob);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
