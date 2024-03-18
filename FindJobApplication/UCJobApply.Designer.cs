namespace FindJobApplication
{
    partial class UCJobApply
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopTableApplyJob = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblStatus = new Guna.UI.WinForms.GunaLabel();
            this.lblDayApply = new Guna.UI.WinForms.GunaLabel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.llblNameJob = new Guna.UI.WinForms.GunaLinkLabel();
            this.llblNameCompany = new Guna.UI.WinForms.GunaLinkLabel();
            this.pnlTopTableApplyJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopTableApplyJob
            // 
            this.pnlTopTableApplyJob.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopTableApplyJob.BaseColor = System.Drawing.Color.White;
            this.pnlTopTableApplyJob.Controls.Add(this.llblNameCompany);
            this.pnlTopTableApplyJob.Controls.Add(this.llblNameJob);
            this.pnlTopTableApplyJob.Controls.Add(this.lblStatus);
            this.pnlTopTableApplyJob.Controls.Add(this.lblDayApply);
            this.pnlTopTableApplyJob.Controls.Add(this.lblID);
            this.pnlTopTableApplyJob.Location = new System.Drawing.Point(3, 2);
            this.pnlTopTableApplyJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopTableApplyJob.Name = "pnlTopTableApplyJob";
            this.pnlTopTableApplyJob.Radius = 10;
            this.pnlTopTableApplyJob.Size = new System.Drawing.Size(1481, 45);
            this.pnlTopTableApplyJob.TabIndex = 45;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblStatus.ImageKey = "(none)";
            this.lblStatus.Location = new System.Drawing.Point(1239, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 30);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDayApply
            // 
            this.lblDayApply.AutoSize = true;
            this.lblDayApply.BackColor = System.Drawing.Color.White;
            this.lblDayApply.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayApply.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDayApply.ImageKey = "(none)";
            this.lblDayApply.Location = new System.Drawing.Point(856, 8);
            this.lblDayApply.Name = "lblDayApply";
            this.lblDayApply.Size = new System.Drawing.Size(137, 30);
            this.lblDayApply.TabIndex = 14;
            this.lblDayApply.Text = "Applied at";
            this.lblDayApply.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(9, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 30);
            this.lblID.TabIndex = 11;
            this.lblID.Text = "ID";
            // 
            // llblNameJob
            // 
            this.llblNameJob.AutoSize = true;
            this.llblNameJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblNameJob.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblNameJob.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblNameJob.Location = new System.Drawing.Point(206, 8);
            this.llblNameJob.Name = "llblNameJob";
            this.llblNameJob.Size = new System.Drawing.Size(87, 30);
            this.llblNameJob.TabIndex = 17;
            this.llblNameJob.TabStop = true;
            this.llblNameJob.Text = "Name";
            // 
            // llblNameCompany
            // 
            this.llblNameCompany.AutoSize = true;
            this.llblNameCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblNameCompany.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblNameCompany.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblNameCompany.Location = new System.Drawing.Point(479, 8);
            this.llblNameCompany.Name = "llblNameCompany";
            this.llblNameCompany.Size = new System.Drawing.Size(133, 30);
            this.llblNameCompany.TabIndex = 18;
            this.llblNameCompany.TabStop = true;
            this.llblNameCompany.Text = "Company";
            // 
            // UCJobApply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTopTableApplyJob);
            this.Name = "UCJobApply";
            this.Size = new System.Drawing.Size(1497, 49);
            this.pnlTopTableApplyJob.ResumeLayout(false);
            this.pnlTopTableApplyJob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel pnlTopTableApplyJob;
        private Guna.UI.WinForms.GunaLabel lblStatus;
        private Guna.UI.WinForms.GunaLabel lblDayApply;
        private Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI.WinForms.GunaLinkLabel llblNameJob;
        private Guna.UI.WinForms.GunaLinkLabel llblNameCompany;
    }
}
