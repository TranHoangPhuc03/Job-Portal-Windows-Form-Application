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

namespace FindJobApplication
{
    public partial class UCSocialPost : UserControl
    {
        public event FillToMainPanelHandler FillToMainPanelClicked = UCPanelMain.UC_RequiredAddControl;

        AccountDao accountDao = new AccountDao();
        int accountId;
        public UCSocialPost()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public UCSocialPost(SocialPost socialPost) : this()
        {
            Account account = accountDao.FindAccountById(socialPost.AccountID);
            llblName.Text = account.Name;
            pbAvatar.Image = ImageUtils.FromBytesToImage(account.Avatar);
            lblDatePost.Text = socialPost.PostDate.ToString("dd-MM-yyyy");
            lblTitle.Text = socialPost.Title;
            rtxtDescription.Text = socialPost.Contents;
            foreach (Skill skill in socialPost.Skills)
            {
                UCSkillTag uCUserProfileSkill = new UCSkillTag(skill);
                this.pnlSkill.Controls.Add(uCUserProfileSkill);
            }
            Tag = socialPost.Id;
            if (socialPost.AccountID == Session.account.Id)
            {
                btnSendMail.Visible = false;
            }
            this.accountId = socialPost.AccountID;
        }

        public LinkLabel LlblName { get => llblName; }
        private void llblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string role = accountDao.FindAccountById(accountId).Role;
            if (accountId != Session.account.Id)
            {
                if (role == "user")
                {
                    UCProfile uCProfile = new UCProfile(accountId);
                    FillToMainPanelClicked?.Invoke(this, uCProfile);
                    uCProfile.hideAllBtn();
                    if (Session.account.Role == "user")
                    {
                        uCProfile.BtnFollow.Visible = false;
                    }
                }
                else
                {
                    UCCompanyProfile uCCompanyProfile = new UCCompanyProfile(accountId);
                    FillToMainPanelClicked?.Invoke(this, uCCompanyProfile);
                    uCCompanyProfile.hideAllButton();
                    if (Session.account.Role == "company")
                    {
                        uCCompanyProfile.BtnFollow.Visible = false;
                    }
                }

            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            Account account = accountDao.FindAccountById(accountId);
            FSendMail fSendMail = new FSendMail(account.Email);
            fSendMail.Show();
        }
    }
}
