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
    public partial class FPostSocial : Form
    {
        public FPostSocial()
        {
            InitializeComponent();
        }
        public Guna2Button BtnPost { get => btnPost; set => btnPost = value; }
        private void btnPost_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
