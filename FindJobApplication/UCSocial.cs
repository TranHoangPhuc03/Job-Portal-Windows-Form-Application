using FindJobApplication.Daos;
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

namespace FindJobApplication
{
    public partial class UCSocial : UserControl
    {
        public UCSocial()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        public PictureBox PBAvatar { get => pBAvatar; set => pBAvatar = value; }
        private void UCSocial_Load(object sender, EventArgs e)
        {
            //SocialPostDao socialPostDao = new SocialPostDao();
            //List<SocialPost> socialPosts = socialPostDao.FindAllSocialPost();
            //foreach (SocialPost socialPost in socialPosts)
            //{
            //    UCSocialPost uCSocial = new UCSocialPost(socialPost);
            //    pnlSocial.Controls.Add(uCSocial);
            //}
        }

        private void txtUpSocial_MouseClick(object sender, MouseEventArgs e)
        {
            FPostSocial fPostSocial = new FPostSocial();
            fPostSocial.FormClosed += this.UCSocial_Load;
            fPostSocial.Show();
        }
    }
}
