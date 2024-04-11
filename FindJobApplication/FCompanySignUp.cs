using FindJobApplication.Daos;
using FindJobApplication.DB;
using FindJobApplication.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class FCompanySignUp : Form
    {
        public FCompanySignUp()
        {
            InitializeComponent();
            txtPassword.Multiline = false;
        }

        private void llblSignUpUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void pNotHide_Click(object sender, EventArgs e)
        {
            txtPassword.Multiline = false;
            pHide.BringToFront();
        }
        private void pHide_Click_1(object sender, EventArgs e)
        {
            txtPassword.Multiline = true;
            pNotHide.BringToFront();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            this.ofdBusinessLicense.Filter = "Image files (*.jpeg; *.jpg) | *.jpeg; *.jpg";
            if (this.ofdBusinessLicense.ShowDialog() == DialogResult.OK)
            {
                this.lblStatus.Text = this.ofdBusinessLicense.SafeFileName;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            string password = this.txtPassword.Text;

            AccountDao accountDao = new AccountDao();
            int results = accountDao.SaveAccount(email, password, 1);

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
