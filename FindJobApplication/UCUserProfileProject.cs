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
    public partial class UCUserProfileProject : UserControl
    {
        public UCUserProfileProject()
        {
            InitializeComponent();
        }

        private void lblSeeProject_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.youtube.com/";
            System.Diagnostics.Process.Start(url);
        }
    }
}
