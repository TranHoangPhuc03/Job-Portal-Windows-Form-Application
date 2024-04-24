using Guna.UI.WinForms;
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
using FindJobApplication.Models;
using FindJobApplication.Daos;

namespace FindJobApplication
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        
        public Guna2TextBox TxtSeach { get => txtSearch; }
        public GunaComboBox CbLocation { get => cbLocation; }
        public GunaComboBox CbExperince { get => cbExperience; }
        public Guna2Button BtnSearch { get => btnSearch; }
        public FlowLayoutPanel PnlListJob { get => pnlListJob; }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = this.TxtSeach.Text;
            int locationId = this.CbLocation.SelectedIndex;
            int experienceId = this.CbExperince.SelectedIndex;

            JobPostDao jobPostDao = new JobPostDao();
            List<JobPost> dt = jobPostDao.FindAllJobPost();
            if (!string.IsNullOrEmpty(keyword))
            {
                dt = dt.Where(row => row.Title.Contains(keyword)).ToList();
            }
            this.fillJobPostToPanel(dt);
        }

        public void fillJobPostToPanel(List<JobPost> jobPosts)
        {
            this.pnlListJob.Controls.Clear();

            SkillDao skillDao = new SkillDao();
            UserProfileDao userProfileDao = new UserProfileDao();
            List<Skill> skills = skillDao.FindAllSkill();
            List<int> favouriteJobs = userProfileDao.FindAllJobPostIdFavourite(Session.accountId);

            foreach (JobPost jobPost in jobPosts)
            {
                List<Skill> filteredSkill = new List<Skill>();
                foreach(int skillId in jobPost.SkillID)
                {
                    filteredSkill.Add(skills.FirstOrDefault(o => o.Id == skillId));
                }
                bool isFavourite = favouriteJobs.Contains(jobPost.Id);

                UCJob uCJob = new UCJob(jobPost, filteredSkill, isFavourite);
                this.pnlListJob.Controls.Add(uCJob);
            }
        }

        private void UCHome_Load(object sender, EventArgs e)
        {
            JobPostDao jobPostDao = new JobPostDao();
            YearExperienceDao yearExperienceDao = new YearExperienceDao();
            LocationDao locationDao = new LocationDao();

            this.CbLocation.ValueMember = "id";
            this.CbLocation.DisplayMember = "name";
            this.CbLocation.DataSource = locationDao.FindAllLocationList();

            this.CbExperince.ValueMember = "id";
            this.CbExperince.DisplayMember = "name";
            this.CbExperince.DataSource = yearExperienceDao.FindAllExperienceList();

            this.fillJobPostToPanel(jobPostDao.FindAllJobPost());
        }
    }
}
