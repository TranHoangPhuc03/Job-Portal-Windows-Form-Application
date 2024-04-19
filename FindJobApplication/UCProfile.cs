using FindJobApplication.Daos;
using FindJobApplication.Models;
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
    public partial class UCProfile : UserControl
    {
        public static int statusBtnFollowUser = 1;
        private int userId;
        UCUCUserProfileEducationAndWorkExperience uCEduaction = new UCUCUserProfileEducationAndWorkExperience();
        UCUCUserProfileEducationAndWorkExperience uCWorkExperience = new UCUCUserProfileEducationAndWorkExperience();
        UCUserProfileSkill uCUserProfileSkill = new UCUserProfileSkill();
        UCUserProfileProject uCUserProfileProject = new UCUserProfileProject();

        public UCProfile()
        {
            InitializeComponent();
            panelProfile.AutoScroll = true;
            btnBack.Visible = false;
            this.userId = Session.accountId;
        }

        public UCProfile(int userId) : this()
        {
            this.userId = userId;
        }

        public void hideAllBtn()
        {
            btnBack.Visible = true;
            btnFollow.Visible = true;

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

            uCUserProfileProject.pbDeleteProject.Visible = false;
            uCUserProfileProject.pbEditProject.Visible = false;

        }
        public Panel panelProfile { get => pnlProfile; }

        private void pbProfileEdit_Click(object sender, EventArgs e)
        {
            FUserProfileInformationEdit fUserProfileInformationEdit = new FUserProfileInformationEdit();
            fUserProfileInformationEdit.Show();
        }

        private void pbIntroductionEdit_Click(object sender, EventArgs e)
        {
            FUserProfileIntroductionEdit fUserProfileIntroductionEdit = new FUserProfileIntroductionEdit();
            fUserProfileIntroductionEdit.Show();
        }

        private void pbEducationEdit_Click(object sender, EventArgs e)
        {
            FUserProfileEducationEdit fUserProfileEducationEdit = new FUserProfileEducationEdit();
            fUserProfileEducationEdit.Show();
        }

        private void pbWorkExperienceEdit_Click(object sender, EventArgs e)
        {
            FUserProfileWorkExperienceEdit fUserProfileWorkExperienceEdit = new FUserProfileWorkExperienceEdit();
            fUserProfileWorkExperienceEdit.Show();
        }

        private void pbSkillsEdit_Click(object sender, EventArgs e)
        {
            FUserProfileSkillsEdit fUserProfileSkillsEdit = new FUserProfileSkillsEdit();   
            fUserProfileSkillsEdit.Show();
        }

        private void pbPersonalProjectEdit_Click(object sender, EventArgs e)
        {
            FUserProfilePersonalProjectEdit fUserProfilePersonalProjectEdit = new FUserProfilePersonalProjectEdit();
            fUserProfilePersonalProjectEdit.Show();
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

        private void btnFollow_Click(object sender, EventArgs e)
        {
            if (statusBtnFollowUser == 1)
            {
                btnFollow.Text = "Following";
                statusBtnFollowUser = 2;
            }
            else
            {
                btnFollow.Text = "Follow";
                statusBtnFollowUser = 1;
            }
        }

        private void UCProfile_Load(object sender, EventArgs e)
        {
            UserProfileDao userProfileDao = new UserProfileDao();
            UserProfile userProfile = userProfileDao.FindUserProfileById(this.userId);

            this.lblProfileName.Text = userProfile.Name;
            this.lblProfileEmail.Text = userProfile.Email;
            this.lblProfileGender.Text = userProfile.Gender;
            this.lblProfileDateOfBirth.Text = userProfile.DateOfBirth.ToString();
            this.lblProfilePhoneNumber.Text = userProfile.PhoneNumber;
            this.lblProfileAddress.Text = userProfile.Address;
            this.lblProfileTitle.Text = userProfile.Title;
            this.lblProfileLink.Text = userProfile.PersonalLink;
            this.rtxtAboutMe.Text = userProfile.AboutMe;
            this.pnlEducationDetail.Controls.Clear();
            foreach (var item in userProfile.UserEducations)
            {
                UCUCUserProfileEducationAndWorkExperience uCUCUserProfileEducationAndWorkExperience = new UCUCUserProfileEducationAndWorkExperience(item);
                this.pnlEducationDetail.Controls.Add(uCUCUserProfileEducationAndWorkExperience);
            }
            foreach (var item in userProfile.UserWorkExperiences)
            {
                UCUCUserProfileEducationAndWorkExperience uCUCUserProfileEducationAndWorkExperience = new UCUCUserProfileEducationAndWorkExperience(item);
                this.pnlWorkExperienceDetail.Controls.Add(uCUCUserProfileEducationAndWorkExperience);
            }
            foreach (var item in userProfile.UserSkills)
            {
                UCUserProfileSkill uCUserProfileSkill = new UCUserProfileSkill(item);
                this.pnlSkillDetail.Controls.Add(uCUserProfileSkill);
            }
            foreach(var item in userProfile.UserPersonalProjects)
            {
                UCUserProfileProject uCUserProfileProject = new UCUserProfileProject(item);
                this.pnlProjectDetail.Controls.Add(uCUserProfileProject);
            }
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            FSendMail fSendMail = new FSendMail();
            fSendMail.Show();
        }
    }
}
