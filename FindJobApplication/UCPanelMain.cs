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
    public partial class UCPanelMain : UserControl
    {
        public UCPanelMain()
        {
            InitializeComponent();
        }

        public void UC_RequiredAddControl(object sender, UserControl uc)
        {
            AddControl(uc);
        }

        public void AddControl(UserControl uc)
        {
            pnlMain.Controls.Clear();
            var fillToMainPanelEvent = uc.GetType().GetEvent("FillToMainPanelClicked");

            if (fillToMainPanelEvent != null)
            {
                var eventHandler = new FillToMainPanelHandler(UC_RequiredAddControl);
                fillToMainPanelEvent.AddEventHandler(uc, eventHandler);
            }

            pnlMain.Controls.Add(uc);
        }
    }
}
