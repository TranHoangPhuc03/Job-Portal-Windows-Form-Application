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
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        public void fillDataToPanel<T>(List<T> dataControlList)
        {
            pnlListJob.Controls.Clear();
            foreach (Object obj in dataControlList)
            {
                this.pnlListJob.Controls.Add((Control)obj);
            }
        }
    }
}
