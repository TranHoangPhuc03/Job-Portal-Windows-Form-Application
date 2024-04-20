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
        UCUserSubMenuRight uCUserSubMenuRight = new UCUserSubMenuRight();

        public FHome()
        {
            InitializeComponent();
            customForUser();
        }
        private void customForUser ()
        {
            Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uCUserSubMenuRight.hideMenu();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            uCHome.BtnSearch.Click += jobFilterSearch;
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            uCUserSubMenuRight.hideAndShowSubMenu();

        }

        private void FHome_Load(object sender, EventArgs e)
        {
            this.Hide();
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
            this.pnlMain.Controls.Add(uCHome);
            this.Show();
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

        private void pbUserImage_Click(object sender, EventArgs e)
        {
            this.tpnlUserNav.AutoSize ^= true;
        }
    }
}
