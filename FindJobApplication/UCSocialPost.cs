using Guna.UI2.WinForms;
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
    public partial class UCSocialPost : UserControl
    {
        public UCSocialPost()
        {
            InitializeComponent();
        }

        public Guna2Button BtnSendMail { get => btnSendMail; set => btnSendMail = value; }

        public FlowLayoutPanel PnlSkill { get => pnlSkill; set => pnlSkill = value; }
        public RichTextBox RtxtDescription { get => rtxtDescription; set => rtxtDescription = value; }

        public LinkLabel LlblName { get => llblName; }
        private void llblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCProfile uCProfile = new UCProfile();
            UCMain.Instance.PnlMid.Controls.Add(uCProfile);
            uCProfile.hideAllBtn();
            uCProfile.BringToFront();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            FSendMail fSendMail = new FSendMail();
            fSendMail.Show();
        }
    }
}
