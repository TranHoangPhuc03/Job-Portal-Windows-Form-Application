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
    public partial class UCCompanyProfile : UserControl
    {
        public static int statusBtnFollowCompany = 1;
        public UCCompanyProfile()
        {
            InitializeComponent();
            btnBack.Visible = false;
        }
        public void hideAllButton()
        {
            btnBack.Visible = true;
            btnFollow.Visible = true;
            pbProfileEdit.Visible = false;
            pbTop3Edit.Visible = false;
            pBCompanyOverviewEdit.Visible = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pbIntroductionEdit_Click(object sender, EventArgs e)
        {

        }

        private void pbProfileEdit_Click(object sender, EventArgs e)
        {
            FCompanyProfileInfomationEdit fCompanyProfileInfomationEdit = new FCompanyProfileInfomationEdit();
            fCompanyProfileInfomationEdit.Show();
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            if (statusBtnFollowCompany == 1)
            {
                btnFollow.Image = Properties.Resources.unFollow;
                btnFollow.Text = "Following";
                statusBtnFollowCompany = 2;
            }
            else
            {
                btnFollow.Image = Properties.Resources.Follow;
                btnFollow.Text = "Follow";
                statusBtnFollowCompany = 1;
            }
        }
    }
}
