namespace FindJobApplication
{
    partial class UCCompanyJobRecruitment
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
            this.pnlListJob = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRecruitment = new Guna.UI.WinForms.GunaLabel();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.lblCountJob = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // pnlListJob
            // 
            this.pnlListJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListJob.AutoScroll = true;
            this.pnlListJob.Location = new System.Drawing.Point(19, 123);
            this.pnlListJob.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlListJob.Name = "pnlListJob";
            this.pnlListJob.Size = new System.Drawing.Size(1144, 795);
            this.pnlListJob.TabIndex = 42;
            // 
            // lblRecruitment
            // 
            this.lblRecruitment.AutoSize = true;
            this.lblRecruitment.BackColor = System.Drawing.Color.White;
            this.lblRecruitment.Font = new System.Drawing.Font("Inter", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblRecruitment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.lblRecruitment.Location = new System.Drawing.Point(21, 62);
            this.lblRecruitment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecruitment.Name = "lblRecruitment";
            this.lblRecruitment.Size = new System.Drawing.Size(444, 40);
            this.lblRecruitment.TabIndex = 43;
            this.lblRecruitment.Text = "Number of job recruitment: ";
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BaseColor = System.Drawing.Color.White;
            this.btnBack.BorderColor = System.Drawing.Color.White;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = global::FindJobApplication.Properties.Resources.back;
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(18, 12);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.Red;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.White;
            this.btnBack.Size = new System.Drawing.Size(107, 36);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCountJob
            // 
            this.lblCountJob.AutoSize = true;
            this.lblCountJob.BackColor = System.Drawing.Color.White;
            this.lblCountJob.Font = new System.Drawing.Font("Inter", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCountJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.lblCountJob.Location = new System.Drawing.Point(487, 62);
            this.lblCountJob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountJob.Name = "lblCountJob";
            this.lblCountJob.Size = new System.Drawing.Size(37, 40);
            this.lblCountJob.TabIndex = 45;
            this.lblCountJob.Text = "2";
            // 
            // UCCompanyJobRecruitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblCountJob);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRecruitment);
            this.Controls.Add(this.pnlListJob);
            this.Name = "UCCompanyJobRecruitment";
            this.Size = new System.Drawing.Size(1184, 936);
            this.Load += new System.EventHandler(this.UCCompanyJobRecruitment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlListJob;
        private Guna.UI.WinForms.GunaLabel lblRecruitment;
        private Guna.UI.WinForms.GunaButton btnBack;
        private Guna.UI.WinForms.GunaLabel lblCountJob;
    }
}
