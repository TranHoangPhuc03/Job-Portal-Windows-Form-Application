using FindJobApplication.Daos;
using FindJobApplication.Models;
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
    public partial class UCSocialHistoryRow : UserControl
    {
        public UCSocialHistoryRow()
        {
            InitializeComponent();
        }

        public UCSocialHistoryRow(int cnt, SocialPost socialPost) : this()
        {
            this.LblID.Text = cnt.ToString();
            this.lblTitle.Text = socialPost.Title;
            this.lblDatePost.Text = socialPost.PostDate.ToString("dd-MM-yyyy");
            this.Tag = socialPost.Id;
        }
        public GunaLabel LblID { get => lblID; set => lblID = value; }
        public GunaLabel LblTitle { get => lblTitle; set => lblTitle = value; }
        public GunaLabel LblDatePots { get => lblDatePost; set => lblDatePost = value; }


        private void pbEdit_Click(object sender, EventArgs e)
        {
            FPostSocial fPostSocial = new FPostSocial();
            fPostSocial.BtnPost.Text = "Save";
            fPostSocial.Show();
        }

        private void pBDelete_Click(object sender, EventArgs e)
        {
            SocialPostDao socialPostDao = new SocialPostDao();
            int result = socialPostDao.DeleteSocialPostById(Convert.ToInt32(this.Tag));
            if (result > 0)
            {
                MessageDialog.Show(this.ParentForm, "Delete success");
            }
            else
            {
                MessageDialog.Show(this.ParentForm, "Delete failed");
            }
        }
    }
}
