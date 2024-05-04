using FindJobApplication.Utils;
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
    public partial class UCScheduleEvent : UserControl
    {
        private DateTime currentDate;
        public UCScheduleEvent()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCScheduleEvent(DateTime date) : this()
        {
            currentDate = date;
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

        private void UCScheduleEvent_Load(object sender, EventArgs e)
        {
            pnlListEvent.Controls.Clear();
            var results = Session.account.CompanyProfile.InterviewEvents
                        .Where(row => row.From.Date == currentDate.Date)
                        .ToList();

            pnlListEvent.SuspendLayout();
            for (int i = 0; i < results.Count; i++)
            {
                UCScheduleEventRows uCScheduleEventRows = new UCScheduleEventRows(i+1, results.ElementAt(i));
                pnlListEvent.Controls.Add(uCScheduleEventRows);
            }
            pnlListEvent.ResumeLayout();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            FScheduleAddNewEvent fScheduleAddNewEvent = new FScheduleAddNewEvent(Session.account.Id, currentDate);
            fScheduleAddNewEvent.ShowDialog();
            UCScheduleEvent_Load(sender, e);
        }
    }
}
