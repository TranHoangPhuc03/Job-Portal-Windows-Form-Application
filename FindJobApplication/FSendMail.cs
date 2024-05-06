using FindJobApplication.Daos;
using FindJobApplication.Entities;
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
using System.IO;
namespace FindJobApplication
{
    public partial class FSendMail : Form
    {
        MailDao mailDao = new MailDao();
        AccountDao accountDao = new AccountDao();
        string emailSend = Session.account.Email;
        string emailRecive;
        string filePath;
        public FSendMail()
        {
            InitializeComponent();
            txtEmailFrom.Text = emailSend;
        }
        public FSendMail(string emailRecive) : this()
        {
            this.emailRecive = emailRecive;
            txtEmailFrom.Text = emailSend;
            txtEmailTo.Text = emailRecive;
            txtEmailTo.Enabled = false;
        }
        private void btnSendMail_Click(object sender, EventArgs e)
        {

            string emailFrom = txtEmailFrom.Text;
            string emailTo = txtEmailTo.Text;

            if (emailFrom.Equals(emailTo))
            {
                MessageDialog.Show(this, "Email sender and receiver must be different");
                return;
            }

            if (accountDao.FindAccountByEmail(emailFrom) is null)
            {
                MessageDialog.Show(this, "Your email from does not exits");
                return;
            }

            if (accountDao.FindAccountByEmail(emailTo) is null)
            {
                MessageDialog.Show(this, "Your email to does not exits");
                return;
            }

            string title = !string.IsNullOrEmpty(txtTitle.Text) ? txtTitle.Text : "Empty title";
            string contents = rtxtCoverLeter.Text;

            Mail mail = new Mail()
            {
                FromId = accountDao.FindAccountByEmail(emailFrom).Id,
                ToId = accountDao.FindAccountByEmail(emailTo).Id,
                Title = title,
                Contents = contents,
                SendDate = DateTime.Now,
                AttachFile =  this.filePath

            };

            int result = mailDao.SaveNewMail(mail);
            if (result > 0)
            {
                MessageDialog.Show(this, "Email send successfully");
                Close();
            }
            else
            {
                MessageDialog.Show(this, "Email send failed");
            }
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

    }
}
