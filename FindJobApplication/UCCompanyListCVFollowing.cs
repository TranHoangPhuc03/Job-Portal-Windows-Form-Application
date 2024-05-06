using FindJobApplication.Daos;
using FindJobApplication.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class UCCompanyListCVFollowing : UserControl
    {
        public UCCompanyListCVFollowing()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void UCCompanyListCVFollowing_Load(object sender, EventArgs e)
        {
            CompanyProfileDao companyProfileDao = new CompanyProfileDao();
            var userProfileFollowing = companyProfileDao.FindAllUserIdFollowing(Session.account.Id);
            pnlListCVFollowing.SuspendLayout();
            pnlListCVFollowing.Controls.Clear();
            pnlListCVFollowing.RowCount = 0;
            for (int i = 0; i < userProfileFollowing.Count; ++i)
            {
                UCCompanyCVFollowing uCCompanyCVFollowing = new UCCompanyCVFollowing(i+1, userProfileFollowing.ElementAt(i));
                pnlListCVFollowing.Controls.Add(uCCompanyCVFollowing);
                pnlListCVFollowing.RowCount += 1;
            }
            pnlListCVFollowing.RowCount += 1;
            pnlListCVFollowing.ResumeLayout();
        }
    }
}
