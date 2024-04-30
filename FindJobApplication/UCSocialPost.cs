using FindJobApplication.Daos;
using FindJobApplication.Entities;
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
        public UCSocialPost()
        {
            InitializeComponent();
        }

        public UCSocialPost(object socialPost) : this()
        {
            //UserProfileDao userProfileDao = new UserProfileDao();
            //this.LlblName.Text = userProfileDao.FindUserProfileByAccountId(socialPost.AccountId).Name;
            //this.lblDatePost.Text = socialPost.PostDate.ToString("dd-MM-yyyy");
            //this.lblTitle.Text = socialPost.Title;
            //this.rtxtDescription.Text = socialPost.Contents;
            //foreach(Skill skill in socialPost.Skills)
            //{
            //    UCSkillTag uCUserProfileSkill = new UCSkillTag(skill);
            //    this.pnlSkill.Controls.Add(uCUserProfileSkill);
            //}
        }

        public Guna2Button BtnSendMail { get => btnSendMail; set => btnSendMail = value; }

        public FlowLayoutPanel PnlSkill { get => pnlSkill; set => pnlSkill = value; }
        public RichTextBox RtxtDescription { get => rtxtDescription; set => rtxtDescription = value; }

        public LinkLabel LlblName { get => llblName; }
        private void llblName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCProfile uCProfile = new UCProfile();
            UCMain.Instance.PnlMid.Controls.Add(uCProfile);
            uCProfile.hideAllBtn();
            uCProfile.BringToFront();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            FSendMail fSendMail = new FSendMail();
            fSendMail.Show();
        }
    }
}
