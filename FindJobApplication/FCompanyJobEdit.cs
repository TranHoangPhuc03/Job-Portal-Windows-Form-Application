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
using System.Web.UI.Design;
using System.Windows.Forms;

namespace FindJobApplication
{
    public partial class FCompanyJobEdit : Form
    {
        private string formAction;
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
            this.formAction = "Create";
        }

        public FCompanyJobEdit(int jobPostId) : this()
        {
            this.Tag = jobPostId;
            this.formAction = "Update";
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

            if (this.Tag != null)
            {
                int jobPostId = (int)this.Tag;
                JobPostDao jobPostDao = new JobPostDao();
                DataRow dr = jobPostDao.findById(jobPostId) as DataRow;

                this.txtNameJob.Text = dr["title"].ToString();
                this.txtSalary.Text = dr["salary"].ToString();
                this.rTxtBenefits.Text = dr["benefit"].ToString();
                this.rTxtCandidateRequirements.Text = dr["requirement"].ToString();
                this.rTxtJobDescription.Text = dr["description"].ToString();
                this.rTxtPrioritize.Text = dr["prioritize"].ToString();
                this.txtNumberOfRecruitment.Text = dr["recruitment_number"].ToString();
                this.txtWorkAddress.Text = dr["address"].ToString();
                this.cbExperience.SelectedIndex = (int)dr["year_experience_id"];
                this.cbLocation.SelectedIndex = (int)dr["location_id"];
                this.dtpExpireDate.Text = dr["expire_date"].ToString();

                if (this.formAction == "Update")
                {
                    this.btnPostJob.Text = "Update";
                }
            }
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
            if (this.formAction == "Create")
            {
                int results = jobPostDao.save(jobPost);
                if (results == 0)
                {
                    MessageDialog.Show(this, "Failed to save the job post", "Failed", MessageDialogStyle.Light);
                }
                else
                {
                    MessageDialog.Show(this, "Job post saved successfully", MessageDialogStyle.Light);
                    this.Close();
                }
            }
            else if (this.formAction == "Update")
            {
                int jobPostId = (int)this.Tag;
                int results = jobPostDao.updateById(jobPost, jobPostId);
                if (results == 0)
                {
                    MessageDialog.Show(this, "Failed to update the job post", "Error", MessageDialogStyle.Light);
                }
                else
                {
                    MessageDialog.Show(this, "Job post updated successfully", MessageDialogStyle.Light);
                    this.Close();
                }
            }
        }

        private void FCompanyJobEdit_Shown(object sender, EventArgs e)
        {

        }
    }
}
