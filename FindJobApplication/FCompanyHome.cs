using FindJobApplication.Daos;
using FindJobApplication.Utils;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;
using FindJobApplication.Entities;

namespace FindJobApplication
{
    public partial class FCompanyHome : Form
    {
        static FCompanyHome _obj;
        public static FCompanyHome Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FCompanyHome();
                }
                return _obj;
            }
        }
        public FCompanyHome()
        {
            InitializeComponent();
            _obj = this;
        }

        public UCCompanySubMenuRight UCCompanySubMenuRight { get => ucCompanySubMenuRight;  }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.account = null;

            FLogin fLogin = new FLogin();
            Form thisForm = (Form)TopLevelControl;
            thisForm.Hide();
            fLogin.ShowDialog();
            thisForm.Close();
        }
        private void FCompanyHome_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Session.account.Name;
            pbUserImage.Image = ImageUtils.FromBytesToImage(Session.account.Avatar);
            btnHome.PerformClick();
        }

        private void pbUserImage_Click(object sender, EventArgs e)
        {
            ucCompanySubMenuRight.HideAndShowSubMenu(ucCompanySubMenuRight);
        }

        public void btnHome_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCCompanyHome());
        }

        public void btnSocial_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCSocial());
        }

        public void btnMail_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCMail());

        }

        public void btnSchedule_Click(object sender, EventArgs e)
        {
            ucPanelMain.AddControl(new UCSchedule());
        }
    }
}
