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
    public partial class FCompanyProfileOverviewEdit : Form
    {
        CompanyProfileDao companyProfileDao = new CompanyProfileDao();
        CompanyProfile companyProfile = null;
        public FCompanyProfileOverviewEdit()
        {
            InitializeComponent();
        }
        public FCompanyProfileOverviewEdit(CompanyProfile companyProfile) : this()
        {
            this.companyProfile = companyProfile;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            companyProfile.Overview = rTxtOverview.Text;
            int result = companyProfileDao.UpdateCompanyProfile(companyProfile);
            if (result == 0)
            {
                MessageDialog.Show("Update failed");
            }
            else
            {
                MessageDialog.Show("Update successfully");
                Close();
            }
        }

        private void FCompanyProfileOverviewEdit_Load(object sender, EventArgs e)
        {
            rTxtOverview.Text = companyProfile.Overview;
        }
    }
}
