using FindJobApplication.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindJobApplication.Daos;
using FindJobApplication.Utils;
using System.IO;
using Guna.UI2.WinForms;

namespace FindJobApplication
{
    public partial class FUserProfileInformationEdit : Form
    {
        UserProfile userProfile = null;
        UserProfileDao userProfileDao = new UserProfileDao();

        public FUserProfileInformationEdit()
        {
            InitializeComponent();
        }

        public FUserProfileInformationEdit(Account account) : this()
        {
            userProfile = userProfileDao.FindUserProfileByAccountId(account.Id);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userProfile.Account.Name = txtFullName.Text;
            userProfile.Title = txtTitle.Text;
            userProfile.Account.Email = txtEmail.Text;
            userProfile.PhoneNumber = txtPhoneNumber.Text;
            userProfile.PersonalLink = txtLink.Text;
            userProfile.DateOfBirth = dtpDateOfBirth.Value;
            userProfile.Gender = cbGender.Text;
            userProfile.Address = txtAddress.Text;
            userProfile.Account.Avatar = ImageUtils.FromImageToBytes(pbUser.Image);

            int result = userProfileDao.UpdateUserProfile(userProfile);
            if (result == 0)
            {
                MessageDialog.Show(this, "Update information failed.");
            }
            else
            {
                MessageDialog.Show(this, "Update information successfully.");
                Close();
            }
        }

        private void FUserProfileInformationEdit_Load(object sender, EventArgs e)
        {
            pbUser.Image = pbUser.InitialImage = ImageUtils.FromBytesToImage(userProfile.Account.Avatar);
            txtFullName.Text = userProfile.Account.Name;
            txtEmail.Text = userProfile.Account.Email;
            txtTitle.Text = userProfile.Title;
            txtPhoneNumber.Text = userProfile.PhoneNumber;
            txtAddress.Text = userProfile.Address;
            txtLink.Text = userProfile.PersonalLink;
            dtpDateOfBirth.Text = (userProfile.DateOfBirth ?? DateTime.Now).ToString("dd-MM-yyyy");
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                FileName = "Select an image file",
                Filter = "Image files (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg",
                Title = "Open image file"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbUser.Image = pbUser.InitialImage = Image.FromFile(dialog.FileName);
            }
        }

        private void pbUser_MouseEnter(object sender, EventArgs e)
        {
            pbUser.Image = Properties.Resources.camera_Edit;
        }

        private void pbUser_MouseLeave(object sender, EventArgs e)
        {
            pbUser.Image = pbUser.InitialImage;
        }
    }
}
