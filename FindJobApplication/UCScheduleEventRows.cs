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
    public delegate void SeePeopleInterviewClickedEventHandler(object sender, EventArgs e, UCScheduleEventDetail uCScheduleEventDetail);

    public partial class UCScheduleEventRows : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;

        public UCScheduleEventRows()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCScheduleEventRows(int rowId) : this()
        {
            lblID.Text = rowId.ToString();
        }

        public UCScheduleEventRows(int rowId, InterviewEvent interviewEvent) : this(rowId)
        {
            lblNameJob.Text = interviewEvent.JobPost.Title;
            lblDate.Text = interviewEvent.From.ToString("dd-MM-yyyy");
            lblFrom.Text = interviewEvent.From.ToString("HH:mm");
            lblTo.Text = interviewEvent.To.ToString("HH:mm");
            Tag = interviewEvent.JobPostId;
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            FScheduleAddNewEvent fScheduleAddNewEvent = new FScheduleAddNewEvent();
            fScheduleAddNewEvent.Show();
        }

        private void pbSeePeopleInterview_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCScheduleEventDetail((int)Tag));
        }
    }
}
