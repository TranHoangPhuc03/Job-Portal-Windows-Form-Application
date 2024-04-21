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
using FindJobApplication.Daos;
using Guna.UI2.WinForms;

namespace FindJobApplication
{
    public partial class UCJob : UserControl
    {
        int idJob;
        public UCJob()
        {
            InitializeComponent();
        }
        public UCJob(JobPost jobPost, List<Skill> skills) : this()
        {
            this.idJob = jobPost.Id;
            LocationDao locationDao = new LocationDao();
            var locationDict = locationDao.FindAllLocationDict();
            this.JobName.Text = standardizeNames(jobPost.Title);
            this.CompanyName.Text = jobPost.CompanyName;
            this.Location.Text = locationDict[jobPost.LocationId].Name;
            this.Salary.Text = jobPost.Salary.ToString();
            this.Tag = jobPost;
            this.LLblNameJob.Tag = jobPost.Id;
            this.CompanyName.Tag = jobPost.CompanyId;
            foreach (Skill skill in skills)
            {
                UCSkillTag uCSkillTag = new UCSkillTag(skill);
                this.pnlSkill.Controls.Add(uCSkillTag);

                if (this.pnlSkill.PreferredSize.Width > this.pnlSkill.Width)
                {
                    this.pnlSkill.Controls.RemoveAt(this.pnlSkill.Controls.Count - 1);

                    Label etc = new Label();
                    etc.Font = new System.Drawing.Font("Inter", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
                    etc.Text = "...";
                    etc.Height = 28;
                    this.pnlSkill.Controls.Add(etc);
                }
            }
            if (isFavouriteJob(jobPost.Id)) btnSave.Checked = true;
        }

        public new GunaLinkLabel LLblNameJob { get => lLblNameJob; set { lLblNameJob = value; } }
        public GunaLinkLabel JobName { get => lLblNameJob; set { lLblNameJob = value; } }
        public new GunaLinkLabel CompanyName { get => lblNameCompany; set { lblNameCompany = value; } }
        public new Label Location { get => lblLocation; set { lblLocation = value; } }
        public Label Salary { get => lblSalary; set { lblSalary = value; } }
        public FlowLayoutPanel PnlSkill { get => pnlSkill; set => pnlSkill = value; }
        public Guna2PictureBox PBCompany { get => pBCompany; set => pBCompany = value; }
        public Guna2ImageCheckBox BtnSave { get => btnSave; set => btnSave = value; }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FUserSubmitCV fUserSubmitCV = new FUserSubmitCV((JobPost)this.Tag);
            fUserSubmitCV.Show();
        }

        private void lLblNameJob_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCJobInformation uCJobInformation = new UCJobInformation((int)(sender as Control).Tag);
            FHome.Instance.PnlMain.Controls.Add(uCJobInformation);
            uCJobInformation.BringToFront();
        }

        private void lblNameCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCCompanyProfile uCCompanyProfile = new UCCompanyProfile((int)(sender as Control).Tag);
            FHome.Instance.PnlMain.Controls.Add(uCCompanyProfile);
            uCCompanyProfile.hideAllButton();
            uCCompanyProfile.BringToFront();
        }
        public string standardizeNames(string name)
        {
            if (name.Length <= 16)
            {
                return name;
            }
            else
            {
                return name.Substring(0, 14) + "...";
            }
        }

        private void btnSave_CheckedChanged(object sender, EventArgs e)
        {
            UserProfileDao userProfileDao = new UserProfileDao();

            if (btnSave.Checked == true)
            {
                if (!isFavouriteJob(idJob))
                {
                    userProfileDao.SaveNewFavouriteJob(idJob, Session.accountId);
                }
            }
            else
            {
                if (isFavouriteJob(idJob))
                {
                    userProfileDao.DeleteFavouriteJob(idJob, Session.accountId);
                }
            }
        }
        private bool isFavouriteJob(int jobId)
        {
            UserProfileDao userProfileDao = new UserProfileDao();
            List<int> jobIds = userProfileDao.FindAllJobPostIdFavourite(Session.accountId);
            foreach (int idJob in jobIds)
            {
                if (idJob == jobId)
                    return true;
            }
            return false;
        }
    }
}
