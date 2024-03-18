using FindJobApplication.Models;
using Guna.UI.WinForms;
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
    public partial class UCMain : UserControl
    {
        static UCMain _obj;
        public static UCMain Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCMain();
                }
                return _obj;
            }
        }
        public UCMain()
        {
            InitializeComponent();
        }
        public Panel PnlMid { get => pnlMid; set => pnlMid = value; }
        public GunaButton BtnHome { get => btnHome; set => btnHome = value; }
        public GunaButton BtnUser { get => btnUser; set => btnUser = value; }
        public GunaButton BtnStatus { get => btnStatus; set => btnStatus = value; }
        public GunaButton BtnLogOut { get => btnSignOut; set => btnSignOut = value; }
        public PictureBox PbHomeUser { get => pbHomeUser; set => pbHomeUser = value; }

        public void updateStatus(GunaButton button)
        {
            btnStatus.Image = button.Image;
            btnStatus.Text = button.Text;
        }
        private void UCMain_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Global.loginId = 0;
            Global.role = "";

            FLogin fLogin = new FLogin();
            Form thisForm = (Form)this.TopLevelControl;
            thisForm.Hide();
            fLogin.ShowDialog();
            thisForm.Close();
        }
    }
}
