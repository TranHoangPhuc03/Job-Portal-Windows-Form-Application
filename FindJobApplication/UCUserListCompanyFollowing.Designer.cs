namespace FindJobApplication
{
    partial class UCUserListCompanyFollowing
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
            this.lblNameCompany = new Guna.UI.WinForms.GunaLabel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.pnlListCompanyFollowing = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlTopTableApplyJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopTableApplyJob
            // 
            this.pnlTopTableApplyJob.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopTableApplyJob.BaseColor = System.Drawing.Color.White;
            this.pnlTopTableApplyJob.Controls.Add(this.pictureBox2);
            this.pnlTopTableApplyJob.Controls.Add(this.lblNameCompany);
            this.pnlTopTableApplyJob.Controls.Add(this.lblID);
            this.pnlTopTableApplyJob.Location = new System.Drawing.Point(3, 2);
            this.pnlTopTableApplyJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopTableApplyJob.Name = "pnlTopTableApplyJob";
            this.pnlTopTableApplyJob.Radius = 10;
            this.pnlTopTableApplyJob.Size = new System.Drawing.Size(1538, 43);
            this.pnlTopTableApplyJob.TabIndex = 46;
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.BackColor = System.Drawing.Color.White;
            this.lblNameCompany.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCompany.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNameCompany.ImageKey = "(none)";
            this.lblNameCompany.Location = new System.Drawing.Point(214, 8);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(133, 30);
            this.lblNameCompany.TabIndex = 12;
            this.lblNameCompany.Text = "Company";
            this.lblNameCompany.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // pnlListCompanyFollowing
            // 
            this.pnlListCompanyFollowing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListCompanyFollowing.AutoScroll = true;
            this.pnlListCompanyFollowing.Location = new System.Drawing.Point(3, 49);
            this.pnlListCompanyFollowing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlListCompanyFollowing.Name = "pnlListCompanyFollowing";
            this.pnlListCompanyFollowing.Size = new System.Drawing.Size(1537, 800);
            this.pnlListCompanyFollowing.TabIndex = 45;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::FindJobApplication.Properties.Resources.Company;
            this.pictureBox2.Location = new System.Drawing.Point(154, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // UCUserListCompanyFollowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTopTableApplyJob);
            this.Controls.Add(this.pnlListCompanyFollowing);
            this.Name = "UCUserListCompanyFollowing";
            this.Size = new System.Drawing.Size(1544, 851);
            this.Load += new System.EventHandler(this.UCUserListCompanyFollowing_Load);
            this.pnlTopTableApplyJob.ResumeLayout(false);
            this.pnlTopTableApplyJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel pnlTopTableApplyJob;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaLabel lblNameCompany;
        private Guna.UI.WinForms.GunaLabel lblID;
        private System.Windows.Forms.FlowLayoutPanel pnlListCompanyFollowing;
    }
}
