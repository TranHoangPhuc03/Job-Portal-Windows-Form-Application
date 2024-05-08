using FindJobApplication.Daos;
using FindJobApplication.Utils;
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
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FCompanyJobEdit : Form
    {
        private string formAction;
        JobPostDao jobPostDao = new JobPostDao();
        JobPost jobPost = null;

        public FCompanyJobEdit()
        {
            InitializeComponent();
            formAction = "Create";
        }

        public FCompanyJobEdit(int jobPostId) : this()
        {
            jobPost = jobPostDao.FindJobPostById(jobPostId);
            Tag = jobPost;
            formAction = "Update";
        }

        private void FCompanyJobEdit_Load(object sender, EventArgs e)
        {
            SuspendLayout();
            yearExperienceTableAdapter.Fill(yearExperienceDataSet.YearExperience);
            locationTableAdapter.Fill(locationcDataSet.Location);
            skillTableAdapter.Fill(skillDataSet.Skill);

            if (jobPost != null)
            {

                txtNameJob.Text = jobPost.Title;
                txtSalary.Text = jobPost.Salary.ToString();
                rTxtBenefits.Text = jobPost.Benefit;
                rTxtCandidateRequirements.Text = jobPost.Requirement;
                rTxtJobDescription.Text = jobPost.Description;
                rTxtPrioritize.Text = jobPost.Prioritize;
                txtNumberOfRecruitment.Text = jobPost.RecruitmentNumber.ToString();
                txtWorkAddress.Text = jobPost.Address;
                cbExperience.SelectedValue = jobPost.YearExperienceId;
                cbLocation.SelectedValue = jobPost.LocationId;
                dtpExpireDate.Text = jobPost.ExpireDate.ToString();
                pnlSkill.SuspendLayout();
                foreach (var skill in jobPost.Skills)
                {
                    pnlSkill.Controls.Add(new UCSkillTag(skill));
                }
                pnlSkill.ResumeLayout();

                btnPostJob.Text = "Update";
            }
            ResumeLayout();
        }

        private void GetJobPostInfo()
        {
            if (jobPost is null)
            {
                jobPost = new JobPost();
            }
            jobPost.Title = txtNameJob.Text;
            jobPost.Salary = Convert.ToInt32(txtSalary.Text);
            jobPost.LocationId = Convert.ToInt32(cbLocation.SelectedValue);
            jobPost.YearExperienceId = Convert.ToInt32(cbExperience.SelectedValue);
            jobPost.Skills = GetSkillsInPanel();
            jobPost.Description = rTxtJobDescription.Text;
            jobPost.Requirement = rTxtCandidateRequirements.Text;
            jobPost.Prioritize = rTxtPrioritize.Text;
            jobPost.Benefit = rTxtBenefits.Text;
            jobPost.RecruitmentNumber = Convert.ToInt32(txtNumberOfRecruitment.Text);
            jobPost.ExpireDate = dtpExpireDate.Value;
            jobPost.Address = txtWorkAddress.Text;
        }

        public ICollection<Skill> GetSkillsInPanel()
        {
            var skills = new List<Skill>();
            foreach (Control c in pnlSkill.Controls)
            {
                skills.Add(c.Tag as Skill);
            }
            return skills;
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            GetJobPostInfo();
            jobPost.CompanyId = Session.account.Id;
            if (formAction == "Create")
            {
                jobPost.PostDate = DateTime.Now;
                int results = jobPostDao.SaveNewJobPost(jobPost);
                if (results == 0)
                {
                    MessageDialog.Show(this, "Failed to save the job post", "Failed", MessageDialogStyle.Light);
                }
                else
                {
                    MessageDialog.Show(this, "Job post saved successfully", MessageDialogStyle.Light);
                    DialogResult = DialogResult.OK;
                    Dispose();
                }
            }
            else
            {
                int results = jobPostDao.UpdateJobPostById(jobPost);
                if (results == 0)
                {
                    MessageDialog.Show(this, "Failed to update the job post", "Error", MessageDialogStyle.Light);
                }
                else
                {
                    MessageDialog.Show(this, "Job post updated successfully", MessageDialogStyle.Light);
                    DialogResult = DialogResult.OK;
                    Dispose();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlSkill.Controls.Add(
                new UCSkillTag(new Skill() { Id = (int)cbSkill.SelectedValue, Name = cbSkill.Text})
            );
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
