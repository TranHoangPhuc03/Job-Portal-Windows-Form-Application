using FindJobApplication.Daos;
using FindJobApplication.Utils;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FCompanyHome : Form
    {
        public FCompanyHome()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.account = null;

            FLogin fLogin = new FLogin();
            Form thisForm = (Form)this.TopLevelControl;
            thisForm.Hide();
            fLogin.ShowDialog();
            thisForm.Close();
        }
        private void FCompanyHome_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Session.account.Name;
            pbUserImage.Image = ImageUtils.FromBytesToImage(Session.account.Avatar);
            btnHome.PerformClick();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbUserImage_Click(object sender, EventArgs e)
        {
            this.ucCompanySubMenuRight.hideAndShowSubMenu(this.ucCompanySubMenuRight);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UCCompanyHome uCCompanyHome = new UCCompanyHome();
            pnlMain.Controls.Add(uCCompanyHome);
        }

        private void btnSocial_Click(object sender, EventArgs e)
        {
            UCSocial uCSocial = new UCSocial();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uCSocial);
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            UCMail uCMail = new UCMail();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uCMail);
        }

        private void pnlMain_ControlAdded(object sender, ControlEventArgs e)
        {
            var currentPanel = sender as System.Windows.Forms.Panel;
            int lastIndex = currentPanel.Controls.Count - 1;
            currentPanel.Controls[lastIndex].BringToFront();
        }
    }
}
