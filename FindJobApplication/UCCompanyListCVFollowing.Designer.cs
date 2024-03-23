namespace FindJobApplication
{
    partial class UCCompanyListCVFollowing
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
            this.lblID = new Guna.UI.WinForms.GunaLabel();
            this.lblName = new Guna.UI.WinForms.GunaLabel();
            this.pnlListCVFollowing = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTopTableApplyJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopTableApplyJob
            // 
            this.pnlTopTableApplyJob.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopTableApplyJob.BaseColor = System.Drawing.Color.White;
            this.pnlTopTableApplyJob.Controls.Add(this.lblID);
            this.pnlTopTableApplyJob.Controls.Add(this.pictureBox1);
            this.pnlTopTableApplyJob.Controls.Add(this.lblName);
            this.pnlTopTableApplyJob.Location = new System.Drawing.Point(3, 2);
            this.pnlTopTableApplyJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopTableApplyJob.Name = "pnlTopTableApplyJob";
            this.pnlTopTableApplyJob.Radius = 10;
            this.pnlTopTableApplyJob.Size = new System.Drawing.Size(1535, 43);
            this.pnlTopTableApplyJob.TabIndex = 46;
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
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblName.ImageKey = "(none)";
            this.lblName.Location = new System.Drawing.Point(181, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 30);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlListCVFollowing
            // 
            this.pnlListCVFollowing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListCVFollowing.AutoScroll = true;
            this.pnlListCVFollowing.Location = new System.Drawing.Point(3, 49);
            this.pnlListCVFollowing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlListCVFollowing.Name = "pnlListCVFollowing";
            this.pnlListCVFollowing.Size = new System.Drawing.Size(1534, 740);
            this.pnlListCVFollowing.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::FindJobApplication.Properties.Resources.label;
            this.pictureBox1.Location = new System.Drawing.Point(121, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UCCompanyListCVFollowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTopTableApplyJob);
            this.Controls.Add(this.pnlListCVFollowing);
            this.Name = "UCCompanyListCVFollowing";
            this.Size = new System.Drawing.Size(1544, 851);
            this.Load += new System.EventHandler(this.UCCompanyListCVFollowing_Load);
            this.pnlTopTableApplyJob.ResumeLayout(false);
            this.pnlTopTableApplyJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel pnlTopTableApplyJob;
        private Guna.UI.WinForms.GunaLabel lblID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel lblName;
        private System.Windows.Forms.FlowLayoutPanel pnlListCVFollowing;
    }
}
