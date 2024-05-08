using FindJobApplication.Daos;
using FindJobApplication.Entities;
using Guna.UI2.WinForms;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class UCUCUserProfileEducationAndWorkExperience : UserControl
    {
        UserProfileDao userProfileDao = new UserProfileDao();
        UserProfile userProfile = null;
        public UCUCUserProfileEducationAndWorkExperience()
        {
            InitializeComponent();
        }

        public UCUCUserProfileEducationAndWorkExperience(Account account) : this()
        {
            userProfile = userProfileDao.FindUserProfileByAccountId(account.Id);
        }

        public UCUCUserProfileEducationAndWorkExperience(Account account, UserEducation userEducation) : this(account)
        {
            lblMajor.Text = userEducation.Major;
            lblSchool.Text = userEducation.SchoolName;
            lblStartDay.Text = userEducation.From.ToString("dd-MM-yyyy");
            lblEndDay.Text = userEducation.To.ToString("dd-MM-yyyy");
            Tag = userEducation;
        }

        public UCUCUserProfileEducationAndWorkExperience(Account account, UserWorkExperience userWorkExperience) : this(account)
        {
            lblMajor.Text = userWorkExperience.JobTitle;
            lblSchool.Text = userWorkExperience.CompanyName;
            lblStartDay.Text = userWorkExperience.From.ToString("dd-MM-yyyy");
            lblEndDay.Text = userWorkExperience.To.ToString("dd-MM-yyyy");
            Tag = userWorkExperience;
        }

        private void pbEditEducationOrWork_Click(object sender, EventArgs e)
        {
            if (Tag is UserEducation)
            {
                FUserProfileEducationEdit fUserProfileEducationEdit = new FUserProfileEducationEdit(userProfile.Account , Tag as UserEducation);
                fUserProfileEducationEdit.Show();
            }
            else if (Tag is UserWorkExperience)
            {
                UserWorkExperience userEducation = userProfile.UserWorkExperiences
                    .FirstOrDefault(row => row.Id == (Tag as UserWorkExperience).Id);

            }
        }

        private void pbDeleteEducationOrWork_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (Tag is UserEducation)
            {
                result = userProfileDao.DeleteUserEducation((Tag as UserEducation).Id);
            }
            else if (Tag is UserWorkExperience) 
            {
                result = userProfileDao.DeleteUserWorkExperience((Tag as UserWorkExperience).Id);
            }
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
