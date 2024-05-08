using FindJobApplication.Entities;
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
    public partial class UCCompanyCVFollowing : UserControl
    {
        public FillToMainPanelHandler FillToPanelMainClicked = UCPanelMain.UC_RequiredAddControl;
        public UCCompanyCVFollowing()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCCompanyCVFollowing(int rowId) : this()
        {
            lblID.Text = rowId.ToString();
        }

        public UCCompanyCVFollowing(int rowId, UserProfile user) : this(rowId)
        {
            llblName.Text = user.Account.Name;
            Tag = user.Id;
        }

        private void llblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCProfile uCProfile = new UCProfile((int)Tag);
            FillToPanelMainClicked?.Invoke(this, uCProfile);
            uCProfile.hideAllBtn();
        }
    }
}
