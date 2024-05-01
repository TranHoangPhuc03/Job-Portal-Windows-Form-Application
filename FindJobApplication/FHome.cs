using FindJobApplication.Daos;
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
using FindJobApplication.Utils;
using Guna.UI2.WinForms;
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FHome : Form
    {
        UCUserSubMenuRight uCUserSubMenuRight = new UCUserSubMenuRight();

        public FHome()
        {
            InitializeComponent();
            ucUserSubMenu.FillToMainPanelClicked += UCPanelMain.UC_RequiredAddControl;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UCHome uCHome = new UCHome();
            ucPanelMain.AddControl(uCHome);
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Session.account.Name;
            pbUserImage.Image = ImageUtils.FromBytesToImage(Session.account.Avatar);
            btnHome.PerformClick();
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            UCSocial uCSocial = new UCSocial();
            ucPanelMain.AddControl(uCSocial);
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            UCMail uCMail = new UCMail();
            ucPanelMain.AddControl(uCMail);

            foreach (var row in uCMail.PnlListMail.Controls)
            {
                if (row is UCMailRow uCMailRow)
                {
                    uCMailRow.SeeDetailClicked += UCMailRow_SeeDetailClicked;
                }
            }

        }

        private void btnTrending_Click(object sender, EventArgs e)
        {
            UCTopTrending uCTopTrending = new UCTopTrending();
            ucPanelMain.AddControl(uCTopTrending);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UCProfile uCProfile = new UCProfile();
            ucPanelMain.AddControl(uCProfile);
        }

        private void btnFavourites_Click(object sender, EventArgs e)
        {
            UCUserListCompanyFollowing uCUserListCompanyFollowing = new UCUserListCompanyFollowing();
            
            ucPanelMain.AddControl(uCUserListCompanyFollowing);
        }

        private void btnMyJob_Click(object sender, EventArgs e)
        {
            UCMyJob uCMyJob = new UCMyJob();
            ucPanelMain.AddControl(uCMyJob);
        }

        private void btnHistorySocial_Click(object sender, EventArgs e)
        {
            UCSocialHistory uCSocialHistory = new UCSocialHistory();
            ucPanelMain.AddControl(uCSocialHistory);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            UCSetting uCSetting = new UCSetting();
            ucPanelMain.AddControl(uCSetting);
        }

        private void UCMailRow_SeeDetailClicked(object sender, EventArgs e, UCMailDetail uCMailDetail)
        {
            ucPanelMain.AddControl(uCMailDetail);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.account = null;

            FLogin fLogin = new FLogin();
            Form thisForm = (Form)this.TopLevelControl;
            thisForm.Hide();
            fLogin.ShowDialog();
            thisForm.Close();
        }

        private void pbUserImage_Click(object sender, EventArgs e)
        {
            this.uCUserSubMenuRight.HideAndShowSubMenu(this.ucUserSubMenu);
        }
    }
}
