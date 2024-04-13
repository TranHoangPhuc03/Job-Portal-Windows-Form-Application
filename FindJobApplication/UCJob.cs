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
        public int count = 0;
        public UCJob()
        {
            InitializeComponent();
            pbSave.BringToFront();
        }

        public UCJob(JobPost jobPost) : this()
        {
            LocationDao locationDao = new LocationDao();
            var locationDict = locationDao.FindAllLocationDict();
            this.JobName.Text = standardizeNames(jobPost.Title);
            this.CompanyName.Text = jobPost.CompanyName;
            this.Location.Text = locationDict[jobPost.LocationId].Name;
            this.Salary.Text = jobPost.Salary.ToString();
            this.Tag = jobPost;
            this.LLblNameJob.Tag = jobPost.Id;
            this.CompanyName.Tag = jobPost.CompanyId;
        }

        public new GunaLinkLabel LLblNameJob { get => lLblNameJob; set { lLblNameJob = value; } }
        public GunaLinkLabel JobName { get => lLblNameJob; set { lLblNameJob = value; } }
        public new GunaLinkLabel CompanyName { get => lblNameCompany; set { lblNameCompany = value; } }
        public new Label Location { get => lblLocation; set { lblLocation = value; } }
        public Label Salary { get => lblSalary; set { lblSalary = value; } }
        public FlowLayoutPanel PnlSkill { get => pnlSkill; set => pnlSkill = value; }
        public Guna2PictureBox PBCompany { get => pBCompany; set => pBCompany = value; }
        public PictureBox PbSave { get => pbSave; }

        private void pbSave_Click(object sender, EventArgs e)
        {
            if (count%2 == 0)
            {
                count++;
                pbSave.Image = Properties.Resources.heart2;

            }
            else
            {
                count++;
                pbSave.Image = Properties.Resources.like;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            FUserSubmitCV fUserSubmitCV = new FUserSubmitCV((JobPost)this.Tag);
            fUserSubmitCV.Show();
        }

        private void lLblNameJob_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCJobInformation uCJobInformation = new UCJobInformation((int)(sender as Control).Tag);
            UCMain.Instance.PnlMid.Controls.Add(uCJobInformation);
            uCJobInformation.Location = new Point(UCMain.Instance.PnlMid.Width / 2 - uCJobInformation.Width / 2, 0);
            uCJobInformation.BringToFront();
        }

        private void lblNameCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCCompanyProfile uCCompanyProfile = new UCCompanyProfile((int)(sender as Control).Tag);
            UCMain.Instance.PnlMid.Controls.Add(uCCompanyProfile);
            uCCompanyProfile.hideAllButton();
            uCCompanyProfile.Location = new Point(UCMain.Instance.PnlMid.Width / 2 - uCCompanyProfile.Width / 2, 0);
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

    }
}
