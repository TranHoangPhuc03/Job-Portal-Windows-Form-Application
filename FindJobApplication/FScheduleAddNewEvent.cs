using FindJobApplication.Daos;
using FindJobApplication.Entities;
using FindJobApplication.Utils;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class FScheduleAddNewEvent : Form
    {
        string formAction;
        int idCompany;
        List<JobPost> jobs = new List<JobPost> ();
        JobPostDao jobPostDao = new JobPostDao();
        EventDao eventDao = new EventDao();
        DateTime currentDate;

        public FScheduleAddNewEvent()
        {
            InitializeComponent();
            this.formAction = "Create";
        }
        public FScheduleAddNewEvent(int idCompany, DateTime date)
        {
            InitializeComponent();
            this.idCompany = idCompany;
            this.currentDate = date;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FScheduleAddNewEvent_Load(object sender, EventArgs e)
        {
            ICollection<JobPost> jobPosts = jobPostDao.FindAllJobPostByCompanyId(idCompany);
            foreach (JobPost jobPost in jobPosts)
            {
                ccbNameJob.Items.Add(jobPost.Title);
                jobs.Add(jobPost);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InterviewEvent interviewEvent = new InterviewEvent();
            string selectedTimeFrom = cbbFromTime.Text;
            string selectedTimeTo = cbbToTime.Text;

            int idJob = 0;
            for (int i = 0; i < jobs.Count; i++)
            {
                if (i == ccbNameJob.SelectedIndex)
                {
                    idJob = jobs[i].Id;
                }

            }
            interviewEvent.CompanyId = idCompany;
            interviewEvent.JobPostId = idJob;
            interviewEvent.Title = txtNameEvent.Text;

            DateTime selectedDateTimeFrom = DateTime.ParseExact(selectedTimeFrom, "HH:mm", CultureInfo.InvariantCulture);
            interviewEvent.From = currentDate.Date + selectedDateTimeFrom.TimeOfDay;

            DateTime selectedDateTimeTo = DateTime.ParseExact(selectedTimeTo, "HH:mm", CultureInfo.InvariantCulture);
            interviewEvent.To = currentDate.Date + selectedDateTimeTo.TimeOfDay;

            interviewEvent.From = interviewEvent.From.AddMinutes(-interviewEvent.From.Minute).AddSeconds(-interviewEvent.From.Second);
            interviewEvent.To = interviewEvent.To.AddMinutes(-interviewEvent.To.Minute).AddSeconds(-interviewEvent.To.Second);

            int results = eventDao.SaveNewEvent(interviewEvent);
            if (results == 0)
            {
                MessageDialog.Show(this, "Failed to save the event", "Failed", MessageDialogStyle.Light);
            }
            else
            {
                MessageDialog.Show(this, "Event saved successfully", MessageDialogStyle.Light);
                this.Close();
            }
        }
    }
}
