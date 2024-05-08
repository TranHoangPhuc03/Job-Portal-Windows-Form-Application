using FindJobApplication.Daos;
using FindJobApplication.Entities;
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
    public partial class UCCompanySeeProfilePeople : UserControl
    {
        public FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;
        private UserApplyJob user = new UserApplyJob();
        UserApplyJob userApplyJob = new UserApplyJob();

        public UCCompanySeeProfilePeople()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCCompanySeeProfilePeople(UserApplyJob user) : this()
        {
            this.user = user;
        }
        private void btnSeeCV_Click(object sender, EventArgs e)
        {
            if (this.user.CvAttachment == null || this.user.CvAttachment == "")
            {
                UCProfile uCProfile = new UCProfile(user.UserId);
                FillToMainPanelClicked?.Invoke(this, uCProfile);
                uCProfile.hideAllBtn();
            }
            else
            {
                FCompanySeeCV fCompanySeeCV = new FCompanySeeCV(this.user.CvAttachment);
                fCompanySeeCV.Show();
            }
        }

        private void UCCompanySeeProfilePeople_Load(object sender, EventArgs e)
        {
            lblNamePeople.Text = user.UserProfile.Account.Name;
            lblNameJob.Text = user.JobPost.Title;
            rtxtCoverLetter.Text = user.CoverLetter;
            if (user.StatusId == 2)
            {
                btnAccept.Visible = true;
                btnDeny.Visible = true;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            JobApplyDao jobApplyDao = new JobApplyDao();
            ICollection<UserApplyJob> userPending = new List<UserApplyJob>();
            userApplyJob = jobApplyDao.FindUserApplyById(user.JobPostId, user.UserId);
            userPending.Add(userApplyJob);
            int results = jobApplyDao.UpdateUserApplyStatus(userPending, StatusName.InterviewInvited);
            if (results == 1) 
            {
                MessageBox.Show("Accept success");
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            JobApplyDao jobApplyDao = new JobApplyDao();
            ICollection<UserApplyJob> userPending = new List<UserApplyJob>();
            UserApplyJob userApplyJob = new UserApplyJob();
            userApplyJob = jobApplyDao.FindUserApplyById(user.JobPostId, user.UserId);
            userPending.Add(userApplyJob);
            int results = jobApplyDao.UpdateUserApplyStatus(userPending, StatusName.Appropriate);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                Dispose();
            }
        }
    }
}
