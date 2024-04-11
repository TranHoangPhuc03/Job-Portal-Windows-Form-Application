namespace FindJobApplication
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pLogo = new System.Windows.Forms.PictureBox();
            this.pExit = new System.Windows.Forms.PictureBox();
            this.llblSignUpUser = new System.Windows.Forms.LinkLabel();
            this.lblAskSignUp = new System.Windows.Forms.Label();
            this.llblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPresent = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pPictureLogin = new System.Windows.Forms.PictureBox();
            this.pHide = new System.Windows.Forms.PictureBox();
            this.pNotHide = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPictureLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNotHide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.pLogo);
            this.panel1.Controls.Add(this.pExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 85);
            this.panel1.TabIndex = 11;
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
            // pExit
            // 
            this.pExit.Image = global::FindJobApplication.Properties.Resources.close;
            this.pExit.Location = new System.Drawing.Point(1022, 12);
            this.pExit.Name = "pExit";
            this.pExit.Size = new System.Drawing.Size(52, 35);
            this.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pExit.TabIndex = 22;
            this.pExit.TabStop = false;
            this.pExit.Click += new System.EventHandler(this.pExit_Click);
            // 
            // llblSignUpUser
            // 
            this.llblSignUpUser.AutoSize = true;
            this.llblSignUpUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblSignUpUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSignUpUser.Location = new System.Drawing.Point(812, 489);
            this.llblSignUpUser.Name = "llblSignUpUser";
            this.llblSignUpUser.Size = new System.Drawing.Size(166, 30);
            this.llblSignUpUser.TabIndex = 21;
            this.llblSignUpUser.TabStop = true;
            this.llblSignUpUser.Text = "Sign up now!";
            this.llblSignUpUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignUpUser_LinkClicked);
            // 
            // lblAskSignUp
            // 
            this.lblAskSignUp.AutoSize = true;
            this.lblAskSignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAskSignUp.Location = new System.Drawing.Point(482, 489);
            this.lblAskSignUp.Name = "lblAskSignUp";
            this.lblAskSignUp.Size = new System.Drawing.Size(323, 30);
            this.lblAskSignUp.TabIndex = 20;
            this.lblAskSignUp.Text = "Do not have an account?";
            // 
            // llblForgotPassword
            // 
            this.llblForgotPassword.AutoSize = true;
            this.llblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llblForgotPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblForgotPassword.Location = new System.Drawing.Point(816, 349);
            this.llblForgotPassword.Name = "llblForgotPassword";
            this.llblForgotPassword.Size = new System.Drawing.Size(204, 30);
            this.llblForgotPassword.TabIndex = 19;
            this.llblForgotPassword.TabStop = true;
            this.llblForgotPassword.Text = "Forgot Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(111)))), ((int)(((byte)(245)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(460, 443);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(560, 43);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresent.Location = new System.Drawing.Point(456, 160);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(564, 46);
            this.lblPresent.TabIndex = 17;
            this.lblPresent.Text = "By signing in, you agree to IT-Job Terms & Conditions \r\nand Privacy Policy in rel" +
    "ation to your privacy information.";
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIntro.Location = new System.Drawing.Point(454, 112);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(268, 34);
            this.lblIntro.TabIndex = 16;
            this.lblIntro.Text = "Welcome to IT-Job";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(454, 349);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(122, 30);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(454, 240);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 30);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(460, 383);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(560, 36);
            this.txtPassword.TabIndex = 13;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(460, 272);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(560, 37);
            this.txtUsername.TabIndex = 12;
            // 
            // pPictureLogin
            // 
            this.pPictureLogin.Image = global::FindJobApplication.Properties.Resources.data_science;
            this.pPictureLogin.Location = new System.Drawing.Point(18, 160);
            this.pPictureLogin.Name = "pPictureLogin";
            this.pPictureLogin.Size = new System.Drawing.Size(400, 345);
            this.pPictureLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPictureLogin.TabIndex = 22;
            this.pPictureLogin.TabStop = false;
            // 
            // pHide
            // 
            this.pHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pHide.Image = global::FindJobApplication.Properties.Resources.hide;
            this.pHide.Location = new System.Drawing.Point(1028, 389);
            this.pHide.Name = "pHide";
            this.pHide.Size = new System.Drawing.Size(33, 31);
            this.pHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pHide.TabIndex = 40;
            this.pHide.TabStop = false;
            this.pHide.Click += new System.EventHandler(this.pHide_Click);
            // 
            // pNotHide
            // 
            this.pNotHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pNotHide.Image = global::FindJobApplication.Properties.Resources.visible;
            this.pNotHide.Location = new System.Drawing.Point(1028, 389);
            this.pNotHide.Name = "pNotHide";
            this.pNotHide.Size = new System.Drawing.Size(33, 31);
            this.pNotHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pNotHide.TabIndex = 39;
            this.pNotHide.TabStop = false;
            this.pNotHide.Click += new System.EventHandler(this.pNotHide_Click);
            // 
            // FLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 591);
            this.Controls.Add(this.pHide);
            this.Controls.Add(this.pNotHide);
            this.Controls.Add(this.pPictureLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llblSignUpUser);
            this.Controls.Add(this.lblAskSignUp);
            this.Controls.Add(this.llblForgotPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPresent);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DishplayLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPictureLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pNotHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llblSignUpUser;
        private System.Windows.Forms.Label lblAskSignUp;
        private System.Windows.Forms.LinkLabel llblForgotPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pExit;
        private System.Windows.Forms.PictureBox pPictureLogin;
        private System.Windows.Forms.PictureBox pLogo;
        private System.Windows.Forms.PictureBox pHide;
        private System.Windows.Forms.PictureBox pNotHide;
    }
}

