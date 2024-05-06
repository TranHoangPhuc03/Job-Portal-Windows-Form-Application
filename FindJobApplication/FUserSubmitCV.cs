using FindJobApplication.Daos;
using FindJobApplication.Utils;
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
using FindJobApplication.Entities;
using System.IO;

namespace FindJobApplication
{
    public partial class FUserSubmitCV : Form
    {
        private int jobId;
        string filePath = "";
        public FUserSubmitCV()
        {
            InitializeComponent();
        }

        public FUserSubmitCV(JobPost jobPost) : this()
        {
            lblNameJob.Text = jobPost.Title;
            jobId = jobPost.Id;
        }

        private void btnSendCv_Click(object sender, EventArgs e)
        {
            JobApplyDao jobApplyDao = new JobApplyDao();
            string coverLetter = rtxtCoverLeter.Text;
            DateTime appliedAt = DateTime.Now;
            UserApplyJob userApplyJob = new UserApplyJob()
            {
                UserId = Session.account.Id,
                JobPostId = jobId,
                CoverLetter = coverLetter,
                AppliedAt = appliedAt,
                StatusId = (int)StatusName.Pending + 1,
                CvAttachment = filePath
            };
            int result = jobApplyDao.SaveUserApplyJob(userApplyJob);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.filePath = openFileDialog1.FileName;
                string fileName = Path.GetFileName(filePath);

                txtNameFile.Text = fileName;
                txtNameFile.Visible = true;
            }
        }

        private void rbtnNewCv_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNewCv.Checked)
            {
                btnChooseFile.Enabled = true;
            }
        }

        private void rBtnCurrentCv_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCurrentCv.Checked)
            {
                btnChooseFile.Enabled = false;
            }
        }
    }
}
