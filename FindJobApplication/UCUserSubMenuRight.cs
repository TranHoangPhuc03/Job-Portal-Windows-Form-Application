using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class UCUserSubMenuRight : UserControl
    {
        public UCUserSubMenuRight()
        {
            InitializeComponent();
        }
        public void hideMenu()
        {
            this.Visible = false;
        }
        public void hideAndShowSubMenu(object sender)
        {
            (sender as UserControl).AutoSize ^= true;
        }

        public void btnProfile_Click(object sender, EventArgs e)
        {
            UCProfile uCProfile = new UCProfile();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCProfile);
            hideMenu();
           // UCMain.Instance.updateStatus(btnProfile);
        }

        private void btnMyJob_Click(object sender, EventArgs e)
        {
            UCMyJob uCMyJob = new UCMyJob();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCMyJob);
            hideMenu();
           // UCMain.Instance.updateStatus(btnMyJob);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            UCSetting uCSetting = new UCSetting();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCSetting);
            hideMenu();
           // UCMain.Instance.updateStatus(btnSetting);
        }

        private void btnFavouriteCompany_Click(object sender, EventArgs e)
        {
            UCUserListCompanyFollowing uCUserListCompanyFollowing = new UCUserListCompanyFollowing();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCUserListCompanyFollowing);
            hideMenu();
           // UCMain.Instance.updateStatus(btnFavouriteCompany);
        }

        private void btnSocialPost_Click(object sender, EventArgs e)
        {
            UCSocialHistory uCSocialHistory = new UCSocialHistory();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCSocialHistory);
            hideMenu();
           // UCMain.Instance.updateStatus(btnSocialPost);
        }
    }

}
