using FindJobApplication.Daos;
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
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FPostSocial : Form
    {
        public FPostSocial()
        {
            InitializeComponent();
        }
        public Guna2Button BtnPost { get => btnPost; set => btnPost = value; }
        private void btnPost_Click(object sender, EventArgs e)
        {
            //List<Skill> list = new List<Skill>();
            //foreach (Control control in this.pnlSkill.Controls)
            //{
            //    list.Add(control.Tag as Skill);
            //}
            //SocialPost socialPost = new SocialPost(
            //    this.txtTitle.Text,
            //    DateTime.Now,
            //    this.rtxtStatus.Text,
            //    Session.account.Id,
            //    list
            //);
            //SocialPostDao socialPostDao = new SocialPostDao();
            //int result = socialPostDao.SaveNewSocialPost(socialPost);
            //if (result > 0)
            //{
            //    MessageDialog.Show(this, "Post success");
            //}
            //else
            //{
            //    MessageDialog.Show(this, "Post failed");
            //}

            //this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void FPostSocial_Load(object sender, EventArgs e)
        {
            SkillDao skillDao = new SkillDao();
            this.cbSkill.ValueMember = "id";
            this.cbSkill.DisplayMember = "name";
            this.cbSkill.DataSource = skillDao.FindAllSkill();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
