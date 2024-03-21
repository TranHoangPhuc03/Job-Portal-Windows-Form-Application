using Guna.UI.WinForms;
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
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }
        
        public Guna2TextBox TxtSeach { get { return txtSearch; } }
        public GunaComboBox CbLocation { get { return cbLocation; } }
        public GunaComboBox CbExperince { get { return cbExperience; } }
        public GunaComboBox CbSalary { get { return cbSalary; } }
        public GunaButton BtnSearch { get { return btnSearch; } }
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
