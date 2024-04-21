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
using Guna.UI2.WinForms;

namespace FindJobApplication
{
    public partial class FHome : Form
    {
        UCHome uCHome = new UCHome();
        UCUserSubMenuRight uCUserSubMenuRight = new UCUserSubMenuRight();
        static FHome _obj;
        public FHome()
        {
            InitializeComponent();
        }
        public static FHome Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FHome();
                }
                return _obj;
            } 
        }
        public Guna2CustomGradientPanel PnlMain { get => pnlMain; set => pnlMain = value; }


        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            JobPostDao jobPostDao = new JobPostDao();

            this.uCHome.fillJobPostToPanel(jobPostDao.FindAllJobPost());
            this.pnlMain.Controls.Add(uCHome);
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            uCUserSubMenuRight.hideAndShowSubMenu();
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            _obj = this;
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

        private void btnSocial_Click(object sender, EventArgs e)
        {
            UCSocial uCSocial = new UCSocial();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uCSocial);
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            UCMail uCMail = new UCMail();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uCMail);
        }

        private void btnTrending_Click(object sender, EventArgs e)
        {
            UCTopTrending uCTopTrending = new UCTopTrending();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uCTopTrending);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            UCProfile uCProfile = new UCProfile();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uCProfile);
        }

        private void btnFavourites_Click(object sender, EventArgs e)
        {
            UCUserListCompanyFollowing uCUserListCompanyFollowing = new UCUserListCompanyFollowing();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uCUserListCompanyFollowing);
        }

        private void btnMyJob_Click(object sender, EventArgs e)
        {
            UCMyJob uCMyJob = new UCMyJob();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uCMyJob);
        }

        private void btnHistorySocial_Click(object sender, EventArgs e)
        {
            UCSocialHistory uCSocialHistory = new UCSocialHistory();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uCSocialHistory);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            UCSetting uCSetting = new UCSetting();
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(uCSetting);
        }
    }
}
