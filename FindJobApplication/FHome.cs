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
            this.uCMain.BtnLogOut.Click += btnLogOut_Click;
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

        private List<UCJob> buildJobListFromDataTable(DataTable dt)
        {
            List<UCJob> jobList = new List<UCJob>();
            foreach (DataRow row in dt.Rows)
            {
                JobPost jobPost = new JobPost(Convert.ToInt32(row["id"]), row["title"].ToString());
                UCJob uCJob = new UCJob();
                uCJob.JobName.Text = row["title"].ToString();
                uCJob.CompanyName.Text = row["company_name"].ToString();
                uCJob.Location.Text = row["location_name"].ToString();
                uCJob.Salary.Text = row["salary"].ToString();
                uCJob.Tag = jobPost;
                uCJob.LinkLabelJob.Tag = (int)row["id"];
                uCJob.CompanyName.Tag = (int)row["company_id"];
                jobList.Add(uCJob);
            }
            return jobList;
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            JobPostDao jobPostDao = new JobPostDao();
            YearExperienceDao yearExperienceDao = new YearExperienceDao();
            LocationDao locationDao = new LocationDao();
            DataTable dt = jobPostDao.findAll();

            this.uCHome.CbLocation.ValueMember = "id";
            this.uCHome.CbLocation.DisplayMember = "name";
            this.uCHome.CbLocation.DataSource = locationDao.findAll();

            this.uCHome.CbExperince.ValueMember = "id";
            this.uCHome.CbExperince.DisplayMember = "name";
            this.uCHome.CbExperince.DataSource = yearExperienceDao.findAll();

            this.uCHome.fillDataToPanel(buildJobListFromDataTable(dt));
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            uCMain.updateStatus(uCMain.BtnHome);
            uCMain.PnlMid.Controls.Clear();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jobFilterSearch(object sender, EventArgs e)
        {
            string keyword = this.uCHome.TxtSeach.Text;
            int locationId = this.uCHome.CbLocation.SelectedIndex;
            int experienceId = this.uCHome.CbExperince.SelectedIndex;
            int salaryId = this.uCHome.CbSalary.SelectedIndex;

            JobPostDao jobPostDao = new JobPostDao();
            DataTable dt = jobPostDao.findAll();
            foreach(DataRow row in dt.Rows)
            {
                if (keyword != "" && !row["title"].ToString().Contains(keyword))
                    row.Delete();
            }
            dt.AcceptChanges();
            this.uCHome.fillDataToPanel(buildJobListFromDataTable(dt));
        }
    }
}
