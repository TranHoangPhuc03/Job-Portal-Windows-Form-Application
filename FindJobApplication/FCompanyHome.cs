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
    public partial class FCompanyHome : Form
    {
        UCCompanyHome uCCompanyHome = new UCCompanyHome();
        UCCompanySubMenuRight uCCompanySubMenuRight = new UCCompanySubMenuRight();
        UCMain uCMain = new UCMain();
        public FCompanyHome()
        {
            InitializeComponent();
            this.Controls.Add(uCMain);
            uCMain.BtnHome.Click += btnHome_Click;
            uCMain.BtnUser.Click += btnUser_Click;
            uCMain.BtnLogOut.Click += btnLogOut_Click;
            uCMain.BtnHome.PerformClick();
            customForCompany();
        }
        private void customForCompany()
        {
            uCMain.BtnUser.Text = "AXON";
            uCMain.PbHomeUser.Image = Properties.Resources.Company;
            uCMain.PnlMid.Controls.Add(uCCompanySubMenuRight);
            uCCompanySubMenuRight.Location = new Point(uCMain.PnlMid.Width - uCCompanySubMenuRight.Width, 0);
            Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uCCompanySubMenuRight.hideMenu();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            uCMain.updateStatus(uCMain.BtnHome);
            uCMain.PnlMid.Controls.Clear();
            uCMain.PnlMid.Controls.Add(uCCompanyHome);
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            uCCompanySubMenuRight.hideAndShowSubMenu();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FCompanyHome_Load(object sender, EventArgs e)
        {

        }
    }
}
