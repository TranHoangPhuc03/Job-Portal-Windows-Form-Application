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
            this.pnlJob = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNameCompany = new Guna.UI.WinForms.GunaLinkLabel();
            this.btnApply = new Guna.UI.WinForms.GunaButton();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lLblNameJob = new Guna.UI.WinForms.GunaLinkLabel();
            this.pBCompany = new Guna.UI.WinForms.GunaPictureBox();
            this.pnlJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlJob
            // 
            this.pnlJob.BackColor = System.Drawing.Color.White;
            this.pnlJob.BorderColor = System.Drawing.Color.Silver;
            this.pnlJob.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.pnlJob.BorderThickness = 1;
            this.pnlJob.Controls.Add(this.lblNameCompany);
            this.pnlJob.Controls.Add(this.btnApply);
            this.pnlJob.Controls.Add(this.pbSave);
            this.pnlJob.Controls.Add(this.lblSalary);
            this.pnlJob.Controls.Add(this.pictureBox3);
            this.pnlJob.Controls.Add(this.lblLocation);
            this.pnlJob.Controls.Add(this.pictureBox2);
            this.pnlJob.Controls.Add(this.pictureBox1);
            this.pnlJob.Controls.Add(this.lLblNameJob);
            this.pnlJob.Controls.Add(this.pBCompany);
            this.pnlJob.Location = new System.Drawing.Point(0, 3);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(739, 162);
            this.pnlJob.TabIndex = 0;
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCompany.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblNameCompany.Location = new System.Drawing.Point(182, 50);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(176, 23);
            this.lblNameCompany.TabIndex = 22;
            this.lblNameCompany.TabStop = true;
            this.lblNameCompany.Text = "Name Company";
            this.lblNameCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNameCompany_LinkClicked);
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
            this.btnApply.Location = new System.Drawing.Point(486, 110);
            this.btnApply.Name = "btnApply";
            this.btnApply.OnHoverBaseColor = System.Drawing.Color.Chocolate;
            this.btnApply.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnApply.OnHoverForeColor = System.Drawing.Color.White;
            this.btnApply.OnHoverImage = null;
            this.btnApply.OnPressedColor = System.Drawing.Color.Black;
            this.btnApply.Radius = 10;
            this.btnApply.Size = new System.Drawing.Size(151, 44);
            this.btnApply.TabIndex = 21;
            this.btnApply.Text = "Apply now";
            this.btnApply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pbSave
            // 
            this.pbSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSave.Image = global::FindJobApplication.Properties.Resources.like;
            this.pbSave.Location = new System.Drawing.Point(646, 110);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(74, 44);
            this.pbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSave.TabIndex = 20;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblSalary.Location = new System.Drawing.Point(637, 16);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(62, 21);
            this.lblSalary.TabIndex = 19;
            this.lblSalary.Text = "Salary";
            this.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::FindJobApplication.Properties.Resources.dollar;
            this.pictureBox3.InitialImage = global::FindJobApplication.Properties.Resources.building;
            this.pictureBox3.Location = new System.Drawing.Point(592, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(182, 91);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(87, 21);
            this.lblLocation.TabIndex = 17;
            this.lblLocation.Text = "Loaction";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FindJobApplication.Properties.Resources.location;
            this.pictureBox2.InitialImage = global::FindJobApplication.Properties.Resources.building;
            this.pictureBox2.Location = new System.Drawing.Point(137, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FindJobApplication.Properties.Resources.building;
            this.pictureBox1.InitialImage = global::FindJobApplication.Properties.Resources.building;
            this.pictureBox1.Location = new System.Drawing.Point(137, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lLblNameJob
            // 
            this.lLblNameJob.AutoSize = true;
            this.lLblNameJob.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLblNameJob.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lLblNameJob.Location = new System.Drawing.Point(182, 16);
            this.lLblNameJob.Name = "lLblNameJob";
            this.lLblNameJob.Size = new System.Drawing.Size(114, 23);
            this.lLblNameJob.TabIndex = 14;
            this.lLblNameJob.TabStop = true;
            this.lLblNameJob.Text = "Name Job";
            this.lLblNameJob.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLblNameJob_LinkClicked);
            // 
            // pBCompany
            // 
            this.pBCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pBCompany.BaseColor = System.Drawing.Color.White;
            this.pBCompany.Image = global::FindJobApplication.Properties.Resources.job_search;
            this.pBCompany.Location = new System.Drawing.Point(19, 16);
            this.pBCompany.Name = "pBCompany";
            this.pBCompany.Size = new System.Drawing.Size(79, 102);
            this.pBCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBCompany.TabIndex = 13;
            this.pBCompany.TabStop = false;
            // 
            // UCJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlJob);
            this.Name = "UCJob";
            this.Size = new System.Drawing.Size(742, 168);
            this.pnlJob.ResumeLayout(false);
            this.pnlJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlJob;
        private Guna.UI.WinForms.GunaLinkLabel lblNameCompany;
        private Guna.UI.WinForms.GunaButton btnApply;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLinkLabel lLblNameJob;
        private Guna.UI.WinForms.GunaPictureBox pBCompany;
    }
}
