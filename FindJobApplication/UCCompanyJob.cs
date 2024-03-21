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
    public partial class UCCompanyJob : UserControl
    {
        public UCCompanyJob()
        {
            InitializeComponent();
        }
        public GunaLabel LblID { get => lblId; set { lblId = value; } }
        public GunaLabel LblNameJob { get => lblNameJob; set { lblNameJob = value; } }
        public GunaLabel LblPostDate { get => lblPostDate; set { lblPostDate = value; } }
        public GunaLabel LblExpirationDate { get => lblExpirationDate; set { lblExpirationDate = value; } }
        public GunaLabel LblSalary { get => lblSalary; set { lblSalary = value; } }
        public GunaLinkLabel LblCountApplied { get => lblCountApplied; set {  lblCountApplied = value; } }
        private void lblCountApplied_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UCCompanyListPeopleApply uCCompanyListPeopleApply = new UCCompanyListPeopleApply(this.Tag);
            UCMain.Instance.PnlMid.Controls.Add(uCCompanyListPeopleApply);
            uCCompanyListPeopleApply.Location = new Point(UCMain.Instance.PnlMid.Width / 2 - uCCompanyListPeopleApply.Width / 2, 0);
            uCCompanyListPeopleApply.BringToFront();
        }
    }
}
