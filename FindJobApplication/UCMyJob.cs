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
            changeColorButton(btnListJobSave, btnListJobApply);
            pnlListJob.Controls.Clear();
            pnlTopTableApplyJob.Hide();
            pnlListJob.Height = 783;
            pnlListJob.Location = new Point(3, 62);
            List<UCJob> list = new List<UCJob>();
            for (int i = 0; i < 10; i++)
            {
                UCJob jobControl = new UCJob();
                jobControl.LinkLabelJob.Text = "Job" + i.ToString();
                jobControl.PbSave.Image = Properties.Resources.heart2;
                list.Add(jobControl);
                pnlListJob.Controls.Add(list[i]);
            }
        }
        private void btnListJobApply_Click(object sender, EventArgs e)
        {
            pnlTopTableApplyJob.Show();
            changeColorButton(btnListJobApply, btnListJobSave);
            pnlListJob.Controls.Clear();
            pnlListJob.Height = 740;
            pnlListJob.Location = new Point(3, 109);
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
                pnlListJob.Controls.Add(list[i]);
            }
        }
        private void changeColorButton(GunaButton buttonClick, GunaButton buttonNonClick)
        {
            buttonClick.ForeColor = Color.Red;
            buttonClick.OnHoverForeColor = Color.Red;
            buttonClick.OnHoverForeColor = Color.Red;

            buttonNonClick.ForeColor = Color.Black;
            buttonNonClick.OnHoverForeColor = Color.Black;
            buttonNonClick.OnHoverForeColor = Color.Black;
        }

        private void UCMyJob_Load(object sender, EventArgs e)
        {
            btnListJobSave_Click(sender, e);
        }
    }
}
