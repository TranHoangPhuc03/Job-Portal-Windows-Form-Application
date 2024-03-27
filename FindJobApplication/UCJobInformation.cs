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
            this.Hide();
        }

        private void UCJobInformation_Load(object sender, EventArgs e)
        {
            JobPostDao jobPostDao = new JobPostDao();
            DataRow dr = jobPostDao.findByJobId(this.jobPostId).Rows[0];
            this.lblNameJob.Text = dr["title"].ToString();
            this.lblNameCompany.Text = dr["company_name"].ToString();
            this.lblSalary.Text = dr["salary"].ToString();
            this.rtxtJobDescription.Text =dr["description"].ToString();
            this.rtxtRequired.Text =dr["requirement"].ToString();
            this.rtxtPrioritize.Text = dr["prioritize"].ToString();
            this.rtxtBenefit.Text = dr["benefit"].ToString();
            this.lblPostDate.Text = ((DateTime)dr["post_date"]).ToString("dd-MM-yyyy");
            this.lblWorkAddress.Text = dr["address"].ToString();
        }
    }
}
