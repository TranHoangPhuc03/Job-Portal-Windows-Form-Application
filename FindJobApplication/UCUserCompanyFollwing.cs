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
    public partial class UCUserCompanyFollwing : UserControl
    {
        public UCUserCompanyFollwing()
        {
            InitializeComponent();
        }
        public GunaLabel LblId { get => lblID; set => lblID = value; }
        public GunaLinkLabel LlblNameCompany { get => llblNameCompany; set => llblNameCompany = value; }

        private void llblNameCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCCompanyProfile uCCompanyProfile = new UCCompanyProfile();
            UCMain.Instance.PnlMid.Controls.Add(uCCompanyProfile);
            uCCompanyProfile.hideAllButton();
            uCCompanyProfile.Location = new Point(UCMain.Instance.PnlMid.Width / 2 - uCCompanyProfile.Width / 2, 0);
            uCCompanyProfile.BringToFront();
        }
    }
}
