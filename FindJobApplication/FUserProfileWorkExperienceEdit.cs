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
    public partial class FUserProfileWorkExperienceEdit : Form
    {

        UserProfileDao userProfileDao = new UserProfileDao();
        UserProfile userProfile = null;
        public FUserProfileWorkExperienceEdit()
        {
            InitializeComponent();
        }

        public FUserProfileWorkExperienceEdit(Account account) : this()
        {
            userProfile = userProfileDao.FindUserProfileByAccountId(account.Id);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FUserProfileWorkExperienceEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userProfile.UserWorkExperiences.Add(new UserWorkExperience()
            {
                JobTitle = txtJobTitle.Text,
                CompanyName = txtCompany.Text,
                From = dtpFrom.Value,
                To = dtpTo.Value,
            });
            int result = userProfileDao.UpdateUserProfile(userProfile);
            if (result == 0)
            {
                MessageDialog.Show(this, "Update failed");
            }
            else
            {
                MessageDialog.Show(this, "Update successfully");
                Close();
            }
        }
    }
}
