using FindJobApplication.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class UCScheduleEventDetailRow : UserControl
    {
        public UCScheduleEventDetailRow()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCScheduleEventDetailRow(int rowId) : this()
        {
            lblID.Text = rowId.ToString();
        }

        public UCScheduleEventDetailRow(int rowId, UserApplyJob userApplyJob) : this(rowId)
        {
            lblName.Text = userApplyJob.UserProfile.Account.Name;
        }
    }
}
