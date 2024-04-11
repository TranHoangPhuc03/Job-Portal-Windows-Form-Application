using FindJobApplication.Daos;
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
    public partial class UCCompanyListPeopleApply : UserControl
    {
        public UCCompanyListPeopleApply()
        {
            InitializeComponent();
            pnlListPeopleAplly.AutoScroll = true;
        }
        public UCCompanyListPeopleApply(int jobPostId)
        {
            InitializeComponent();
            pnlListPeopleAplly.AutoScroll = true;
            this.Tag = jobPostId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void loadListPeople<T> (List<T> dataControlList)
        {
            pnlListPeopleAplly.Controls.Clear();
            foreach (Object obj in dataControlList)
            {
                this.pnlListPeopleAplly.Controls.Add((Control)obj);
            }
        }

        private void UCCompanyListPeopleApply_Load(object sender, EventArgs e)
        {
            //JobPostDao jobPostDao = new JobPostDao();
            //List<JobPost> dt = jobPostDao.FindAllUserAppliedForOneJob((int)this.Tag);
            //int cnt = 1;
            //List<UCCompanyPeopleApplied> dataControlList = new List<UCCompanyPeopleApplied>();
            //foreach (DataRow row in dt.Rows)
            //{
            //    UCCompanyPeopleApplied uCCompanyPeopleApplied = new UCCompanyPeopleApplied();
            //    uCCompanyPeopleApplied.LblId.Text = (cnt++).ToString();
            //    uCCompanyPeopleApplied.LblNamePeople.Text = row["name"].ToString();
            //    uCCompanyPeopleApplied.LblDayApply.Text = row["applied_at"].ToString();
            //    uCCompanyPeopleApplied.LblStatus.Text = row["status"].ToString();
            //    uCCompanyPeopleApplied.Tag = new Dictionary<string, int> { 
            //        { "jobPostId", (int)this.Tag },
            //        { "userId", (int)row["id"] } 
            //    };
            //    dataControlList.Add(uCCompanyPeopleApplied);
            //}
            //loadListPeople(dataControlList);
        }
    }
}
