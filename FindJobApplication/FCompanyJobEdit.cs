using FindJobApplication.Daos;
using FindJobApplication.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections;
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
    public partial class FCompanyJobEdit : Form
    {
        private Dictionary<string, string> controlToField = new Dictionary<string, string>()
        {
            { "txtNameJob", "Title" },
            { "cbExperience", "YearExperienceId" },
            { "cbLocation", "LocationId" },
            { "txtSalary", "Salary" },
            { "rTxtJobDescription", "Description" },
            { "rTxtCandidateRequirements", "Requirement" },
            { "rTxtPrioritize", "Prioritize" },
            { "rTxtBenefits", "Benefit" },
            { "txtNumberOfRecruitment", "RecruitmentNumber" },
            { "txtWorkAddress", "Address" },
            { "dtpExpireDate", "ExpireDate" }
        };

        public FCompanyJobEdit()
        {
            InitializeComponent();
        }

        private void FCompanyJobEdit_Load(object sender, EventArgs e)
        {
            LocationDao locationDao = new LocationDao();
            YearExperienceDao yearExperienceDao = new YearExperienceDao();

            this.cbLocation.ValueMember = "id";
            this.cbLocation.DisplayMember = "name";
            this.cbLocation.DataSource = locationDao.findAll();

            this.cbExperience.ValueMember = "id";
            this.cbExperience.DisplayMember = "name";
            this.cbExperience.DataSource = yearExperienceDao.findAll();
        }

        private JobPost getJobPostInfo()
        {
            JobPost jobPost = new JobPost();
            foreach (Control control in this.guna2Panel1.Controls) {
                string propertyName = "";
                if(controlToField.TryGetValue(control.Name, out propertyName))
                {
                    object value = null;
                    if (control is ListControl listControl)
                    {
                        value = listControl.SelectedValue;
                    }
                    else
                    {
                        value = control.Text;
                    }
                    typeof(JobPost).GetProperty(propertyName)?.SetValue(jobPost, Convert.ChangeType(value, typeof(JobPost).GetProperty(propertyName).PropertyType));
                }

            }
            jobPost.PostDate = DateTime.Now;
            return jobPost;
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            JobPost jobPost = getJobPostInfo();
            jobPost.CompanyId = Global.loginId;
            JobPostDao jobPostDao = new JobPostDao();
            int results = jobPostDao.save(jobPost);
            if (results == 0)
            {
                MessageDialog.Show(this, "Failed to save the job post", "Failed",  MessageDialogStyle.Light);
            }
            else
            {
                MessageDialog.Show(this, "Job post saved successfully", MessageDialogStyle.Light);
                this.Close();
            }
        }
    }
}
