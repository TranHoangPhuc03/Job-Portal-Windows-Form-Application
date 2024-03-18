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
    public partial class FUserProfileInformationEdit : Form
    {
        public FUserProfileInformationEdit()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbUser_MouseEnter(object sender, EventArgs e)
        {
            pbUser.Image = Properties.Resources.camera;
        }

        private void pbUser_MouseLeave(object sender, EventArgs e)
        {
            pbUser.Image = Properties.Resources.user__1_;
        }
    }
}
