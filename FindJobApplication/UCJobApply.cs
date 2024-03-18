using Guna.UI.WinForms;
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
    public partial class UCJobApply : UserControl
    {
        public UCJobApply()
        {
            InitializeComponent();
        }
        public GunaLabel LblId { get => lblID; set => lblID = value; }
        public GunaLinkLabel LlblNameJob { get => llblNameJob; set => llblNameJob = value; }
        public GunaLinkLabel LlblNameCompany { get => llblNameCompany; set => llblNameCompany = value; }
        public GunaLabel LblDayApply { get => lblDayApply; set => lblDayApply = value; }
        public GunaLabel LblStatus { get => lblStatus; set => lblStatus = value; }
    }
}
