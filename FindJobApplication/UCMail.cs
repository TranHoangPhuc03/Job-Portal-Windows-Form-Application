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
    public partial class UCMail : UserControl
    {
        public UCMail()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public TableLayoutPanel PnlListMail { get => pnlListMail; }

        private void UCMail_Load(object sender, EventArgs e)
        {
            btnMailReceived_Click(sender, e);
        }
        private void btnMailReceived_Click(object sender, EventArgs e)
        {
            lblFrom.Text = "From";
            pnlListMail.Controls.Clear();
            pnlListMail.SuspendLayout();
            for (int i = 0; i< 20; i++)
            {
                UCMailRow row = new UCMailRow();
                row.LblID.Text = (i+1).ToString();
                pnlListMail.Controls.Add(row);
            }
            pnlListMail.ResumeLayout();
        }

        private void btnMailSent_Click(object sender, EventArgs e)
        {
            lblFrom.Text = "To";
            pnlListMail.Controls.Clear();
            for (int i = 0; i < 20; i++)
            {
                UCMailRow row = new UCMailRow();
                row.LblID.Text = (i+1).ToString();
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
