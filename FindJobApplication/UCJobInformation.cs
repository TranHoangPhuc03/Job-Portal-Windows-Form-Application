using FindJobApplication.Daos;
using FindJobApplication.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class UCJobInformation : UserControl
    {
        private int jobPostId;
        public UCJobInformation()
        {
            InitializeComponent();
            pnlMain.AutoScroll = true;
        }

        public UCJobInformation(int jobPostId) : this()
        {
            this.jobPostId = jobPostId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = this.Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                this.Dispose();
            }
        }

        private void UCJobInformation_Load(object sender, EventArgs e)
        {
            JobPostDao jobPostDao = new JobPostDao();
            JobPost jobPost = jobPostDao.FindJobPostById(this.jobPostId);
            this.lblNameJob.Text = jobPost.Title;
            this.lblNameCompany.Text = jobPost.CompanyName;
            this.lblSalary.Text = jobPost.Salary.ToString();
            this.rtxtJobDescription.Text = jobPost.Description;
            this.rtxtRequired.Text = jobPost.Requirement;
            this.rtxtPrioritize.Text = jobPost.Prioritize;
            this.rtxtBenefit.Text = jobPost.Benefit;
            this.lblPostDate.Text = jobPost.PostDate.ToString("dd-MM-yyyy");
            this.lblWorkAddress.Text = jobPost.Address;
        }
    }
}
