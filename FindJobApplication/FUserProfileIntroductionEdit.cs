using FindJobApplication.Daos;
using FindJobApplication.Entities;
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
    public partial class FUserProfileIntroductionEdit : Form
    {
        UserProfileDao userProfileDao = new UserProfileDao();
        UserProfile userProfile = null;
        public FUserProfileIntroductionEdit()
        {
            InitializeComponent();
        }

        public FUserProfileIntroductionEdit(Account account) : this()
        {
            userProfile = userProfileDao.FindUserProfileByAccountId(account.Id);
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FUserProfileIntroductionEdit_Load(object sender, EventArgs e)
        {
            rtxtIntroduction.Text = userProfile.AboutMe;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userProfile.AboutMe = rtxtIntroduction.Text;
            int result = userProfileDao.UpdateUserProfile(userProfile);
            if (result == 0)
            {
                MessageDialog.Show(this, "Update failed");
            }
            else
            {
                MessageDialog.Show(this, "Update successfully");
                UCUserSubMenuRight uCUserSubMenuRight = new UCUserSubMenuRight();
                uCUserSubMenuRight.btnProfile_Click(sender, e);
                Close();
            }
        }
    }
}
