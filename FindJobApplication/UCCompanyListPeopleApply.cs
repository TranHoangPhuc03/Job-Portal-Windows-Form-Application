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
using FindJobApplication.Models;

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
            
        }
    }
}
