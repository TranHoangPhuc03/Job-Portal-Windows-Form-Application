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
    public partial class FCompanySeeCV : Form
    {
        public FCompanySeeCV()
        {
            InitializeComponent();
            LoadCV();
        }
        public void LoadCV()
        {
            UCProfile uCProfile = new UCProfile();
            uCProfile.hideAllBtn();
            this.Controls.Add(uCProfile);
        }
    }
}
