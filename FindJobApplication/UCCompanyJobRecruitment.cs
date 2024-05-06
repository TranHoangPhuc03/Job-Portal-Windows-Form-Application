using FindJobApplication.Daos;
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
using FindJobApplication.Utils;

namespace FindJobApplication
{
    public partial class UCCompanyJobRecruitment : UserControl
    {
        int companyId;
        int cnt = 0;
        public UCCompanyJobRecruitment()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        public UCCompanyJobRecruitment(int companyId) :  this() 
        {
            this.companyId = companyId;
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

        public void fillDataToPanel(ICollection<JobPost> jobPosts)
        {
            pnlListJob.Controls.Clear();
            HashSet<int> favourites = null;
            UserProfileDao userProfileDao = new UserProfileDao();
            if (Session.account.Role == "user")
            {
                favourites = new HashSet<int>(
                    userProfileDao
                        .FindUserProfileByAccountId(Session.account.Id)
                        .JobPosts
                        .Select(row => row.Id)
                        .ToList()
                );
            }

            foreach (JobPost jobPost in jobPosts)
            {
                bool isFavourite = favourites != null && favourites.Contains(jobPost.Id);
                UCJob uCJob = new UCJob(jobPost, isFavourite);
                pnlListJob.Controls.Add(uCJob);
                cnt++;
            }
            lblCountJob.Text = cnt.ToString();
        }


        private void UCCompanyJobRecruitment_Load(object sender, EventArgs e)
        {
            JobPostDao jobPostDao = new JobPostDao();
            fillDataToPanel(jobPostDao.FindAllJobPostByCompanyId(companyId));
        }
    }
}
