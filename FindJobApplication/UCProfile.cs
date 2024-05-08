using FindJobApplication.Daos;
using FindJobApplication.Entities;
using FindJobApplication.Utils;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindJobApplication
{

    public partial class UCProfile : UserControl
    {

        int userId = 0;
        private UserProfile userProfile;
        private UserProfileDao userProfileDao = new UserProfileDao();
        UCUCUserProfileEducationAndWorkExperience uCEduaction = new UCUCUserProfileEducationAndWorkExperience();
        UCUCUserProfileEducationAndWorkExperience uCWorkExperience = new UCUCUserProfileEducationAndWorkExperience();
        UCSkillTag uCUserProfileSkill = new UCSkillTag();
        UCUserProfileProject uCUserProfileProject = new UCUserProfileProject();

        public UCProfile()
        {
            InitializeComponent();
            btnBack.Visible = false;
            Dock = DockStyle.Fill;
            pnlProfile.HorizontalScroll.Maximum = 0;
            pnlProfile.AutoScroll = false;
            pnlProfile.VerticalScroll.Visible = true;
            pnlProfile.AutoScroll = true;
        }
        public Guna2Button BtnFollow { get => btnFollow; set => btnFollow = value; }
        public UCProfile(int userId) : this()
        {
            this.userId = userId;
            userProfile = userProfileDao.FindUserProfileByAccountId(userId);
        }

        private void pbProfileEdit_Click(object sender, EventArgs e)
        {
            FUserProfileInformationEdit fUserProfileInformationEdit = new FUserProfileInformationEdit(userProfile.Account);
            fUserProfileInformationEdit.Show();
        }

        private void pbIntroductionEdit_Click(object sender, EventArgs e)
        {
            FUserProfileIntroductionEdit fUserProfileIntroductionEdit = new FUserProfileIntroductionEdit(userProfile.Account);
            fUserProfileIntroductionEdit.Show();
        }

        private void pbEducationEdit_Click(object sender, EventArgs e)
        {
            FUserProfileEducationEdit fUserProfileEducationEdit = new FUserProfileEducationEdit(userProfile.Account);
            fUserProfileEducationEdit.Show();
        }

        private void pbWorkExperienceEdit_Click(object sender, EventArgs e)
        {
            FUserProfileWorkExperienceEdit fUserProfileWorkExperienceEdit = new FUserProfileWorkExperienceEdit(userProfile.Account);
            fUserProfileWorkExperienceEdit.Show();
        }

        private void pbSkillsEdit_Click(object sender, EventArgs e)
        {
            FUserProfileSkillsEdit fUserProfileSkillsEdit = new FUserProfileSkillsEdit(userProfile.Account);   
            fUserProfileSkillsEdit.Show();
        }

        private void pbPersonalProjectEdit_Click(object sender, EventArgs e)
        {
            FUserProfilePersonalProjectEdit fUserProfilePersonalProjectEdit = new FUserProfilePersonalProjectEdit(userProfile.Account);
            fUserProfilePersonalProjectEdit.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                Dispose();
            }
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            AccountDao accountDao = new AccountDao();
            if (Session.account.Id != userId)
            {
                btnFollow.Visible = true;
                btnInbox.Visible = true;
            }
            if (btnFollow.Text == "Unfollow")
            {
                btnFollow.Text = "Follow";
                accountDao.DeleteAccountFollowing(Session.account.Id, userId);
            }
            else
            {
                btnFollow.Text = "Unfollow";
                accountDao.SaveNewAccountFollowed(Session.account.Id, userId);
            }
        }

        public void UCProfile_Load(object sender, EventArgs e)
        {
            pbProfileAvatar.Image = ImageUtils.FromBytesToImage(userProfile.Account.Avatar);
            lblProfileName.Text = userProfile.Account.Name;
            lblProfileTitle.Text = userProfile.Title;
            lblProfileEmail.Text = userProfile.Account.Email;
            lblProfileGender.Text = userProfile.Gender;
            lblProfileDateOfBirth.Text = (userProfile.DateOfBirth ?? DateTime.Now).ToString("dd-MM-yyyy");
            lblProfilePhoneNumber.Text = userProfile.PhoneNumber;
            lblProfileAddress.Text = userProfile.Address;
            lblProfileTitle.Text = userProfile.Title;
            lblProfileLink.Text = userProfile.PersonalLink;
            rtxtAboutMe.Text = userProfile.AboutMe;
            pnlEducationDetail.Controls.Clear();
            foreach (var item in userProfile.UserEducations)
            {
                UCUCUserProfileEducationAndWorkExperience uCUCUserProfileEducationAndWorkExperience = new UCUCUserProfileEducationAndWorkExperience(userProfile.Account, item);
                pnlEducationDetail.Controls.Add(uCUCUserProfileEducationAndWorkExperience);
            }
            foreach (var item in userProfile.UserWorkExperiences)
            {
                UCUCUserProfileEducationAndWorkExperience uCUCUserProfileEducationAndWorkExperience = new UCUCUserProfileEducationAndWorkExperience(userProfile.Account, item);
                pnlWorkExperienceDetail.Controls.Add(uCUCUserProfileEducationAndWorkExperience);
            }
            foreach (var item in userProfile.Skills)
            {
                UCSkillTag uCUserProfileSkill = new UCSkillTag(item);
                pnlSkillDetail.Controls.Add(uCUserProfileSkill);
            }
            foreach(var item in userProfile.UserPersonalProjects)
            {
                UCUserProfileProject uCUserProfileProject = new UCUserProfileProject(userProfile.Account, item);
                pnlProjectDetail.Controls.Add(uCUserProfileProject);
            }
            ChangeButtonFollowState();
        }
        private void btnInbox_Click(object sender, EventArgs e)
        {
            userProfile = userProfileDao.FindUserProfileByAccountId(userId);
            FSendMail fSendMail = new FSendMail(userProfile.Account.Email);
            fSendMail.Show();
        }
        public void hideAllBtn()
        {
            btnBack.Visible = true;
            btnFollow.Visible = true;
            btnInbox.Visible = true;
            pbEducationEdit.Visible = false;
            pbIntroductionEdit.Visible = false;
            pbPersonalProjectEdit.Visible = false;
            pbProfileEdit.Visible = false;
            pbSkillsEdit.Visible = false;
            pbWorkExperienceEdit.Visible = false;

            uCEduaction.pbDeleteEducationOrWork.Visible = false;
            uCEduaction.pbEditEducationOrWork.Visible = false;

            uCWorkExperience.pbDeleteEducationOrWork.Visible = false;
            uCWorkExperience.pbEditEducationOrWork.Visible = false;
        }
        public void ChangeButtonFollowState()
        {
            AccountDao accountDao = new AccountDao();
            if (accountDao.FindAccountById(Session.account.Id).Account1.Any(row => row.Id == userId)) {
                btnFollow.Text = "Unfollow";
            }
            else
            {
                btnFollow.Text = "Follow";
            }
        }
    }
}
