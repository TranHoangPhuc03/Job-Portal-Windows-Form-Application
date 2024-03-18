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
    public partial class FUserSubmitCV : Form
    {
        public FUserSubmitCV()
        {
            InitializeComponent();
        }

        private void btnSendCv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
