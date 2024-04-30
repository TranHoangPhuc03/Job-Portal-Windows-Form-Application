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

namespace FindJobApplication
{
    public partial class UCCompanySeeProfilePeople : UserControl
    {
        private int jobPostId;
        private int userId;

        public UCCompanySeeProfilePeople()
        {
            InitializeComponent();
        }

        public UCCompanySeeProfilePeople(Dictionary<string, int> obj) : this()
        {
            obj.TryGetValue("jobPostId", out this.jobPostId);
            obj.TryGetValue("userId", out this.userId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSeeCV_Click(object sender, EventArgs e)
        {
            UCProfile uCProfile = new UCProfile(this.userId);
            UCMain.Instance.PnlMid.Controls.Add(uCProfile);
            uCProfile.hideAllBtn();
            uCProfile.BringToFront();
            //FCompanySeeCV fCompanySeeCV = new FCompanySeeCV(this.userId);
            //fCompanySeeCV.Show();
        }

        private void UCCompanySeeProfilePeople_Load(object sender, EventArgs e)
        {
            //JobApplyDao jobApplyDao = new JobApplyDao();
            //DataRow dr = jobApplyDao.FindUserApplyJob(this.userId, this.jobPostId).Rows[0];
            //this.lblNamePeople.Text = dr["name"].ToString();
            //this.lblNameJob.Text = dr["title"].ToString();
            //this.rtxtCoverLetter.Text = dr["cover_letter"].ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            FCompanyScheduleAnInterview fCompanyScheduleAnInterview = new FCompanyScheduleAnInterview();    
            fCompanyScheduleAnInterview.Show();
        }
    }
}
