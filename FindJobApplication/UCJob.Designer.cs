namespace FindJobApplication
{
    partial class UCJob
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
            this.pnlJob = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.btnApply = new Guna.UI.WinForms.GunaButton();
            this.pnlSkill = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPicture = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pBCompany = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lLblNameJob = new Guna.UI.WinForms.GunaLinkLabel();
            this.lblNameCompany = new Guna.UI.WinForms.GunaLinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.pnlJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            this.pnlPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlJob
            // 
            this.pnlJob.BackColor = System.Drawing.Color.Transparent;
            this.pnlJob.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlJob.BorderRadius = 24;
            this.pnlJob.BorderThickness = 1;
            this.pnlJob.Controls.Add(this.pictureBox3);
            this.pnlJob.Controls.Add(this.lblSalary);
            this.pnlJob.Controls.Add(this.pbSave);
            this.pnlJob.Controls.Add(this.btnApply);
            this.pnlJob.Controls.Add(this.pnlSkill);
            this.pnlJob.Controls.Add(this.pnlPicture);
            this.pnlJob.Controls.Add(this.lLblNameJob);
            this.pnlJob.Controls.Add(this.lblNameCompany);
            this.pnlJob.Controls.Add(this.pictureBox2);
            this.pnlJob.Controls.Add(this.lblLocation);
            this.pnlJob.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.pnlJob.Location = new System.Drawing.Point(4, 5);
            this.pnlJob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(826, 314);
            this.pnlJob.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::FindJobApplication.Properties.Resources.dollar_symbol;
            this.pictureBox3.InitialImage = global::FindJobApplication.Properties.Resources.building;
            this.pictureBox3.Location = new System.Drawing.Point(657, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(181)))), ((int)(((byte)(27)))));
            this.lblSalary.Location = new System.Drawing.Point(707, 21);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(61, 25);
            this.lblSalary.TabIndex = 31;
            this.lblSalary.Text = "1000";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbSave
            // 
            this.pbSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSave.Image = global::FindJobApplication.Properties.Resources.like;
            this.pbSave.Location = new System.Drawing.Point(731, 165);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(74, 45);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 32;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // btnApply
            // 
            this.btnApply.AnimationHoverSpeed = 0.07F;
            this.btnApply.AnimationSpeed = 0.03F;
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.BaseColor = System.Drawing.Color.Red;
            this.btnApply.BorderColor = System.Drawing.Color.Black;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnApply.FocusedColor = System.Drawing.Color.Empty;
            this.btnApply.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Image = null;
            this.btnApply.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnApply.ImageSize = new System.Drawing.Size(20, 20);
            this.btnApply.Location = new System.Drawing.Point(664, 241);
            this.btnApply.Name = "btnApply";
            this.btnApply.OnHoverBaseColor = System.Drawing.Color.Chocolate;
            this.btnApply.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnApply.OnHoverForeColor = System.Drawing.Color.White;
            this.btnApply.OnHoverImage = null;
            this.btnApply.OnPressedColor = System.Drawing.Color.Black;
            this.btnApply.Radius = 10;
            this.btnApply.Size = new System.Drawing.Size(141, 54);
            this.btnApply.TabIndex = 33;
            this.btnApply.Text = "Apply";
            this.btnApply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pnlSkill
            // 
            this.pnlSkill.Location = new System.Drawing.Point(327, 242);
            this.pnlSkill.Name = "pnlSkill";
            this.pnlSkill.Size = new System.Drawing.Size(325, 54);
            this.pnlSkill.TabIndex = 38;
            // 
            // pnlPicture
            // 
            this.pnlPicture.BackColor = System.Drawing.Color.White;
            this.pnlPicture.BorderRadius = 12;
            this.pnlPicture.BorderThickness = 1;
            this.pnlPicture.Controls.Add(this.pBCompany);
            this.pnlPicture.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.pnlPicture.CustomBorderThickness = new System.Windows.Forms.Padding(3);
            this.pnlPicture.Location = new System.Drawing.Point(22, 18);
            this.pnlPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(270, 277);
            this.pnlPicture.TabIndex = 29;
            // 
            // pBCompany
            // 
            this.pBCompany.BackColor = System.Drawing.Color.Transparent;
            this.pBCompany.BorderRadius = 12;
            this.pBCompany.Image = global::FindJobApplication.Properties.Resources.fpt_logo1;
            this.pBCompany.ImageRotate = 0F;
            this.pBCompany.Location = new System.Drawing.Point(0, 0);
            this.pBCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pBCompany.Name = "pBCompany";
            this.pBCompany.Size = new System.Drawing.Size(270, 277);
            this.pBCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBCompany.TabIndex = 2;
            this.pBCompany.TabStop = false;
            // 
            // lLblNameJob
            // 
            this.lLblNameJob.AutoSize = true;
            this.lLblNameJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lLblNameJob.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lLblNameJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.lLblNameJob.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lLblNameJob.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.lLblNameJob.Location = new System.Drawing.Point(327, 18);
            this.lLblNameJob.Name = "lLblNameJob";
            this.lLblNameJob.Size = new System.Drawing.Size(63, 29);
            this.lLblNameJob.TabIndex = 34;
            this.lLblNameJob.TabStop = true;
            this.lLblNameJob.Text = "Title";
            this.lLblNameJob.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblNameJob_LinkClicked);
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNameCompany.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblNameCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.lblNameCompany.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblNameCompany.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(33)))), ((int)(((byte)(56)))));
            this.lblNameCompany.Location = new System.Drawing.Point(327, 108);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(136, 19);
            this.lblNameCompany.TabIndex = 37;
            this.lblNameCompany.TabStop = true;
            this.lblNameCompany.Text = "FPT Corporation";
            this.lblNameCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNameCompany_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FindJobApplication.Properties.Resources.maps_and_flags;
            this.pictureBox2.InitialImage = global::FindJobApplication.Properties.Resources.building;
            this.pictureBox2.Location = new System.Drawing.Point(327, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.Black;
            this.lblLocation.Location = new System.Drawing.Point(370, 182);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(102, 19);
            this.lblLocation.TabIndex = 36;
            this.lblLocation.Text = "Ho Chi Minh";
            // 
            // UCJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlJob);
            this.DoubleBuffered = true;
            this.Name = "UCJob";
            this.Size = new System.Drawing.Size(834, 323);
            this.pnlJob.ResumeLayout(false);
            this.pnlJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            this.pnlPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlJob;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.PictureBox pbSave;
        private Guna.UI.WinForms.GunaButton btnApply;
        private System.Windows.Forms.FlowLayoutPanel pnlSkill;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlPicture;
        private Guna.UI2.WinForms.Guna2PictureBox pBCompany;
        private Guna.UI.WinForms.GunaLinkLabel lLblNameJob;
        private Guna.UI.WinForms.GunaLinkLabel lblNameCompany;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLocation;
    }
}
