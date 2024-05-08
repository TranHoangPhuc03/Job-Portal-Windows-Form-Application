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
    public partial class UCScheduleEventDetail : UserControl
    {
        int jobPostId;
        JobApplyDao jobApplyDao = new JobApplyDao();
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;

        public UCScheduleEventDetail()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCScheduleEventDetail(int jobPostId) : this()
        {
            this.jobPostId = jobPostId;
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = this.Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                Dispose();
            }

        }

        private void UCScheduleEventDetail_Load(object sender, EventArgs e)
        {
            var results = jobApplyDao.FilterUserApplyJobByStatus(jobPostId, StatusName.Interviewing);
            pnlListPeopleInterview.SuspendLayout();
            for (int i = 0; i < results.Count; ++i) 
            {
                UCScheduleEventDetailRow row = new UCScheduleEventDetailRow(i+1, results.ElementAt(i));
                pnlListPeopleInterview.Controls.Add(row);
            }
            pnlListPeopleInterview.ResumeLayout();
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            FScheduleInvitePeople fScheduleInvitePeople = new FScheduleInvitePeople(jobPostId);
            fScheduleInvitePeople.Show();
        }
    }
}
