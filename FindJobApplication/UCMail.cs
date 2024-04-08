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
    public partial class UCMail : UserControl
    {
        public UCMail()
        {
            InitializeComponent();
        }
        private void UCMail_Load(object sender, EventArgs e)
        {
            btnMailReceived_Click(sender, e);
        }
        private void btnMailReceived_Click(object sender, EventArgs e)
        {
            pnlListMail.Controls.Clear();
            for (int i = 0; i< 20; i++)
            {
                UCMailRow row = new UCMailRow();
                row.LblID.Text = i.ToString();
                pnlListMail.Controls.Add(row);
            }
        }

        private void btnMailSent_Click(object sender, EventArgs e)
        {
            pnlListMail.Controls.Clear();
            for (int i = 0; i < 20; i++)
            {
                UCMailRow row = new UCMailRow();
                row.LblID.Text = i.ToString();
                pnlListMail.Controls.Add(row);
            }
        }

        private void btnComposeEmail_Click(object sender, EventArgs e)
        {
            FSendMail fSendMail = new FSendMail();
            fSendMail.Show();
        }
    }
}
