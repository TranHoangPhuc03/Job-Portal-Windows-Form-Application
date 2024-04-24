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
using FindJobApplication.Models;
using Guna.UI2.WinForms;

namespace FindJobApplication
{
    public partial class FHome : Form
    {
        UCUserSubMenuRight uCUserSubMenuRight = new UCUserSubMenuRight();
        static FHome _obj;
        public FHome()
        {
            InitializeComponent();
        }
        public static FHome Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FHome();
                }
                return _obj;
            } 
        }
        public Guna2CustomGradientPanel PnlMain { get => pnlMain; set => pnlMain = value; }


        private void btnHome_Click(object sender, EventArgs e)
        {
            UCHome uCHome = new UCHome();
            pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uCHome);
            foreach (var row in uCHome.PnlListJob.Controls)
            {
                if (row is UCJob uCJob)
                {
                    uCJob.NameJobClicked += UCJob_SeeDetailClicked;
                    uCJob.NameCompanyClicked += UCCompany_SeeDetailClicked;
                }
            }
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            _obj = this;
            btnHome.PerformClick();
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            UCSocial uCSocial = new UCSocial();
            this.pnlMain.Controls.Add(uCSocial);
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            UCMail uCMail = new UCMail();
            
            this.pnlMain.Controls.Add(uCMail);

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
            this.pnlMain.Controls.Add(uCTopTrending);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UCProfile uCProfile = new UCProfile();
            this.pnlMain.Controls.Add(uCProfile);
        }

        private void btnFavourites_Click(object sender, EventArgs e)
        {
            UCUserListCompanyFollowing uCUserListCompanyFollowing = new UCUserListCompanyFollowing();
            
            this.pnlMain.Controls.Add(uCUserListCompanyFollowing);
        }

        private void btnMyJob_Click(object sender, EventArgs e)
        {
            UCMyJob uCMyJob = new UCMyJob();
            this.pnlMain.Controls.Add(uCMyJob);
        }

        private void btnHistorySocial_Click(object sender, EventArgs e)
        {
            UCSocialHistory uCSocialHistory = new UCSocialHistory();
            this.pnlMain.Controls.Add(uCSocialHistory);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            UCSetting uCSetting = new UCSetting();
            this.pnlMain.Controls.Add(uCSetting);
        }

        private void UCMailRow_SeeDetailClicked(object sender, EventArgs e, UCMailDetail uCMailDetail)
        {
            this.pnlMain.Controls.Add(uCMailDetail);
        }

        private void UCJob_SeeDetailClicked(object sender, EventArgs e, UCJobInformation uCJobInformation)
        {
            this.pnlMain.Controls.Add(uCJobInformation);
        }

        private void UCCompany_SeeDetailClicked(object sender, EventArgs e, UCCompanyProfile uCCompanyProfile)
        {
            this.pnlMain.Controls.Add(uCCompanyProfile);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.accountId = 0;
            Session.role = "";

            FLogin fLogin = new FLogin();
            Form thisForm = (Form)this.TopLevelControl;
            thisForm.Hide();
            fLogin.ShowDialog();
            thisForm.Close();
        }

        private void pbUserImage_Click(object sender, EventArgs e)
        {
            this.uCUserSubMenuRight.hideAndShowSubMenu(this.ucUserSubMenu);
        }

        private void pnlMain_ControlAdded(object sender, ControlEventArgs e)
        {
            var currentPanel = sender as System.Windows.Forms.Panel;
            int lastIndex = currentPanel.Controls.Count - 1;
            currentPanel.Controls[lastIndex].BringToFront();
        }
    }
}
