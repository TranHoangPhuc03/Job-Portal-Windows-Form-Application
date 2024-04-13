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
    public partial class UCMailRow : UserControl
    {
        public UCMailRow()
        {
            InitializeComponent();
        }
        public Label LblID { get => lblID; set => lblID = value; }
        public Label LblFrom { get => lblFrom; set => lblFrom = value; }
        public Label LblTitle { get => lblTitle; set => lblTitle = value; }
        public Label LblTime { get => lblTime; set => lblTime = value; }

        private void pbSeeDetail_Click(object sender, EventArgs e)
        {
            UCMailDetail uCmailDetail = new UCMailDetail();
            UCMain.Instance.PnlMid.Controls.Add(uCmailDetail);
            uCmailDetail.BringToFront();
        }
    }
}
