namespace FindJobApplication
{
    partial class UCMailRow
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
            this.lblTime = new Guna.UI.WinForms.GunaLabel();
            this.lblFrom = new Guna.UI.WinForms.GunaLabel();
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.pbSeeDetail = new System.Windows.Forms.PictureBox();
            this.pnlTopTableApplyJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeeDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopTableApplyJob
            // 
            this.pnlTopTableApplyJob.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopTableApplyJob.BaseColor = System.Drawing.Color.White;
            this.pnlTopTableApplyJob.Controls.Add(this.pbSeeDetail);
            this.pnlTopTableApplyJob.Controls.Add(this.lblTime);
            this.pnlTopTableApplyJob.Controls.Add(this.lblFrom);
            this.pnlTopTableApplyJob.Controls.Add(this.lblID);
            this.pnlTopTableApplyJob.Controls.Add(this.lblTitle);
            this.pnlTopTableApplyJob.Location = new System.Drawing.Point(8, 3);
            this.pnlTopTableApplyJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopTableApplyJob.Name = "pnlTopTableApplyJob";
            this.pnlTopTableApplyJob.Radius = 10;
            this.pnlTopTableApplyJob.Size = new System.Drawing.Size(1481, 43);
            this.pnlTopTableApplyJob.TabIndex = 49;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTime.ImageKey = "(none)";
            this.lblTime.Location = new System.Drawing.Point(1053, 8);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(70, 30);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.BackColor = System.Drawing.Color.White;
            this.lblFrom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblFrom.ImageKey = "(none)";
            this.lblFrom.Location = new System.Drawing.Point(212, 8);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(72, 30);
            this.lblFrom.TabIndex = 16;
            this.lblFrom.Text = "From";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitle.ImageKey = "(none)";
            this.lblTitle.Location = new System.Drawing.Point(608, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(60, 30);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbSeeDetail
            // 
            this.pbSeeDetail.BackColor = System.Drawing.Color.White;
            this.pbSeeDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSeeDetail.Image = global::FindJobApplication.Properties.Resources.eye;
            this.pbSeeDetail.Location = new System.Drawing.Point(1399, 6);
            this.pbSeeDetail.Name = "pbSeeDetail";
            this.pbSeeDetail.Size = new System.Drawing.Size(79, 34);
            this.pbSeeDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeeDetail.TabIndex = 19;
            this.pbSeeDetail.TabStop = false;
            this.pbSeeDetail.Click += new System.EventHandler(this.pbSeeDetail_Click);
            // 
            // UCMailRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTopTableApplyJob);
            this.Name = "UCMailRow";
            this.Size = new System.Drawing.Size(1497, 49);
            this.pnlTopTableApplyJob.ResumeLayout(false);
            this.pnlTopTableApplyJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeeDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel pnlTopTableApplyJob;
        private Guna.UI.WinForms.GunaLabel lblTime;
        private Guna.UI.WinForms.GunaLabel lblFrom;
        private Guna.UI.WinForms.GunaLabel lblID;
        private Guna.UI.WinForms.GunaLabel lblTitle;
        private System.Windows.Forms.PictureBox pbSeeDetail;
    }
}
