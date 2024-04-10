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
        }
        public PictureBox PBAvatar { get => pBAvatar; set => pBAvatar = value; }
        private void UCSocial_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                UCSocialPost uCSocial = new UCSocialPost();
                for (int j = 0; j < 5; j++) 
                {
                    UCUserProfileSkill skill = new UCUserProfileSkill();
                    uCSocial.PnlSkill.Controls.Add(skill);
                }
                pnlSocial.Controls.Add(uCSocial);
            }
        }

        private void txtUpSocial_MouseClick(object sender, MouseEventArgs e)
        {
            FPostSocial fPostSocial = new FPostSocial();
            fPostSocial.Show();
        }
    }
}
