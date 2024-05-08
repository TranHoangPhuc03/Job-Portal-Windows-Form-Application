using FindJobApplication.Daos;
using FindJobApplication.Entities;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
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
    public partial class FUserProfilePersonalProjectEdit : Form
    {
        UserProfileDao userProfileDao = new UserProfileDao();
        UserProfile userProfile = null;
        UserPersonalProject userPersonalProject = null;

        public FUserProfilePersonalProjectEdit()
        {
            InitializeComponent();
        }

        public FUserProfilePersonalProjectEdit(Account account) : this()
        {
            userProfile = userProfileDao.FindUserProfileByAccountId(account.Id);
        }

        public FUserProfilePersonalProjectEdit(Account account, UserPersonalProject userPersonalProject) : this(account)
        {
            this.userPersonalProject = userPersonalProject;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FUserProfilePersonalProjectEdit_Load(object sender, EventArgs e)
        {
            if (!(userPersonalProject is null))
            {
                txtNameProject.Text = userPersonalProject.ProjectName;
                rtxtDescription.Text = userPersonalProject.Description;
                dtpFrom.Value = userPersonalProject.From;
                dtpTo.Value = userPersonalProject.To;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (userPersonalProject is null)
            {
                userProfile.UserPersonalProjects.Add(new UserPersonalProject()
                {
                    ProjectName = txtNameProject.Text,
                    From = dtpFrom.Value,
                    To = dtpTo.Value,
                    Description = rtxtDescription.Text,
                });
            }
            else
            {
                var newUserPersonalProject = userProfile.UserPersonalProjects.SingleOrDefault(row => row.Id == userPersonalProject.Id);
                newUserPersonalProject.ProjectName = txtNameProject.Text;
                newUserPersonalProject.From = dtpFrom.Value;
                newUserPersonalProject.To = dtpTo.Value;
                newUserPersonalProject.Description = rtxtDescription.Text;
            }
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
