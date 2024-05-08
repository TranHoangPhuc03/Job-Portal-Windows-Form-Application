using FindJobApplication.Daos;
using FindJobApplication.Entities;
using FindJobApplication.Utils;
using Guna.Charts.WinForms;
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
    public partial class FScheduleInvitePeople : Form
    {
        int jobPostId;
        JobApplyDao jobApplyDao = new JobApplyDao();
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;

        public FScheduleInvitePeople()
        {
            InitializeComponent();
        }

        public FScheduleInvitePeople(int jobPostId) : this()
        {
            this.jobPostId = jobPostId;
        }

        private void FScheduleInvitePeople_Load(object sender, EventArgs e)
        {
            var results = jobApplyDao.FilterUserApplyJobByStatus(jobPostId, StatusName.InterviewInvited);
            pnlListPeopleWaitInterview.SuspendLayout();
            for (int i = 0; i < results.Count; ++i)
            {
                UCScheduleEventPeopleWaitInvite uCScheduleEventPeopleWaitInvite = new UCScheduleEventPeopleWaitInvite(i+1, results.ElementAt(i));
                pnlListPeopleWaitInterview.Controls.Add(uCScheduleEventPeopleWaitInvite);
            }
            pnlListPeopleWaitInterview.ResumeLayout();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInvite_Click(object sender, EventArgs e)
        {
            MailDao mailDao = new MailDao();
            ICollection<UserApplyJob> selectedUsers = new List<UserApplyJob>();
            foreach(UCScheduleEventPeopleWaitInvite c in pnlListPeopleWaitInterview.Controls)
            {
                if (c.CbPeople.Checked)
                {
                    selectedUsers.Add(c.Tag as UserApplyJob);
                    UserApplyJob us = c.Tag as UserApplyJob;
                    Mail mail = new Mail()
                    {
                        FromId = Session.account.Id,
                        ToId = us.UserId,
                        Title = "Interview letter",
                        Contents = "Our company invites you to come in for an interview",
                        SendDate = DateTime.Now,
                        AttachFile = ""
                    };
                    int result = mailDao.SaveNewMail(mail);
                }
            }

            int results = jobApplyDao.UpdateUserApplyStatus(selectedUsers, StatusName.Interviewing);

            int id = Session.account.Id;
            Close();
        }
    }
}
