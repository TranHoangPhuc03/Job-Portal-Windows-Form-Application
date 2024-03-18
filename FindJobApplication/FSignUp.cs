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
    public partial class FSignUp : Form
    {
        public FSignUp()
        {
            InitializeComponent();
            txtPassword.Multiline = false;
        }

        private void pHide_Click(object sender, EventArgs e)
        {
            txtPassword.Multiline = true;
            pNotHide.BringToFront();
        }

        private void pNotHide_Click(object sender, EventArgs e)
        {
            txtPassword.Multiline = false;
            pHide.BringToFront();
        }

        private void llblSignUpUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            FLogin dishplayLogin = new FLogin();
            dishplayLogin.Show();
        }
    }
}
