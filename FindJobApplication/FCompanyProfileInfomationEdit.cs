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
    public partial class FCompanyProfileInfomationEdit : Form
    {
        public FCompanyProfileInfomationEdit()
        {
            InitializeComponent();
        }

        private void pbCompany1_MouseLeave(object sender, EventArgs e)
        {
            pbCompany1.Image = Properties.Resources.VanPhong;
        }

        private void pbCompany1_MouseEnter(object sender, EventArgs e)
        {
            pbCompany1.Image = Properties.Resources.camera;

        }
        private void pbCompany2_MouseLeave(object sender, EventArgs e)
        {
            pbCompany2.Image = Properties.Resources.VanPhong;
        }

        private void pbCompany2_MouseEnter(object sender, EventArgs e)
        {
            pbCompany2.Image = Properties.Resources.camera;

        }
        private void pbCompany3_MouseLeave(object sender, EventArgs e)
        {
            pbCompany3.Image = Properties.Resources.VanPhong;
        }

        private void pbCompany3_MouseEnter(object sender, EventArgs e)
        {
            pbCompany3.Image = Properties.Resources.camera;

        }
        private void pbCompany4_MouseLeave(object sender, EventArgs e)
        {
            pbCompany4.Image = Properties.Resources.VanPhong;
        }

        private void pbCompany4_MouseEnter(object sender, EventArgs e)
        {
            pbCompany4.Image = Properties.Resources.camera;
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
