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
using Guna.UI2.WinForms;
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FCompanyProfileInfomationEdit : Form
    {
        CompanyProfile companyProfile = null;
        CompanyProfileDao companyProfileDao = new CompanyProfileDao();
        List<PictureBox> companyImageControls = new List<PictureBox>();

        public FCompanyProfileInfomationEdit()
        {
            InitializeComponent();
        }
        public FCompanyProfileInfomationEdit(CompanyProfile companyProfile) : this()
        {
            this.companyProfile = companyProfile;
            companyImageControls.Add(pbCompany1);
            companyImageControls.Add(pbCompany2);
            companyImageControls.Add(pbCompany3);
            companyImageControls.Add(pbCompany4);
        }

        private void pbCompany1_MouseLeave(object sender, EventArgs e)
        {
            pbCompany1.Image = Properties.Resources.VanPhong;
        }
        private void pbCompany1_MouseEnter(object sender, EventArgs e)
        {
            pbCompany1.Image = Properties.Resources.camera_Edit1;

        }
        private void pbCompany2_MouseLeave(object sender, EventArgs e)
        {
            pbCompany2.Image = Properties.Resources.VanPhong;
        }
        private void pbCompany2_MouseEnter(object sender, EventArgs e)
        {
            pbCompany2.Image = Properties.Resources.camera_Edit1;

        }
        private void pbCompany3_MouseLeave(object sender, EventArgs e)
        {
            pbCompany3.Image = Properties.Resources.VanPhong;
        }
        private void pbCompany3_MouseEnter(object sender, EventArgs e)
        {
            pbCompany3.Image = Properties.Resources.camera_Edit1;

        }
        private void pbCompany4_MouseLeave(object sender, EventArgs e)
        {
            pbCompany4.Image = Properties.Resources.VanPhong;
        }
        private void pbCompany4_MouseEnter(object sender, EventArgs e)
        {
            pbCompany4.Image = Properties.Resources.camera_Edit1;
        }
        private void pbUser_MouseEnter(object sender, EventArgs e)
        {
            pbUser.Image = Properties.Resources.camera_Edit;
        }
        private void pbUser_MouseLeave(object sender, EventArgs e)
        {
            pbUser.Image = pbUser.InitialImage;
        }
        private void FCompanyProfileInfomationEdit_Load(object sender, EventArgs e)
        {
            txtNameCompany.Text = companyProfile.Account.Name;
            txtEmail.Text = companyProfile.Account.Email;
            txtPhoneNumber.Text = companyProfile.PhoneNumber;
            dtpDateEstablish.Text = companyProfile.DateEstablish?.ToString("dd-MM-yyyy") ?? DateTime.Now.ToString("dd-MM-yyy");
            txtCompanySize.Text = companyProfile.CompanySize.ToString();
            txtAddress.Text = companyProfile.Address;
            txtLink.Text = companyProfile.CompanyLink;
            pbUser.Image = pbUser.InitialImage = ImageUtils.FromBytesToImage(companyProfile.Account.Avatar);
            int index = 0;
            foreach (CompanyImage companyImage in companyProfile.CompanyImages)
            {
                companyImageControls[index].Image = ImageUtils.FromBytesToImage(companyImage.ImageContent);
                index++;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            companyProfile.Account.Name = txtNameCompany.Text;
            companyProfile.Account.Email = txtEmail.Text;
            companyProfile.PhoneNumber = txtPhoneNumber.Text;
            companyProfile.Address = txtAddress.Text;
            companyProfile.DateEstablish = dtpDateEstablish.Value;
            companyProfile.CompanySize =  Convert.ToInt32(this.txtCompanySize.Text);
            companyProfile.CompanyLink = txtLink.Text;
            companyProfile.Account.Avatar = ImageUtils.FromImageToBytes(pbUser.Image);
            companyProfileDao.DeleteAllCompanyImages(companyProfile);
            foreach (PictureBox pictureBox in companyImageControls)
            {
                companyProfile.CompanyImages.Add(new CompanyImage()
                {
                    ImageContent = ImageUtils.FromImageToBytes(pictureBox.Image)
                });
            };

            int result = companyProfileDao.UpdateCompanyProfile(companyProfile);
            if (result == 0)
            {
                MessageDialog.Show(this, "Update infomation failed");
            }
            else
            {
                MessageDialog.Show(this, "Update infomation successfully");
                Close();
            }
        }
    }
}
