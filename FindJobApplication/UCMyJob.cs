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
    public partial class UCMyJob : UserControl
    {
        public UCMyJob()
        {
            InitializeComponent();
        }

        private void btnListJobSave_Click(object sender, EventArgs e)
        {
            btnListJobSave.FillColor = Color.FromArgb(255, 75, 43);
            btnListJobSave.ForeColor = Color.White;
            btnListJobSave.HoverState.FillColor = Color.FromArgb(255, 75, 43);
            btnListJobApply.FillColor = Color.White;
            btnListJobApply.ForeColor = Color.FromArgb(255, 75, 43);
            btnListJobApply.HoverState.FillColor = Color.WhiteSmoke;
            pnlListJobSave.BringToFront();
            pnlListJobSave.Controls.Clear();

            List<UCJob> list = new List<UCJob>();
            for (int i = 0; i < 10; i++)
            {
                UCJob jobControl = new UCJob();
                jobControl.LLblNameJob.Text = "Job" + i.ToString();
                jobControl.BtnSave.Checked = true;
                list.Add(jobControl);
                pnlListJobSave.Controls.Add(list[i]);
            }
        }
        private void btnListJobApply_Click(object sender, EventArgs e)
        {
            btnListJobApply.FillColor = Color.FromArgb(255, 75, 43);
            btnListJobApply.ForeColor = Color.White;
            btnListJobApply.HoverState.FillColor = Color.FromArgb(255, 75, 43);

            btnListJobSave.FillColor = Color.White;
            btnListJobSave.ForeColor = Color.FromArgb(255, 75, 43);
            btnListJobSave.HoverState.FillColor = Color.WhiteSmoke;
            pnlListJobSave.SendToBack();
            pnlListJobApply.Controls.Clear();
            pnlListJobSave.Controls.Clear();

            List<UCJobApply> list = new List<UCJobApply>();
            for (int i = 0; i < 10; i++)
            {
                UCJobApply uCJobApply = new UCJobApply();
                uCJobApply.LblId.Text = i.ToString();
                uCJobApply.LlblNameJob.Text = "Job" + i.ToString();
                uCJobApply.LlblNameCompany.Text = "Comapy" + i.ToString();
                uCJobApply.LblStatus.Text = "Denied";
                uCJobApply.LblDayApply.Text = DateTime.Now.ToString();
                list.Add(uCJobApply);
                pnlListJobApply.Controls.Add(list[i]);
            }
        }
        private void UCMyJob_Load(object sender, EventArgs e)
        {
            btnListJobSave_Click(sender, e);
        }
    }
}
