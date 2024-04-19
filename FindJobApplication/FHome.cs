using FindJobApplication.Daos;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindJobApplication.Models;

namespace FindJobApplication
{
    public partial class FHome : Form
    {
        UCHome uCHome = new UCHome();
        UCMain uCMain = new UCMain();
        UCUserSubMenuRight uCUserSubMenuRight = new UCUserSubMenuRight();

        public FHome()
        {
            InitializeComponent();
            this.Controls.Add(uCMain);
            this.uCMain.BtnHome.Click += btnHome_Click;
            this.uCMain.BtnUser.Click += btnUser_Click;
            this.uCMain.BtnHome.PerformClick();
            customForUser();
        }
        private void customForUser ()
        {
            uCMain.BtnUser.Text = "David Beckham";
            uCMain.PbHomeUser.Image = Properties.Resources.man;
            uCMain.PnlMid.Controls.Add(uCUserSubMenuRight);
            uCUserSubMenuRight.Location = new Point(uCMain.PnlMid.Width - uCUserSubMenuRight.Width, 0);
            Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uCUserSubMenuRight.hideMenu();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            uCMain.updateStatus(uCMain.BtnHome);
            uCMain.PnlMid.Controls.Clear();
            uCMain.PnlMid.Controls.Add(uCHome);
            uCHome.Location = new Point(uCMain.PnlMid.Width / 2 - uCHome.Width / 2, 0);
            uCHome.BtnSearch.Click += jobFilterSearch;
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            uCUserSubMenuRight.hideAndShowSubMenu();

        }

        private List<UCJob> BuildJobPostList(List<JobPost> list)
        {
            UCUserProfileSkill skill1 = new UCUserProfileSkill();
            UCUserProfileSkill skill2 = new UCUserProfileSkill();
            UCUserProfileSkill skill3 = new UCUserProfileSkill();

            List<UCJob> jobList = new List<UCJob>();
            LocationDao locationDao = new LocationDao();
            YearExperienceDao yearExperienceDao = new YearExperienceDao();
            var locationDict = locationDao.FindAllLocationDict();
            var yearExperienceDict = yearExperienceDao.FindAllExperienceDict(); ;
            foreach (JobPost jobPost in list)
            {
                UCJob uCJob = new UCJob();
                uCJob.JobName.Text = jobPost.Title;
                uCJob.CompanyName.Text = jobPost.CompanyName;
                uCJob.Location.Text = locationDict[jobPost.LocationId].Name;
                uCJob.Salary.Text = jobPost.Salary.ToString();
                uCJob.Tag = jobPost;
                uCJob.LLblNameJob.Tag = jobPost.Id;
                uCJob.CompanyName.Tag = jobPost.CompanyId;
                uCJob.PnlSkill.Controls.Add(skill1); // add skill
                uCJob.PnlSkill.Controls.Add(skill2); // add skill
                uCJob.PnlSkill.Controls.Add(skill3); // add skill

                jobList.Add(uCJob);
            }
            return jobList;
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            JobPostDao jobPostDao = new JobPostDao();
            YearExperienceDao yearExperienceDao = new YearExperienceDao();
            LocationDao locationDao = new LocationDao();

            this.uCHome.CbLocation.ValueMember = "id";
            this.uCHome.CbLocation.DisplayMember = "name";
            this.uCHome.CbLocation.DataSource = locationDao.FindAllLocationList();

            this.uCHome.CbExperince.ValueMember = "id";
            this.uCHome.CbExperince.DisplayMember = "name";
            this.uCHome.CbExperince.DataSource = yearExperienceDao.FindAllExperienceList();

            this.uCHome.fillJobPostToPanel(jobPostDao.FindAllJobPost());
        }

        private void jobFilterSearch(object sender, EventArgs e)
        {
            string keyword = this.uCHome.TxtSeach.Text;
            int locationId = this.uCHome.CbLocation.SelectedIndex;
            int experienceId = this.uCHome.CbExperince.SelectedIndex;

            JobPostDao jobPostDao = new JobPostDao();
            List<JobPost> dt = jobPostDao.FindAllJobPost();
            if (!string.IsNullOrEmpty(keyword))
            {
                dt = dt.Where(row => row.Title.Contains(keyword)).ToList();
            }
            this.uCHome.fillJobPostToPanel(dt);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
