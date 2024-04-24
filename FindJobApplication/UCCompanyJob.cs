using FindJobApplication.Daos;
using FindJobApplication.Models;
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

namespace FindJobApplication
{
    public partial class UCCompanyJob : UserControl
    {
        public UCCompanyJob()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public UCCompanyJob(JobPost jobPost, int id, int nApplicants) : this()
        {
            lblId.Text = id.ToString();
            lblNameJob.Text = jobPost.Title;
            lblPostDate.Text = jobPost.PostDate.ToString("dd-MM-yyyy");
            lblExpirationDate.Text = jobPost.ExpireDate.ToString("dd-MM-yyyy");
            lblSalary.Text = jobPost.Salary.ToString();
            lblCountApplied.Text = nApplicants.ToString();
            this.Tag = jobPost.Id;
        }
        public Label LblID { get => lblId; set => lblId = value; }
        public Label LblNameJob { get => lblNameJob; set => lblNameJob = value; }
        public Label LblPostDate { get => lblPostDate; set => lblPostDate = value; }
        public Label LblExpirationDate { get => lblExpirationDate; set => lblExpirationDate = value; }
        public Label LblSalary { get => lblSalary; set => lblSalary = value; }
        public GunaLinkLabel LblCountApplied { get => lblCountApplied; set => lblCountApplied = value; }
        private void lblCountApplied_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCCompanyListPeopleApply uCCompanyListPeopleApply = new UCCompanyListPeopleApply((int)this.Tag);
            UCMain.Instance.PnlMid.Controls.Add(uCCompanyListPeopleApply);
            uCCompanyListPeopleApply.Location = new Point(UCMain.Instance.PnlMid.Width / 2 - uCCompanyListPeopleApply.Width / 2, 0);
            uCCompanyListPeopleApply.BringToFront();
        }

        private void pbEdit_Click(object sender, EventArgs e)
        {
            FCompanyJobEdit fCompanyJobEdit = new FCompanyJobEdit((int)this.Tag);
            fCompanyJobEdit.ShowDialog();
        }

        private void pBDelete_Click(object sender, EventArgs e)
        {
            int jobPostId = (int)this.Tag;
            JobPostDao jobPostDao = new JobPostDao();
            int result = jobPostDao.DeleteJobPostById(jobPostId);
            if (result  > 0)
            {
                MessageDialog.Show(this.ParentForm, "Delete recruitment post successfull", "Succes", MessageDialogButtons.OK, MessageDialogIcon.Information, MessageDialogStyle.Default);
            }
            else
            {
                MessageDialog.Show(this.ParentForm, "Delete recruitment post failed", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Default);
            }
        }
    }
}
