namespace FindJobApplication
{
    partial class UCCompanyPeopleApplied
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
            this.pnTupleTableJob = new Guna.UI2.WinForms.Guna2Panel();
            this.pbSeeDetail = new System.Windows.Forms.PictureBox();
            this.lblId = new Guna.UI.WinForms.GunaLabel();
            this.lblNamePeople = new Guna.UI.WinForms.GunaLabel();
            this.lblStatus = new Guna.UI.WinForms.GunaLabel();
            this.lblDayApply = new Guna.UI.WinForms.GunaLabel();
            this.pnTupleTableJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeeDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTupleTableJob
            // 
            this.pnTupleTableJob.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnTupleTableJob.BorderColor = System.Drawing.Color.DarkGray;
            this.pnTupleTableJob.BorderRadius = 10;
            this.pnTupleTableJob.BorderThickness = 1;
            this.pnTupleTableJob.Controls.Add(this.pbSeeDetail);
            this.pnTupleTableJob.Controls.Add(this.lblId);
            this.pnTupleTableJob.Controls.Add(this.lblNamePeople);
            this.pnTupleTableJob.Controls.Add(this.lblStatus);
            this.pnTupleTableJob.Controls.Add(this.lblDayApply);
            this.pnTupleTableJob.FillColor = System.Drawing.Color.White;
            this.pnTupleTableJob.Location = new System.Drawing.Point(0, 1);
            this.pnTupleTableJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTupleTableJob.Name = "pnTupleTableJob";
            this.pnTupleTableJob.Size = new System.Drawing.Size(1485, 42);
            this.pnTupleTableJob.TabIndex = 2;
            // 
            // pbSeeDetail
            // 
            this.pbSeeDetail.BackColor = System.Drawing.Color.White;
            this.pbSeeDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSeeDetail.Image = global::FindJobApplication.Properties.Resources.eye;
            this.pbSeeDetail.Location = new System.Drawing.Point(1369, 4);
            this.pbSeeDetail.Name = "pbSeeDetail";
            this.pbSeeDetail.Size = new System.Drawing.Size(79, 34);
            this.pbSeeDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeeDetail.TabIndex = 18;
            this.pbSeeDetail.TabStop = false;
            this.pbSeeDetail.Click += new System.EventHandler(this.pbSeeDetail_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(18, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 30);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID";
            // 
            // lblNamePeople
            // 
            this.lblNamePeople.AutoSize = true;
            this.lblNamePeople.BackColor = System.Drawing.Color.White;
            this.lblNamePeople.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePeople.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNamePeople.ImageKey = "(none)";
            this.lblNamePeople.Location = new System.Drawing.Point(182, 8);
            this.lblNamePeople.Name = "lblNamePeople";
            this.lblNamePeople.Size = new System.Drawing.Size(87, 30);
            this.lblNamePeople.TabIndex = 9;
            this.lblNamePeople.Text = "Name";
            this.lblNamePeople.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1121, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 30);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // lblDayApply
            // 
            this.lblDayApply.AutoSize = true;
            this.lblDayApply.BackColor = System.Drawing.Color.White;
            this.lblDayApply.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayApply.Location = new System.Drawing.Point(476, 8);
            this.lblDayApply.Name = "lblDayApply";
            this.lblDayApply.Size = new System.Drawing.Size(112, 30);
            this.lblDayApply.TabIndex = 10;
            this.lblDayApply.Text = "Apply at";
            // 
            // UCCompanyPeopleApplied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnTupleTableJob);
            this.Name = "UCCompanyPeopleApplied";
            this.Size = new System.Drawing.Size(1488, 45);
            this.pnTupleTableJob.ResumeLayout(false);
            this.pnTupleTableJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeeDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnTupleTableJob;
        private Guna.UI.WinForms.GunaLabel lblId;
        private Guna.UI.WinForms.GunaLabel lblNamePeople;
        private Guna.UI.WinForms.GunaLabel lblStatus;
        private Guna.UI.WinForms.GunaLabel lblDayApply;
        private System.Windows.Forms.PictureBox pbSeeDetail;
    }
}
