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
            this.ActiveControl = this.txtName;
            this.lblShow.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void llblSignInUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FLogin fLogin = new FLogin();
            this.Hide();
            fLogin.ShowDialog();
            this.Close();
        }
        private void lblShow_Click(object sender, EventArgs e)
        {
            if (lblShow.Text == "Show")
            {
                this.txtPassword.PasswordChar = '\0';
                lblShow.Text = "Hide";
            }
            else
            {
                this.txtPassword.PasswordChar = '*';
                lblShow.Text = "Show";
            }
        }
        private void llblCreateBussiness_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FSignUpCompany fCompanySignUp = new FSignUpCompany();
            this.Hide();
            fCompanySignUp.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
