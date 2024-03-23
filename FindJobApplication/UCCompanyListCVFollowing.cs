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
    public partial class UCCompanyListCVFollowing : UserControl
    {
        public UCCompanyListCVFollowing()
        {
            InitializeComponent();
        }

        private void UCCompanyListCVFollowing_Load(object sender, EventArgs e)
        {
            pnlListCVFollowing.Controls.Clear();
            List<UCCompanyCVFollowing> list = new List<UCCompanyCVFollowing>();
            for (int i = 0; i < 10; i++)
            {
                UCCompanyCVFollowing uCCompanyCVFollowing = new UCCompanyCVFollowing();
                uCCompanyCVFollowing.LblId.Text = i.ToString();
                uCCompanyCVFollowing.LlblName.Text = "User" + i.ToString();
                list.Add(uCCompanyCVFollowing);
                pnlListCVFollowing.Controls.Add(list[i]);
            }
        }
    }
}
