using FindJobApplication;
using FindJobApplication.Daos;
using FindJobApplication.Models;
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
        TopTrendingDao topTrendingDao = new TopTrendingDao();

        public UCTopTrending()
        {
            InitializeComponent();
            Load_Data_Top_5();
        }
        private void Load_Data_Top_5()
        {
            BDTop5.DataPoints.Clear();
            chartTop5.Datasets.Clear();

            DataTable dt = new DataTable(); 
            List<GunaLinkLabel> links = new List<GunaLinkLabel> { llblTop1, llblTop2, llblTop3, llblTop4, llblTop5};
            List<Guna2Button> btns = new List<Guna2Button> { btnTop1, btnTop2, btnTop3, btnTop4, btnTop5 };
            for(int i = 0; i < links.Count; i++)
            {
                btns[i].Visible = true;
                links[i].Visible = true;
            }
            if (cbbSelectTopTrending.SelectedIndex == 0)
            {
                dt = topTrendingDao.TopFiveJobTrending();
                BDTop5.Label = "Top 5 Job Apply";
            }
            else 
            {
                dt = topTrendingDao.TopFiveCompanyTrending();
                BDTop5.Label = "Top 5 Company";

            }
            int cnt = 0;
            if (dt.Rows.Count < 5)
            {
                for (int i = 4; i >= dt.Rows.Count; i--)
                {
                    btns[i].Visible = false;
                    links[i].Visible = false;
                }
            }
            if (dt.Rows.Count > 0) lblbTop1.Text = dt.Rows[0]["nameTop"].ToString();
            foreach (DataRow row in dt.Rows)
            {
                string name = row["nameTop"].ToString();
                int count = Convert.ToInt32(row["cnt"]);
                BDTop5.DataPoints.Add("", count);
                links[cnt].Text = name;
                cnt++;

            }
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
            if (cbbSelectTopTrending.SelectedIndex == 0)
            {
                UCJobInformation uCJobInformation = new UCJobInformation((int)topTrendingDao.TopFiveJobTrending().Rows[row - 1]["job_post_id"]);
                FHome.Instance.PnlMain.Controls.Add(uCJobInformation);
                uCJobInformation.BringToFront();
                MessageBox.Show("hi");
            }
            else
            {
                UCCompanyProfile uCCompanyProfile = new UCCompanyProfile((int)topTrendingDao.TopFiveJobTrending().Rows[row - 1]["idCompany"]);
                
                uCCompanyProfile.hideAllButton();
                uCCompanyProfile.BringToFront();
            }


        }

        private void cbbSelectTopTrending_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Data_Top_5();
        }
    }
}
