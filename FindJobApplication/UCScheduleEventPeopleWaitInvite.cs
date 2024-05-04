using FindJobApplication.Entities;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
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
    public partial class UCScheduleEventPeopleWaitInvite : UserControl
    {
        public UCScheduleEventPeopleWaitInvite()
        {
            InitializeComponent();
        }

        public Guna2CheckBox CbPeople { get => cbPeople; } 

        public UCScheduleEventPeopleWaitInvite(int rowId) : this()
        {
            lblID.Text = rowId.ToString();
        }

        public UCScheduleEventPeopleWaitInvite(int rowId, UserApplyJob userApplyJob) : this(rowId)
        {
            lblName.Text = userApplyJob.UserProfile.Account.Name;
            Tag = userApplyJob;
        }
    }
}
