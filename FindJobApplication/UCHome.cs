using Guna.UI.WinForms;
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
using FindJobApplication.Models;
using FindJobApplication.Daos;

namespace FindJobApplication
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }
        
        public Guna2TextBox TxtSeach { get { return txtSearch; } }
        public GunaComboBox CbLocation { get { return cbLocation; } }
        public GunaComboBox CbExperince { get { return cbExperience; } }
        public Guna2Button BtnSearch { get { return btnSearch; } }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        public void fillJobPostToPanel(List<JobPost> jobPosts)
        {
            this.pnlListJob.Controls.Clear();
            this.pnlListJob.SuspendLayout();
            SkillDao skillDao = new SkillDao();
            List<Skill> skills = skillDao.FindAllSkill();

            foreach (JobPost jobPost in jobPosts)
            {
                List<Skill> filteredSkill = new List<Skill>();
                foreach(int skillId in jobPost.SkillID)
                {
                    filteredSkill.Add(skills.FirstOrDefault(o => o.Id == skillId));
                }
                UCJob uCJob = new UCJob(jobPost, filteredSkill);
                this.pnlListJob.Controls.Add(uCJob);
            }
            this.pnlListJob.ResumeLayout();
        }
    }
}
