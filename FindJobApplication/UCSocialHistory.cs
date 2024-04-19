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
    public partial class UCSocialHistory : UserControl
    {
        public UCSocialHistory()
        {
            InitializeComponent();
        }

        private void UCSocialHistory_Load(object sender, EventArgs e)
        {
            SocialPostDao socialPostDao = new SocialPostDao();
            List<SocialPost> list = socialPostDao.FindAllSocialPost();
            List<SocialPost> filteredList = list.Where(post => post.AccountId == Session.accountId).ToList();
            int cnt = 1;
            foreach (SocialPost socialPost in filteredList)
            {
                UCSocialHistoryRow row = new UCSocialHistoryRow(cnt++, socialPost);
                pnlListSocial.Controls.Add(row);
            }
        }
    }
}
