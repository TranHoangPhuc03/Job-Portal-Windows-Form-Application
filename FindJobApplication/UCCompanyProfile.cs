using FindJobApplication.Daos;
using FindJobApplication.Entities;
using FindJobApplication.Utils;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UCCompanyProfile : UserControl
    {
        private int companyId;
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;
        CompanyProfileDao companyProfileDao = new CompanyProfileDao();
        CompanyProfile companyProfile = null;
        public UCCompanyProfile()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            tableLayoutPanel1.HorizontalScroll.Maximum = 0;
            tableLayoutPanel1.AutoScroll = false;
            tableLayoutPanel1.VerticalScroll.Visible = false;
            tableLayoutPanel1.AutoScroll = true;
        }
        public Guna2Button BtnFollow { get => btnFollow; set => btnFollow = value; }
        public UCCompanyProfile(int companyId) : this()
        {
            this.companyId = companyId;
            companyProfile = companyProfileDao.FindCompanyProfileByAccountId(companyId);
        }

        public void hideAllButton()
        {
            btnBack.Visible = true;
            btnFollow.Visible = true;
            btnInbox.Visible = true ;
            pbProfileEdit.Visible = false;
            pbTop3Edit.Visible = false;
            pBCompanyOverviewEdit.Visible = false;
        }

        private void pbProfileEdit_Click(object sender, EventArgs e)
        {
            FCompanyProfileInfomationEdit fCompanyProfileInfomationEdit = new FCompanyProfileInfomationEdit(companyProfile);
            fCompanyProfileInfomationEdit.FormClosed += UCCompanyProfile_Load;
            fCompanyProfileInfomationEdit.Show();
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            AccountDao accountDao = new AccountDao();
            if (Session.account.Id != companyId)
            {
                btnFollow.Visible = true;
                btnInbox.Visible = true;
            }
            if (btnFollow.Text == "Unfollow")
            {
                btnFollow.Text = "Follow";
                accountDao.DeleteAccountFollowing(Session.account.Id, companyId);
            }
            else
            {
                btnFollow.Text = "Unfollow";
                accountDao.SaveNewAccountFollowed(Session.account.Id, companyId);
            }
        }

        private void UCCompanyProfile_Load(object sender, EventArgs e)
        {
            CompanyProfileDao companyProfileDao = new CompanyProfileDao();
            CompanyProfile companyProfile = companyProfileDao.FindCompanyProfileByAccountId(this.companyId);
            JobPostDao jobPostDao = new JobPostDao();   
            int cnt = jobPostDao.FindAllJobPostByCompanyId(this.companyId).Count;
            pbProfileAvatar.Image = ImageUtils.FromBytesToImage(companyProfile.Account.Avatar);
            lblCountJob.Text = cnt.ToString();
            lblProfileCompany.Text = companyProfile.Account.Name;
            lblProfileAddress.Text = companyProfile.Address;
            lblProfileCompanySize.Text = companyProfile.CompanySize.ToString();
            lblProfilePhone.Text = companyProfile.PhoneNumber;
            lblProfileDateEstablish.Text = companyProfile.DateEstablish?.ToString("dd-MM-yyyy");
            lblProfileEmail.Text = companyProfile.Account.Email;
            lblProfileLink.Text = companyProfile.CompanyLink;
            rtxtTop3Reason.Text = companyProfile.Reason;
            rTxtOverview.Text = companyProfile.Overview;
            ChangeButtonFollowState();
        }

        private void pbTop3Edit_Click(object sender, EventArgs e)
        {
            FCompanyProfileTop3Reasons fCompanyProfileTop3Reasons = new FCompanyProfileTop3Reasons(companyProfile);
            fCompanyProfileTop3Reasons.Show();
        }

        private void pBCompanyOverviewEdit_Click(object sender, EventArgs e)
        {
            FCompanyProfileOverviewEdit fCompanyProfileOverviewEdit = new FCompanyProfileOverviewEdit(companyProfile);
            fCompanyProfileOverviewEdit.Show();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            CompanyProfileDao companyProfileDao = new CompanyProfileDao();
            CompanyProfile companyProfile = companyProfileDao.FindCompanyProfileByAccountId(companyId);
            FSendMail fSendMail = new FSendMail(companyProfile.Account.Email);
            fSendMail.Show();
        }

        private void btnSeeJob_Click(object sender, EventArgs e)
        {
            UCCompanyJobRecruitment uCCompanyJobRecruitment = new UCCompanyJobRecruitment(companyProfile);
            FillToMainPanelClicked?.Invoke(this, uCCompanyJobRecruitment);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = this.Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                this.Dispose();
            }
        }
        public void ChangeButtonFollowState()
        {
            AccountDao accountDao = new AccountDao();
            if (accountDao.FindAccountById(Session.account.Id).Account1.Any(row => row.Id == companyId))
            {
                btnFollow.Text = "Unfollow";
            }
            else
            {
                btnFollow.Text = "Follow";
            }
        }
    }
}
