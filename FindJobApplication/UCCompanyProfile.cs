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
        public UCCompanyProfile()
        {
            InitializeComponent();
            btnBack.Visible = false;
            pnlRecruitment.Visible = false;
        }
        public void hideAllButton()
        {
            btnBack.Visible = true;
            pnlRecruitment.Visible = true;
            pbProfileEdit.Visible = false;
            pbIntroductionEdit.Visible = false;
            pbTop3Edit.Visible = false;
        }
        public void loadRecruitment() 
        {
            pnlListJob.Controls.Clear();
            List<UCJob> list = new List<UCJob>();
            for (int i = 0; i <= 3; i++)
            {
                UCJob uCJob = new UCJob();
                uCJob.LinkLabelJob.Text = "Job" + i.ToString();
                list.Add(uCJob);
                pnlListJob.Controls.Add(list[i]);
            }
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
    }
}
