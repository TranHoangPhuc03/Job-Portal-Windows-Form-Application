namespace FindJobApplication
{
    partial class FCompanySignUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCompanySignUp));
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pHide = new System.Windows.Forms.PictureBox();
            this.pNotHide = new System.Windows.Forms.PictureBox();
            this.lblNameCompany = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llblSignUpUser = new System.Windows.Forms.LinkLabel();
            this.lblAskSignUp = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblPresent = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTaxCode = new System.Windows.Forms.Label();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.lblBusinessLicense = new System.Windows.Forms.Label();
            this.btnChooseFile = new Guna.UI2.WinForms.Guna2Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNotHide)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLogo
            // 
            this.pLogo.Image = global::FindJobApplication.Properties.Resources.job;
            this.pLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pLogo.InitialImage")));
            this.pLogo.Location = new System.Drawing.Point(12, 12);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(135, 62);
            this.pLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pLogo.TabIndex = 23;
            this.pLogo.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(62, 461);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pHide
            // 
            this.pHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pHide.Image = global::FindJobApplication.Properties.Resources.hide;
            this.pHide.Location = new System.Drawing.Point(506, 412);
            this.pHide.Name = "pHide";
            this.pHide.Size = new System.Drawing.Size(33, 31);
            this.pHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pHide.TabIndex = 56;
            this.pHide.TabStop = false;
            this.pHide.Click += new System.EventHandler(this.pHide_Click_1);
            // 
            // pNotHide
            // 
            this.pNotHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pNotHide.Image = global::FindJobApplication.Properties.Resources.visible;
            this.pNotHide.Location = new System.Drawing.Point(506, 412);
            this.pNotHide.Name = "pNotHide";
            this.pNotHide.Size = new System.Drawing.Size(33, 31);
            this.pNotHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pNotHide.TabIndex = 55;
            this.pNotHide.TabStop = false;
            this.pNotHide.Click += new System.EventHandler(this.pNotHide_Click);
            // 
            // lblNameCompany
            // 
            this.lblNameCompany.AutoSize = true;
            this.lblNameCompany.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCompany.Location = new System.Drawing.Point(63, 153);
            this.lblNameCompany.Name = "lblNameCompany";
            this.lblNameCompany.Size = new System.Drawing.Size(214, 30);
            this.lblNameCompany.TabIndex = 54;
            this.lblNameCompany.Text = "Name Company";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(63, 200);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(438, 37);
            this.txtName.TabIndex = 53;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.pLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 85);
            this.panel1.TabIndex = 43;
            // 
            // llblSignUpUser
            // 
            this.llblSignUpUser.AutoSize = true;
            this.llblSignUpUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblSignUpUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSignUpUser.Location = new System.Drawing.Point(403, 589);
            this.llblSignUpUser.Name = "llblSignUpUser";
            this.llblSignUpUser.Size = new System.Drawing.Size(156, 30);
            this.llblSignUpUser.TabIndex = 52;
            this.llblSignUpUser.TabStop = true;
            this.llblSignUpUser.Text = "Sign in now!";
            this.llblSignUpUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignUpUser_LinkClicked);
            // 
            // lblAskSignUp
            // 
            this.lblAskSignUp.AutoSize = true;
            this.lblAskSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskSignUp.Location = new System.Drawing.Point(77, 589);
            this.lblAskSignUp.Name = "lblAskSignUp";
            this.lblAskSignUp.Size = new System.Drawing.Size(320, 30);
            this.lblAskSignUp.TabIndex = 51;
            this.lblAskSignUp.Text = "Already have an account";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Red;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(62, 516);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(560, 43);
            this.btnSignUp.TabIndex = 50;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresent.Location = new System.Drawing.Point(90, 457);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(552, 46);
            this.lblPresent.TabIndex = 49;
            this.lblPresent.Text = "I have read and agree to ITviec’s Terms & Conditions \r\nand Privacy Policy in rela" +
    "tion to my privacy information.";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIntro.Location = new System.Drawing.Point(62, 99);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(268, 34);
            this.lblIntro.TabIndex = 48;
            this.lblIntro.Text = "Welcome to IT-Job";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(62, 358);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(122, 30);
            this.lblPassword.TabIndex = 47;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(544, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 30);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(62, 406);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(438, 37);
            this.txtPassword.TabIndex = 45;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(544, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(438, 37);
            this.txtEmail.TabIndex = 44;
            // 
            // lblTaxCode
            // 
            this.lblTaxCode.AutoSize = true;
            this.lblTaxCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxCode.Location = new System.Drawing.Point(63, 256);
            this.lblTaxCode.Name = "lblTaxCode";
            this.lblTaxCode.Size = new System.Drawing.Size(123, 30);
            this.lblTaxCode.TabIndex = 59;
            this.lblTaxCode.Text = "Tax code";
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxCode.Location = new System.Drawing.Point(63, 303);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(438, 37);
            this.txtTaxCode.TabIndex = 58;
            // 
            // lblBusinessLicense
            // 
            this.lblBusinessLicense.AutoSize = true;
            this.lblBusinessLicense.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessLicense.Location = new System.Drawing.Point(544, 256);
            this.lblBusinessLicense.Name = "lblBusinessLicense";
            this.lblBusinessLicense.Size = new System.Drawing.Size(206, 30);
            this.lblBusinessLicense.TabIndex = 61;
            this.lblBusinessLicense.Text = "Business License";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseFile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseFile.FillColor = System.Drawing.Color.LightGray;
            this.btnChooseFile.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile.ForeColor = System.Drawing.Color.Black;
            this.btnChooseFile.HoverState.FillColor = System.Drawing.Color.Silver;
            this.btnChooseFile.Location = new System.Drawing.Point(544, 303);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(140, 37);
            this.btnChooseFile.TabIndex = 62;
            this.btnChooseFile.Text = "Choose file";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(702, 306);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(259, 30);
            this.lblStatus.TabIndex = 63;
            this.lblStatus.Text = "There are no files yet";
            // 
            // FCompanySignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 657);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.lblBusinessLicense);
            this.Controls.Add(this.lblTaxCode);
            this.Controls.Add(this.txtTaxCode);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pHide);
            this.Controls.Add(this.pNotHide);
            this.Controls.Add(this.lblNameCompany);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llblSignUpUser);
            this.Controls.Add(this.lblAskSignUp);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblPresent);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCompanySignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FConpanySignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNotHide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pHide;
        private System.Windows.Forms.PictureBox pNotHide;
        private System.Windows.Forms.Label lblNameCompany;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llblSignUpUser;
        private System.Windows.Forms.Label lblAskSignUp;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTaxCode;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.Label lblBusinessLicense;
        private Guna.UI2.WinForms.Guna2Button btnChooseFile;
        private System.Windows.Forms.Label lblStatus;
    }
}