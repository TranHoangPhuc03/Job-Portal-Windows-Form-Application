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
    public partial class FUserProfileSkillsEdit : Form
    {
        UserProfileDao userProfileDao = new UserProfileDao();
        UserProfile userProfile = null;
        public FUserProfileSkillsEdit()
        {
            InitializeComponent();
        }

        public FUserProfileSkillsEdit(Account account) : this()
        {
            userProfile = userProfileDao.FindUserProfileByAccountId(account.Id);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UCSkillTag uCSkillTag = new UCSkillTag(new Skill()
            {
                Id = (int)cbSkill.SelectedValue,
                Name = cbSkill.Text
            });
            uCSkillTag.ChangeButtonDeleteState();
            pnlSkill.Controls.Add(uCSkillTag);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            userProfileDao.DeleteAllUserSkills(userProfile);
            foreach (Control c in pnlSkill.Controls)
            {
                userProfile.Skills.Add(c.Tag as Skill);
            }
            int result = userProfileDao.UpdateUserProfile(userProfile);
            if (result == 0)
            {
                MessageDialog.Show(this, "Update failed");
            }
            else
            {
                MessageDialog.Show(this, "Update successfully");
                UCUserSubMenuRight uCUserSubMenuRight = new UCUserSubMenuRight();
                uCUserSubMenuRight.btnProfile_Click(sender, e);
                Close();
            }
        }

        private void FUserProfileSkillsEdit_Load(object sender, EventArgs e)
        {
            skillTableAdapter.Fill(skillDataSet.Skill);
            foreach(Skill skill in userProfile.Skills)
            {
                UCSkillTag uCSkillTag = new UCSkillTag(skill);
                uCSkillTag.ChangeButtonDeleteState();
                pnlSkill.Controls.Add(uCSkillTag);
            }
        }
    }
}
