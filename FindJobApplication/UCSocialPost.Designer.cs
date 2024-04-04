namespace FindJobApplication
{
    partial class UCSocialPost
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
            this.pnlSocialPost = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI.WinForms.GunaLabel();
            this.btnSendMail = new Guna.UI2.WinForms.Guna2Button();
            this.llblName = new Guna.UI.WinForms.GunaLinkLabel();
            this.pnlSkill = new System.Windows.Forms.FlowLayoutPanel();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDatePost = new Guna.UI.WinForms.GunaLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSocialPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSocialPost
            // 
            this.pnlSocialPost.BackColor = System.Drawing.Color.White;
            this.pnlSocialPost.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSocialPost.BorderThickness = 1;
            this.pnlSocialPost.Controls.Add(this.lblTitle);
            this.pnlSocialPost.Controls.Add(this.btnSendMail);
            this.pnlSocialPost.Controls.Add(this.llblName);
            this.pnlSocialPost.Controls.Add(this.pnlSkill);
            this.pnlSocialPost.Controls.Add(this.rtxtDescription);
            this.pnlSocialPost.Controls.Add(this.lblDatePost);
            this.pnlSocialPost.Controls.Add(this.pictureBox1);
            this.pnlSocialPost.Location = new System.Drawing.Point(3, 3);
            this.pnlSocialPost.Name = "pnlSocialPost";
            this.pnlSocialPost.Size = new System.Drawing.Size(1466, 285);
            this.pnlSocialPost.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(89, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 30);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "Find job java";
            // 
            // btnSendMail
            // 
            this.btnSendMail.BorderColor = System.Drawing.Color.Silver;
            this.btnSendMail.BorderRadius = 10;
            this.btnSendMail.BorderThickness = 1;
            this.btnSendMail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSendMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSendMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSendMail.FillColor = System.Drawing.Color.OrangeRed;
            this.btnSendMail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMail.ForeColor = System.Drawing.Color.White;
            this.btnSendMail.HoverState.FillColor = System.Drawing.Color.Chocolate;
            this.btnSendMail.Location = new System.Drawing.Point(1232, 230);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(144, 45);
            this.btnSendMail.TabIndex = 38;
            this.btnSendMail.Text = "Mail";
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // llblName
            // 
            this.llblName.AutoSize = true;
            this.llblName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblName.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblName.Location = new System.Drawing.Point(90, 25);
            this.llblName.Name = "llblName";
            this.llblName.Size = new System.Drawing.Size(110, 23);
            this.llblName.TabIndex = 6;
            this.llblName.TabStop = true;
            this.llblName.Text = "David Lee";
            // 
            // pnlSkill
            // 
            this.pnlSkill.Location = new System.Drawing.Point(90, 228);
            this.pnlSkill.Name = "pnlSkill";
            this.pnlSkill.Size = new System.Drawing.Size(1050, 54);
            this.pnlSkill.TabIndex = 5;
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.BackColor = System.Drawing.Color.White;
            this.rtxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(90, 115);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.Size = new System.Drawing.Size(1289, 107);
            this.rtxtDescription.TabIndex = 4;
            this.rtxtDescription.Text = "Hello HR. I am looking for a job at Java backend positions. Below is my CV.";
            // 
            // lblDatePost
            // 
            this.lblDatePost.AutoSize = true;
            this.lblDatePost.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePost.Location = new System.Drawing.Point(90, 53);
            this.lblDatePost.Name = "lblDatePost";
            this.lblDatePost.Size = new System.Drawing.Size(112, 23);
            this.lblDatePost.TabIndex = 3;
            this.lblDatePost.Text = "2024-04-04";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FindJobApplication.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UCSocialPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSocialPost);
            this.Name = "UCSocialPost";
            this.Size = new System.Drawing.Size(1473, 291);
            this.pnlSocialPost.ResumeLayout(false);
            this.pnlSocialPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSocialPost;
        private Guna.UI.WinForms.GunaLabel lblDatePost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel pnlSkill;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private Guna.UI.WinForms.GunaLinkLabel llblName;
        private Guna.UI2.WinForms.Guna2Button btnSendMail;
        private Guna.UI.WinForms.GunaLabel lblTitle;
    }
}
