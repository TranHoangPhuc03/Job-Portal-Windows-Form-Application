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
            InitialEventForCompanyOfficeImage();
        }
        public FCompanyProfileInfomationEdit(CompanyProfile companyProfile) : this()
        {
            this.companyProfile = companyProfileDao.FindCompanyProfileByAccountId(companyProfile.Id);
        }

        public void InitialEventForCompanyOfficeImage()
        {
            companyImageControls.Add(pbCompany1);
            companyImageControls.Add(pbCompany2);
            companyImageControls.Add(pbCompany3);
            companyImageControls.Add(pbCompany4);
            foreach (PictureBox pictureBox in companyImageControls)
            {
                pictureBox.MouseClick += (sender, e) =>
                {
                    OpenFileDialog dialog = new OpenFileDialog()
                    {
                        FileName = "Select an image file",
                        Filter = "Image files (*.png; *.jpg; *.jpeg)|*.png; *.jpg; *.jpeg",
                        Title = "Open image file"
                    };

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.Image = pictureBox.InitialImage = Image.FromFile(dialog.FileName);
                    }
                };
                pictureBox.MouseLeave += (sender, e) =>
                {
                    pictureBox.Image = pictureBox.InitialImage;
                };
                pictureBox.MouseEnter += (sender, e) =>
                {
                    pictureBox.Image = Properties.Resources.camera_Edit;
                };
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
        private void FCompanyProfileInfomationEdit_Load(object sender, EventArgs e)
        {
            locationTableAdapter.Fill(locationcDataSet.Location);
            txtNameCompany.Text = companyProfile.Account.Name;
            txtEmail.Text = companyProfile.Account.Email;
            txtPhoneNumber.Text = companyProfile.PhoneNumber;
            dtpDateEstablish.Text = companyProfile.DateEstablish?.ToString("dd-MM-yyyy") ?? DateTime.Now.ToString("dd-MM-yyy");
            txtCompanySize.Text = companyProfile.CompanySize.ToString();
            txtAddress.Text = companyProfile.Address;
            txtLink.Text = companyProfile.CompanyLink;
            pbUser.Image = pbUser.InitialImage = ImageUtils.FromBytesToImage(companyProfile.Account.Avatar);
            int index = 0;
            foreach (PictureBox pictureBox in companyImageControls)
            {
                if (index < companyProfile.CompanyImages.Count)
                {
                    pictureBox.Image = pictureBox.InitialImage = ImageUtils.FromBytesToImage(
                        companyProfile.CompanyImages.ElementAt(index).ImageContent
                    );
                }
                else
                {
                    pictureBox.Image = pictureBox.InitialImage = Properties.Resources.camera_Edit;
                }
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
            companyProfile.CompanySize =  Convert.ToInt32(txtCompanySize.Text == "" ? "1" : txtCompanySize.Text);
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
                FCompanyHome.Instance.UCCompanySubMenuRight.btnProfile_Click(this, new EventArgs());
            }
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
    }
}
