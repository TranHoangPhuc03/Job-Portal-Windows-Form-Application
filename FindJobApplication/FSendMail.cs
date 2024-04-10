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
    public partial class FSendMail : Form
    {
        public FSendMail()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
