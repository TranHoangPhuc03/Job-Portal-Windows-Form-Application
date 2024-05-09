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
    public partial class FCompanyProfileTop3Reasons : Form
    {
        CompanyProfileDao companyProfileDao = new CompanyProfileDao();
        CompanyProfile companyProfile = null;
        public FCompanyProfileTop3Reasons()
        {
            InitializeComponent();
        }
        public FCompanyProfileTop3Reasons(CompanyProfile companyProfile) : this()
        {
            this.companyProfile = companyProfileDao.FindCompanyProfileByAccountId(companyProfile.Id);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FCompanyProfileTop3Reasons_Load(object sender, EventArgs e)
        {
            rTxtOverview.Text = companyProfile.Reason;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            companyProfile.Reason = rTxtOverview.Text;
            int result = companyProfileDao.UpdateCompanyProfile(companyProfile);
            if (result == 0)
            {
                MessageDialog.Show(this, "Update failed");
            }
            else
            {
                MessageDialog.Show(this, "Update successfully");
                Close();
                FCompanyHome.Instance.UCCompanySubMenuRight.btnProfile_Click(this, new EventArgs());
            }
        }
    }
}
