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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            txtPassword.Multiline = false;

        }
        private void llblSignUpUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FSignUp dishplaySignUp = new FSignUp();
            dishplaySignUp.ShowDialog();
            this.Show();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = this.txtUsername.Text;
            string password = this.txtPassword.Text;

            AccountDao accountDao = new AccountDao();
            DataRow account = accountDao.FindAccountByEmail(email);
            if (account == null || email != (string)account["email"] || password != (string)account["password"])
            {
                MessageDialog.Show(this, "Your email or password is incorrect", "Login failed", MessageDialogStyle.Default);
            }
            else
            {
                UserRoleDao userRoleDao = new UserRoleDao();
                string roleName = userRoleDao.FindUserRoleById((int)account["role_id"]);
                int accountId = (int)account["id"];
                int loginId = 0;
                Form redirectForm = null;
                switch (roleName)
                {
                    case "company":
                        CompanyProfileDao companyProfileDao = new CompanyProfileDao();
                        loginId = companyProfileDao.FindCompanyIdByAccountId(accountId);
                        redirectForm = new FCompanyHome();
                        break;

                    case "user":
                        UserProfileDao userProfileDao = new UserProfileDao();
                        loginId = userProfileDao.FindUserIdByAccountId(accountId);
                        redirectForm = new FHome();
                        break;
                    default:
                        break;
                }

                Global.accountId = accountId;
                Global.loginId = loginId;
                Global.role = roleName;
                
                this.Hide();
                redirectForm.ShowDialog();
                this.Close();
            }
        }

        private void llblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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

    }
}
