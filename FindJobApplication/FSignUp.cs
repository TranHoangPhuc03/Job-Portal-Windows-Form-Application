using FindJobApplication.Daos;
using FindJobApplication.Models;
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
                this.lblShow.Text = "Hide";
            }
            else
            {
                this.txtPassword.PasswordChar = '*';
                this.lblShow.Text = "Show";
            }
        }
        private void llblCreateBussiness_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FSignUpCompany fCompanySignUp = new FSignUpCompany();
            this.Hide();
            fCompanySignUp.ShowDialog();
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            string password = this.txtPassword.Text;
            string name = this.txtName.Text;
            AccountDao accountDao = new AccountDao();
            int results = accountDao.SaveNewAccount(email, name, password, AccountRole.User);

            if (results > 0)
            {
                MessageDialog.Show(this, "Sign up successful", "Success", MessageDialogStyle.Default);
            }
            else
            {
                MessageDialog.Show(this, "Sign up failed", "Error", MessageDialogStyle.Default);
            }
        }
    }
}
