namespace FindJobApplication
{
    partial class FSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.llblSignUpUser = new System.Windows.Forms.LinkLabel();
            this.lblAskSignUp = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblPresent = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pHide = new System.Windows.Forms.PictureBox();
            this.pNotHide = new System.Windows.Forms.PictureBox();
            this.llblCompanySignUp = new System.Windows.Forms.LinkLabel();
            this.lblAskCompanySignUp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNotHide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.pLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 85);
            this.panel1.TabIndex = 23;
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
            // llblSignUpUser
            // 
            this.llblSignUpUser.AutoSize = true;
            this.llblSignUpUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblSignUpUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSignUpUser.Location = new System.Drawing.Point(403, 607);
            this.llblSignUpUser.Name = "llblSignUpUser";
            this.llblSignUpUser.Size = new System.Drawing.Size(156, 30);
            this.llblSignUpUser.TabIndex = 33;
            this.llblSignUpUser.TabStop = true;
            this.llblSignUpUser.Text = "Sign in now!";
            this.llblSignUpUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignUpUser_LinkClicked);
            // 
            // lblAskSignUp
            // 
            this.lblAskSignUp.AutoSize = true;
            this.lblAskSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskSignUp.Location = new System.Drawing.Point(77, 607);
            this.lblAskSignUp.Name = "lblAskSignUp";
            this.lblAskSignUp.Size = new System.Drawing.Size(320, 30);
            this.lblAskSignUp.TabIndex = 32;
            this.lblAskSignUp.Text = "Already have an account";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Red;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(62, 534);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(560, 43);
            this.btnSignUp.TabIndex = 30;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresent.Location = new System.Drawing.Point(90, 475);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(552, 46);
            this.lblPresent.TabIndex = 29;
            this.lblPresent.Text = "I have read and agree to ITviec’s Terms & Conditions \r\nand Privacy Policy in rela" +
    "tion to my privacy information.";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIntro.Location = new System.Drawing.Point(62, 117);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(268, 34);
            this.lblIntro.TabIndex = 28;
            this.lblIntro.Text = "Welcome to IT-Job";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(62, 376);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(122, 30);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(62, 273);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 30);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(62, 424);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(560, 37);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(62, 321);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(560, 37);
            this.txtEmail.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(62, 218);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(560, 37);
            this.txtName.TabIndex = 34;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(62, 171);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 30);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(62, 479);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FindJobApplication.Properties.Resources.technology;
            this.pictureBox1.Location = new System.Drawing.Point(683, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // pHide
            // 
            this.pHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pHide.Image = global::FindJobApplication.Properties.Resources.hide;
            this.pHide.Location = new System.Drawing.Point(628, 430);
            this.pHide.Name = "pHide";
            this.pHide.Size = new System.Drawing.Size(33, 31);
            this.pHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pHide.TabIndex = 38;
            this.pHide.TabStop = false;
            this.pHide.Click += new System.EventHandler(this.pHide_Click);
            // 
            // pNotHide
            // 
            this.pNotHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pNotHide.Image = global::FindJobApplication.Properties.Resources.visible;
            this.pNotHide.Location = new System.Drawing.Point(628, 430);
            this.pNotHide.Name = "pNotHide";
            this.pNotHide.Size = new System.Drawing.Size(33, 31);
            this.pNotHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pNotHide.TabIndex = 37;
            this.pNotHide.TabStop = false;
            this.pNotHide.Click += new System.EventHandler(this.pNotHide_Click);
            // 
            // llblCompanySignUp
            // 
            this.llblCompanySignUp.AutoSize = true;
            this.llblCompanySignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblCompanySignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCompanySignUp.Location = new System.Drawing.Point(366, 652);
            this.llblCompanySignUp.Name = "llblCompanySignUp";
            this.llblCompanySignUp.Size = new System.Drawing.Size(143, 30);
            this.llblCompanySignUp.TabIndex = 42;
            this.llblCompanySignUp.TabStop = true;
            this.llblCompanySignUp.Text = "Click Here!\r\n";
            this.llblCompanySignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCompanySignUp_LinkClicked);
            // 
            // lblAskCompanySignUp
            // 
            this.lblAskCompanySignUp.AutoSize = true;
            this.lblAskCompanySignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskCompanySignUp.Location = new System.Drawing.Point(77, 652);
            this.lblAskCompanySignUp.Name = "lblAskCompanySignUp";
            this.lblAskCompanySignUp.Size = new System.Drawing.Size(283, 30);
            this.lblAskCompanySignUp.TabIndex = 41;
            this.lblAskCompanySignUp.Text = "If you are an employer";
            // 
            // FSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 703);
            this.Controls.Add(this.llblCompanySignUp);
            this.Controls.Add(this.lblAskCompanySignUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pHide);
            this.Controls.Add(this.pNotHide);
            this.Controls.Add(this.lblName);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DishplaySignUp";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNotHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.LinkLabel llblSignUpUser;
        private System.Windows.Forms.Label lblAskSignUp;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pNotHide;
        private System.Windows.Forms.PictureBox pHide;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llblCompanySignUp;
        private System.Windows.Forms.Label lblAskCompanySignUp;
    }
}