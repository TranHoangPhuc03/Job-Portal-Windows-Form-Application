using FindJobApplication.Entities;
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
using FindJobApplication.Utils;
namespace FindJobApplication
{
    public partial class UCMailDetail : UserControl
    {
        string filePath;
        string mailRecive;
        public UCMailDetail()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCMailDetail(Mail mail) : this()
        {
            Tag = mail;
            lblFrom.Text = mail.Account.Name;
            lblTo.Text= mail.Account1.Name;
            lblTitle.Text = mail.Title;
            rtxtLetter.Text = mail.Contents;
            if (mail.AttachFile != null && mail.AttachFile != "")
            {
                this.filePath = mail.AttachFile;
                string fileName = Path.GetFileName(mail.AttachFile);
                txtNameFile.Text = fileName;
                txtNameFile.Visible = true;
            }
            if (mail.Account1.Name == Session.account.Name)
            {
                mailRecive = mail.Account.Email;
            }
            else
            {
                mailRecive = mail.Account1.Email;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = this.Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                Dispose();
            }
        }

        private void btnResponse_Click(object sender, EventArgs e)
        {
            FSendMail fSendMail = new FSendMail(mailRecive);
            fSendMail.Show();
        }

        private void btnSeeCV_Click(object sender, EventArgs e)
        {
            if (txtNameFile.Text != "none")
            {
                FCompanySeeCV fCompanySeeCV = new FCompanySeeCV(filePath);
                fCompanySeeCV.Show();
            }
            else
            {
                MessageBox.Show("No file here!");
            }
        }
    }
}
