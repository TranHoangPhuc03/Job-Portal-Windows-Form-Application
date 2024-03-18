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
            uCMain.BtnHome.Click += btnHome_Click;
            uCMain.BtnUser.Click += btnUser_Click;
            uCMain.BtnLogOut.Click += btnLogOut_Click;
            uCMain.BtnHome.PerformClick();
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
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            uCUserSubMenuRight.hideAndShowSubMenu();

        }
        private void FHome_Load(object sender, EventArgs e)
        {
            JobPostDao jobPostDao = new JobPostDao();
            DataTable dt = jobPostDao.findAll();
            List<UCJob> jobList = new List<UCJob>();
            foreach (DataRow row in dt.Rows)
            {
                UCJob uCJob = new UCJob();
                uCJob.JobName.Text = row["title"].ToString();
                uCJob.CompanyName.Text = row["company_name"].ToString();
                uCJob.Location.Text = row["location_name"].ToString();
                uCJob.Salary.Text = row["salary"].ToString();
                jobList.Add(uCJob);
            }
            this.uCHome.fillDataToPanel(jobList);
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
    }
}
