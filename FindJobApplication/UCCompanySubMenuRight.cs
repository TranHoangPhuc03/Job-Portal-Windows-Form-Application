using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindJobApplication.Entities;
using FindJobApplication.Utils;

namespace FindJobApplication
{
    public partial class UCCompanySubMenuRight : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;

        public UCCompanySubMenuRight()
        {
            InitializeComponent();
            InitHandleClickAllSubMenu();
        }

        private void InitHandleClickAllSubMenu()
        {
            foreach (Control c in pnlMenu.Controls)
            {
                c.Click += (sender, e) => HideAndShowSubMenu(this);
            }
        }

        public void HideAndShowSubMenu(object sender)
        {
            (sender as UserControl).AutoSize ^= true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCCompanyProfile(Session.account.Id));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCSetting());
        }

        private void btnFollowCV_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCCompanyListCVFollowing());
        }

        public void btnSocialPost_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCSocialHistory());
        }
    }
}
