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
    public partial class FSignUp : Form
    {
        public FSignUp()
        {
            InitializeComponent();
            txtPassword.Multiline = false;
        }

        private void llblSignUpUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        private void lblShow_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "Show")
            {
                txtPassword.Multiline = true;
                lblShow.Text = "Hide";
            }
            else
            {
                txtPassword.Multiline = false;
                lblShow.Text = "Show";
            }
        }
        private void llblCreateBussiness_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FCompanySignUp fCompanySignUp = new FCompanySignUp();
            fCompanySignUp.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
