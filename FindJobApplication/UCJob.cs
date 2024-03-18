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
    public partial class UCJob : UserControl
    {
        public int count = 0;
        public UCJob()
        {
            InitializeComponent();
            pbSave.BringToFront();
        }
        public GunaLinkLabel LinkLabelJob { get => lLblNameJob; set { lLblNameJob = value; } }
        public GunaLinkLabel JobName { get => lLblNameJob; set { lLblNameJob = value; } }
        public GunaLinkLabel CompanyName { get => lblNameCompany; set { lblNameCompany = value; } }
        public Label Location { get => lblLocation; set { lblLocation = value; } }
        public Label Salary { get => lblSalary; set { lblSalary = value; } }
        public PictureBox PbSave { get => pbSave; }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (count%2 == 0)
            {
                count++;
                pbSave.Image = Properties.Resources.heart2;

            }
            else
            {
                count++;
                pbSave.Image = Properties.Resources.like;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FUserSubmitCV fUserSubmitCV = new FUserSubmitCV();
            fUserSubmitCV.Show();
        }

        private void lLblNameJob_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCJobInformation uCJobInformation = new UCJobInformation();
            UCMain.Instance.PnlMid.Controls.Add(uCJobInformation);
            uCJobInformation.Location = new Point(UCMain.Instance.PnlMid.Width / 2 - uCJobInformation.Width / 2, 0);
            uCJobInformation.BringToFront();
        }

        private void lblNameCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCCompanyProfile uCCompanyProfile = new UCCompanyProfile();
            UCMain.Instance.PnlMid.Controls.Add(uCCompanyProfile);
            uCCompanyProfile.hideAllButton();
            uCCompanyProfile.Location = new Point(UCMain.Instance.PnlMid.Width / 2 - uCCompanyProfile.Width / 2, 0);
            uCCompanyProfile.BringToFront();
        }
    }
}
