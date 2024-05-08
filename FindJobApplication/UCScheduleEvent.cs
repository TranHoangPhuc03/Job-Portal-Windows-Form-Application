using FindJobApplication.Daos;
using FindJobApplication.Entities;
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
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;

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
            FillToMainPanelClicked?.Invoke(this, new UCSchedule());

        }

        private void UCScheduleEvent_Load(object sender, EventArgs e)
        {
            EventDao eventDao = new EventDao();
            ICollection<InterviewEvent> interviewEvents = eventDao.FindEventInDateById(Session.account.Id, currentDate);
            pnlListEvent.Controls.Clear();
            int index = 1;
            foreach (var interviewEvent in interviewEvents)
            {
                UCScheduleEventRows uCScheduleEventRows = new UCScheduleEventRows(index++, interviewEvent);
                pnlListEvent.Controls.Add(uCScheduleEventRows);
            }
        }


        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            FScheduleAddNewEvent fScheduleAddNewEvent = new FScheduleAddNewEvent(Session.account.Id, currentDate);
            fScheduleAddNewEvent.ShowDialog();
            UCScheduleEvent_Load(sender, e);
        }
    }
}
