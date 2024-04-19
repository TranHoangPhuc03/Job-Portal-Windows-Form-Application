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
    public partial class UCCompanyProfile : UserControl
    {
        private int companyId;
        public static int statusBtnFollowCompany = 1;
        public UCCompanyProfile()
        {
            InitializeComponent();
            btnBack.Visible = false;
        }

        public UCCompanyProfile(int companyId) : this()
        {
            this.companyId = companyId;
        }

        public void hideAllButton()
        {
            btnBack.Visible = true;
            btnFollow.Visible = true;
            btnInbox.Visible = true ;
            pbProfileEdit.Visible = false;
            pbTop3Edit.Visible = false;
            pBCompanyOverviewEdit.Visible = false;
        }
        private void pbIntroductionEdit_Click(object sender, EventArgs e)
        {

        }

        private void pbProfileEdit_Click(object sender, EventArgs e)
        {
            FCompanyProfileInfomationEdit fCompanyProfileInfomationEdit = new FCompanyProfileInfomationEdit();
            fCompanyProfileInfomationEdit.FormClosed += UCCompanyProfile_Load;
            fCompanyProfileInfomationEdit.Show();
        }

        private void btnFollow_Click(object sender, EventArgs e)
        {
            if (statusBtnFollowCompany == 1)
            {
                btnFollow.Text = "Following";
                statusBtnFollowCompany = 2;
            }
            else
            {
                btnFollow.Text = "Follow";
                statusBtnFollowCompany = 1;
            }
        }

        private void UCCompanyProfile_Load(object sender, EventArgs e)
        {
            CompanyProfileDao companyProfileDao = new CompanyProfileDao();
            CompanyProfile companyProfile = companyProfileDao.FindCompanyProfileById(this.companyId);
            JobPostDao jobPostDao = new JobPostDao();   
            int cnt = jobPostDao.FindAllJobPostByCompanyId(this.companyId).Count;
            lblCountJob.Text = cnt.ToString();
            this.lblProfileCompany.Text = companyProfile.Name;
            this.lblProfileAddress.Text = companyProfile.Address;
            this.lblProfileCompanySize.Text = companyProfile.CompanySize.ToString();
            this.lblProfilePhone.Text = companyProfile.PhoneNumber;
            this.lblProfileDateEstablish.Text = companyProfile.DateEstablish?.ToString("dd-MM-yyyy");
            this.lblProfileEmail.Text = companyProfile.Email;
            this.lblProfileLink.Text = companyProfile.CompanyLink;
            this.rtxtTop3Reason.Text = companyProfile.Reason;
            this.rTxtOverview.Text = companyProfile.Overview;
        }

        private void pbTop3Edit_Click(object sender, EventArgs e)
        {
            FCompanyProfileTop3Reasons fCompanyProfileTop3Reasons = new FCompanyProfileTop3Reasons();
            fCompanyProfileTop3Reasons.Show();
        }

        private void pBCompanyOverviewEdit_Click(object sender, EventArgs e)
        {
            FCompanyProfileOverviewEdit fCompanyProfileOverviewEdit = new FCompanyProfileOverviewEdit();
            fCompanyProfileOverviewEdit.Show();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            FSendMail fSendMail = new FSendMail();
            fSendMail.Show();
        }

        private void btnSeeJob_Click(object sender, EventArgs e)
        {
            UCCompanyJobRecruitment uCCompanyJobRecruitment = new UCCompanyJobRecruitment(companyId);
            UCMain.Instance.PnlMid.Controls.Add(uCCompanyJobRecruitment);
            uCCompanyJobRecruitment.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Control parentControl = this.Parent;
            if (parentControl != null)
            {
                parentControl.Controls.Remove(this);
                this.Dispose();
            }
        }
    }
}
