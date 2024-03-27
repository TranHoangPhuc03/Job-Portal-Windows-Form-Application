using Guna.UI.WinForms;
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
    public partial class UCCompanyPeopleApplied : UserControl
    {
        public UCCompanyPeopleApplied()
        {
            InitializeComponent();
        }
        public GunaLabel LblId { get => lblId; set => lblId = value; }
        public GunaLabel LblNamePeople { get => lblNamePeople; set => lblNamePeople = value; }
        public GunaLabel LblDayApply { get => lblDayApply; set => lblDayApply = value; }

        public GunaLabel LblStatus { get => lblStatus; set => lblStatus = value; }

        private void pbSeeDetail_Click(object sender, EventArgs e)
        {
            UCCompanySeeProfilePeople uCCompanySeeProfilePeople = new UCCompanySeeProfilePeople((Dictionary<string, int>)this.Tag);
            UCMain.Instance.PnlMid.Controls.Add(uCCompanySeeProfilePeople);
            uCCompanySeeProfilePeople.Location = new Point(UCMain.Instance.PnlMid.Width / 2 - uCCompanySeeProfilePeople.Width / 2, 0);
            uCCompanySeeProfilePeople.BringToFront();
        }
    }
}
