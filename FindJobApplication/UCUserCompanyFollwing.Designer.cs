namespace FindJobApplication
{
    partial class UCUserCompanyFollwing
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
            this.llblNameCompany = new Guna.UI.WinForms.GunaLinkLabel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.pnlTopTableApplyJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopTableApplyJob
            // 
            this.pnlTopTableApplyJob.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopTableApplyJob.BaseColor = System.Drawing.Color.White;
            this.pnlTopTableApplyJob.Controls.Add(this.llblNameCompany);
            this.pnlTopTableApplyJob.Controls.Add(this.lblID);
            this.pnlTopTableApplyJob.Location = new System.Drawing.Point(8, 2);
            this.pnlTopTableApplyJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopTableApplyJob.Name = "pnlTopTableApplyJob";
            this.pnlTopTableApplyJob.Radius = 10;
            this.pnlTopTableApplyJob.Size = new System.Drawing.Size(1481, 45);
            this.pnlTopTableApplyJob.TabIndex = 46;
            // 
            // llblNameCompany
            // 
            this.llblNameCompany.AutoSize = true;
            this.llblNameCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblNameCompany.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblNameCompany.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblNameCompany.Location = new System.Drawing.Point(150, 8);
            this.llblNameCompany.Name = "llblNameCompany";
            this.llblNameCompany.Size = new System.Drawing.Size(133, 30);
            this.llblNameCompany.TabIndex = 18;
            this.llblNameCompany.TabStop = true;
            this.llblNameCompany.Text = "Company";
            this.llblNameCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNameCompany_LinkClicked);
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
            // UCUserCompanyFollwing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTopTableApplyJob);
            this.Name = "UCUserCompanyFollwing";
            this.Size = new System.Drawing.Size(1497, 49);
            this.pnlTopTableApplyJob.ResumeLayout(false);
            this.pnlTopTableApplyJob.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel pnlTopTableApplyJob;
        private Guna.UI.WinForms.GunaLinkLabel llblNameCompany;
        private Guna.UI.WinForms.GunaLabel lblID;
    }
}
