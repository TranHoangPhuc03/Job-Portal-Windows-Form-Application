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

        UCUCUserProfileEducationAndWorkExperience uCEduaction = new UCUCUserProfileEducationAndWorkExperience();
        UCUCUserProfileEducationAndWorkExperience uCWorkExperience = new UCUCUserProfileEducationAndWorkExperience();
        UCUserProfileSkill uCUserProfileSkill = new UCUserProfileSkill();
        UCUserProfileProject uCUserProfileProject = new UCUserProfileProject();

        public UCProfile()
        {
            InitializeComponent();
            panelProfile.AutoScroll = true;
            loadProfile();
            btnBack.Visible = false;
        }
        public void loadProfile()
        {
            pnlEducationDetail.Controls.Add(uCEduaction);
            pnlWorkExperienceDetail.Controls.Add(uCWorkExperience);
            pnlSkillDetail.Controls.Add(uCUserProfileSkill);
            pnlProjectDetail.Controls.Add(uCUserProfileProject);
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
            this.Hide();
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            if (statusBtnFollowUser == 1)
            {
                btnFollow.Image = Properties.Resources.unFollow;
                btnFollow.Text = "Following";
                statusBtnFollowUser = 2;
            }
            else
            {
                btnFollow.Image = Properties.Resources.Follow;
                btnFollow.Text = "Follow";
                statusBtnFollowUser = 1;
            }
        }
    }
}
