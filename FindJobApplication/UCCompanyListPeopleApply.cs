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
            loadListPeople();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void loadListPeople ()
        {
            pnlListPeopleAplly.Controls.Clear();
            List<UCCompanyPeopleApplied> list = new List<UCCompanyPeopleApplied>();
            for (int i = 0; i <= 15; i++)
            {
                UCCompanyPeopleApplied uCCompanyPeopleApplied = new UCCompanyPeopleApplied();
                uCCompanyPeopleApplied.LblId.Text = i.ToString();
                uCCompanyPeopleApplied.LblNamePeople.Text = "David" + i.ToString();
                uCCompanyPeopleApplied.LblDayApply.Text = DateTime.Now.ToString();
                uCCompanyPeopleApplied.LblStatus.Text = "Pending";
                list.Add(uCCompanyPeopleApplied);
                pnlListPeopleAplly.Controls.Add(list[i]);
            }
        }
    }
}
