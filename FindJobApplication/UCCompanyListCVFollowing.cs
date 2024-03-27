using FindJobApplication.Daos;
using FindJobApplication.Models;
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
            CompanyProfileDao companyProfileDao = new CompanyProfileDao();
            DataTable dt = companyProfileDao.findAllUserFollowing(Global.loginId);
            int cnt = 1;
            foreach (DataRow dr in dt.Rows)
            {
                UserProfileDao userProfileDao = new UserProfileDao();
                UserProfile userProfile = userProfileDao.findUserById((int)dr["user_id"]);
                UCCompanyCVFollowing uCCompanyCVFollowing = new UCCompanyCVFollowing();
                uCCompanyCVFollowing.LblId.Text = (cnt++).ToString();
                uCCompanyCVFollowing.LlblName.Text = userProfile.Name;
                uCCompanyCVFollowing.Tag = userProfile.Id;
                this.pnlListCVFollowing.Controls.Add(uCCompanyCVFollowing);
            }
        }
    }
}
