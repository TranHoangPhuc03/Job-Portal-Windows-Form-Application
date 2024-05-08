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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FindJobApplication
{
    public partial class FUserProfileEducationEdit : Form
    {
        UserProfileDao userProfileDao = new UserProfileDao();
        UserProfile userProfile = null;
        UserEducation userEducation = null;
        public FUserProfileEducationEdit()
        {
            InitializeComponent();
        }

        public FUserProfileEducationEdit(Account account) : this()
        {
            userProfile = userProfileDao.FindUserProfileByAccountId(account.Id);
        }

        public FUserProfileEducationEdit(Account account, UserEducation userEducation) : this(account)
        {
            this.userEducation = userEducation;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (userEducation is null)
            {
                userProfile.UserEducations.Add(new UserEducation()
                {
                    SchoolName = txtSchool.Text,
                    Major = txtMajor.Text,
                    From = dtpFrom.Value,
                    To = dtpTo.Value,
                    Detail = txtAddtionalDetails.Text
                });
            }
            else
            {
                var newUserEducation = userProfile.UserEducations.SingleOrDefault(row => row.Id == userEducation.Id);
                newUserEducation.SchoolName = txtSchool.Text;
                newUserEducation.Major = txtMajor.Text;
                newUserEducation.From = dtpFrom.Value;
                newUserEducation.To = dtpTo.Value;
                newUserEducation.Detail = txtAddtionalDetails.Text;
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

        private void FUserProfileEducationEdit_Load(object sender, EventArgs e)
        {
            if (!(userEducation is null))
            {
                txtSchool.Text = userEducation.SchoolName;
                txtMajor.Text = userEducation.Major;
                dtpFrom.Value = userEducation.From;
                dtpTo.Value = userEducation.To;
                txtAddtionalDetails.Text = userEducation.Detail;
            }
        }
    }
}
