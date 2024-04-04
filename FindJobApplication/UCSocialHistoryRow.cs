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

        private void pbEdit_Click(object sender, EventArgs e)
        {
            FPostSocial fPostSocial = new FPostSocial();
            fPostSocial.BtnPost.Text = "Save";
            fPostSocial.Show();
        }
    }
}
