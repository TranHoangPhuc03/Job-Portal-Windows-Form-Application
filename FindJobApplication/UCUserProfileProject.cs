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
    public partial class UCUserProfileProject : UserControl
    {
        UserProfileDao userProfileDao = new UserProfileDao();
        UserProfile userProfile = null;
        public UCUserProfileProject()
        {
            InitializeComponent();
        }

        public UCUserProfileProject(Account account) : this()
        {
            userProfile = userProfileDao.FindUserProfileByAccountId(account.Id);
        }

        public UCUserProfileProject(Account account, UserPersonalProject userPersonalProject) : this(account)
        {
            lblNameProject.Text = userPersonalProject.ProjectName;
            lblStartDay.Text = userPersonalProject.From.ToString("dd-MM-yyyy");
            lblEndDay.Text = userPersonalProject.To.ToString("dd-MM-yyyy");
            lblSeeProject.Tag = userPersonalProject.Description;
            Tag = userPersonalProject;
        }

        private void lblSeeProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = (lblSeeProject.Tag).ToString();
            System.Diagnostics.Process.Start(url);
        }

        private void pbEditProject_Click(object sender, EventArgs e)
        {
            FUserProfilePersonalProjectEdit fUserProfilePersonalProjectEdit = new FUserProfilePersonalProjectEdit(userProfile.Account, Tag as UserPersonalProject);
            fUserProfilePersonalProjectEdit.Show();
        }

        private void pbDeleteProject_Click(object sender, EventArgs e)
        {
            int result = userProfileDao.DeleteUserPersonalProject((Tag as UserPersonalProject).Id);
            if (result == 0)
            {
                MessageDialog.Show(ParentForm, "Deleted failed");
            }
            else
            {
                MessageDialog.Show(ParentForm, "Deleted successfully");
            }
        }
    }
}
