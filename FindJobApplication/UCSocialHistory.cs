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
    public partial class UCSocialHistory : UserControl
    {
        public UCSocialHistory()
        {
            InitializeComponent();
        }

        private void UCSocialHistory_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                UCSocialHistoryRow row = new UCSocialHistoryRow();
                pnlListSocial.Controls.Add(row);
            }
        }
    }
}
