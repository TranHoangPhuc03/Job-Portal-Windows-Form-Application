using FindJobApplication;
using FindJobApplication.Daos;
using Guna.Charts.WinForms;
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

namespace FindJobApplication
{
    public partial class UCTopTrending : UserControl
    {
        JobApplyDao jobApplyDao = new JobApplyDao();

        public UCTopTrending()
        {
            InitializeComponent();
            Load_Data_Top_5_Job_Apply();
        }
        public void Load_Data_Top_5_Job_Apply()
        {
            BDTop5.DataPoints.Clear();
            chartTop5.Datasets.Clear();

            DataTable dt = jobApplyDao.TopFiveJobTrending();
            List<GunaLinkLabel> links = new List<GunaLinkLabel> { llblTop1, llblTop2, llblTop3, llblTop4, llblTop5};
            List<Guna2Button> btns = new List<Guna2Button> { btnTop1, btnTop2, btnTop3, btnTop4, btnTop5 };
            int cnt = 0;
            if (dt.Rows.Count < 5) 
            {
                for (int i = 4; i >= dt.Rows.Count; i--)
                {
                    btns[i].Visible = false;
                    links[i].Visible = false;
                }
            }
            if (dt.Rows.Count > 0) lblbTop1.Text = dt.Rows[0]["title"].ToString();
            foreach (DataRow row in dt.Rows)
            {
                string nameJob = row["title"].ToString();
                int recruitment_number = Convert.ToInt32(row["number_of_apply"]);
                BDTop5.DataPoints.Add("", recruitment_number);
                links[cnt].Text = nameJob;
                cnt++;

            }
            BDTop5.Label = "Top 5 Job Apply";
            chartTop5.Datasets.Add(BDTop5);
            chartTop5.Update();
        }

        private void lblbTop1_Click(object sender, EventArgs e)
        {
            loadDetail(lblbTop1);
        }

        private void llblTop1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadDetail(llblTop1);
        }

        private void llblTop2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadDetail(llblTop2);

        }

        private void llblTop3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadDetail(llblTop3);

        }

        private void llblTop4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadDetail(llblTop4);

        }

        private void llblTop5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loadDetail(llblTop5);

        }
        public void loadDetail(Label lbl)
        {
            int row = int.Parse(lbl.Name[lbl.Name.Length - 1].ToString());
            UCJobInformation uCJobInformation = new UCJobInformation((int)jobApplyDao.TopFiveJobTrending().Rows[row-1]["job_post_id"]);
            UCMain.Instance.PnlMid.Controls.Add(uCJobInformation);
            uCJobInformation.BringToFront();

        }

        private void cbbSelectTopTrending_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSelectTopTrending.SelectedIndex == 0)
            {
                Load_Data_Top_5_Job_Apply();
            }
            else { }
        }
    }
}
