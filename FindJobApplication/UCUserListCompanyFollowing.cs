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
    public partial class UCUserListCompanyFollowing : UserControl
    {
        public UCUserListCompanyFollowing()
        {
            InitializeComponent();
        }

        private void UCUserListCompanyFollowing_Load(object sender, EventArgs e)
        {
            pnlListCompanyFollowing.Controls.Clear();
            List<UCUserCompanyFollwing> list = new List<UCUserCompanyFollwing>();
            for (int i = 0; i < 10; i++)
            {
                UCUserCompanyFollwing uCUserCompanyFollwing = new UCUserCompanyFollwing();
                uCUserCompanyFollwing.LblId.Text = i.ToString();
                uCUserCompanyFollwing.LlblNameCompany.Text = "Comapy" + i.ToString();
                list.Add(uCUserCompanyFollwing);
                pnlListCompanyFollowing.Controls.Add(list[i]);
            }
        }
    }
}
