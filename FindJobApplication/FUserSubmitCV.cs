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

namespace FindJobApplication
{
    public partial class FUserSubmitCV : Form
    {
        private int jobId;
        public FUserSubmitCV(JobPost jobPost)
        {
            InitializeComponent();
            this.lblNameJob.Text = jobPost.Title;
            this.jobId = jobPost.Id;
        }

        private void btnSendCv_Click(object sender, EventArgs e)
        {
            //JobApplyDao jobApplyDao = new JobApplyDao();
            //string coverLetter = this.rtxtCoverLeter.Text;
            //string status = "PENDING";
            //DateTime appliedAt = DateTime.Now;
            //if (this.rbtnNewCv.Checked)
            //{
            //    //Get cv file path
            //}
            //int res = jobApplyDao.SaveUserApplyJob(appliedAt, Session.account.Id, this.jobId, status, coverLetter);
            //if (res > 0)
            //{
            //    MessageDialog.Show(this, "You applied succesfully", "Success", MessageDialogButtons.OK, MessageDialogStyle.Light);
            //    this.Close();
            //}
            //else
            //{
            //    MessageDialog.Show(this, "You applied unsuccessfully", "Error", MessageDialogButtons.OK, MessageDialogIcon.Error, MessageDialogStyle.Light);
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
