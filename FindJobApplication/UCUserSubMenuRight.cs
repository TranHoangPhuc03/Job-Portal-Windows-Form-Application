using FindJobApplication.Utils;
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
    public delegate void FillToMainPanelHandler (object sender, UserControl uc);
    
    public partial class UCUserSubMenuRight : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked;
        public UCUserSubMenuRight()
        {
            InitializeComponent();
        }

        public void HideAndShowSubMenu(object sender)
        {
            (sender as UserControl).AutoSize ^= true;
        }

        public void btnProfile_Click(object sender, EventArgs e)
        {
            FillToMainPanelClicked?.Invoke(this, new UCProfile(Session.account.Id));
        }

        private void btnMyJob_Click(object sender, EventArgs e)
        {
            UCMyJob uCMyJob = new UCMyJob();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCMyJob);
           // UCMain.Instance.updateStatus(btnMyJob);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            UCSetting uCSetting = new UCSetting();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCSetting);
           // UCMain.Instance.updateStatus(btnSetting);
        }

        private void btnFavouriteCompany_Click(object sender, EventArgs e)
        {
            UCUserListCompanyFollowing uCUserListCompanyFollowing = new UCUserListCompanyFollowing();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCUserListCompanyFollowing);
           // UCMain.Instance.updateStatus(btnFavouriteCompany);
        }

        private void btnSocialPost_Click(object sender, EventArgs e)
        {
            UCSocialHistory uCSocialHistory = new UCSocialHistory();
            UCMain.Instance.PnlMid.Controls.Clear();
            UCMain.Instance.PnlMid.Controls.Add(uCSocialHistory);
           // UCMain.Instance.updateStatus(btnSocialPost);
        }
    }

}
