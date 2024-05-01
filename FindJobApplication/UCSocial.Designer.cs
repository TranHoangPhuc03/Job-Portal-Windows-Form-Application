namespace FindJobApplication
{
    partial class UCSocial
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
            this.txtUpSocial = new Guna.UI2.WinForms.Guna2TextBox();
            this.pBAvatar = new System.Windows.Forms.PictureBox();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pnlSocial = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pBAvatar)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUpSocial
            // 
            this.txtUpSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpSocial.BorderRadius = 20;
            this.txtUpSocial.BorderThickness = 0;
            this.txtUpSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpSocial.DefaultText = "";
            this.txtUpSocial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpSocial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpSocial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpSocial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpSocial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.txtUpSocial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpSocial.Font = new System.Drawing.Font("Inter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtUpSocial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpSocial.Location = new System.Drawing.Point(96, 15);
            this.txtUpSocial.Margin = new System.Windows.Forms.Padding(7);
            this.txtUpSocial.Name = "txtUpSocial";
            this.txtUpSocial.PasswordChar = '\0';
            this.txtUpSocial.PlaceholderText = "What\'s on your mind?";
            this.txtUpSocial.ReadOnly = true;
            this.txtUpSocial.SelectedText = "";
            this.txtUpSocial.Size = new System.Drawing.Size(1050, 50);
            this.txtUpSocial.TabIndex = 0;
            this.txtUpSocial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpSocial_MouseClick);
            // 
            // pBAvatar
            // 
            this.pBAvatar.Image = global::FindJobApplication.Properties.Resources.man;
            this.pBAvatar.Location = new System.Drawing.Point(24, 15);
            this.pBAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pBAvatar.Name = "pBAvatar";
            this.pBAvatar.Size = new System.Drawing.Size(50, 50);
            this.pBAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBAvatar.TabIndex = 1;
            this.pBAvatar.TabStop = false;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 10;
            this.guna2CustomGradientPanel1.Controls.Add(this.pBAvatar);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtUpSocial);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1174, 80);
            this.guna2CustomGradientPanel1.TabIndex = 3;
            // 
            // pnlSocial
            // 
            this.pnlSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSocial.AutoScroll = true;
            this.pnlSocial.BackColor = System.Drawing.Color.White;
            this.pnlSocial.ColumnCount = 1;
            this.pnlSocial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSocial.Location = new System.Drawing.Point(0, 92);
            this.pnlSocial.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSocial.Name = "pnlSocial";
            this.pnlSocial.RowCount = 1;
            this.pnlSocial.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlSocial.Size = new System.Drawing.Size(1184, 843);
            this.pnlSocial.TabIndex = 4;
            // 
            // UCSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlSocial);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCSocial";
            this.Size = new System.Drawing.Size(1184, 935);
            this.Load += new System.EventHandler(this.UCSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBAvatar)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtUpSocial;
        private System.Windows.Forms.PictureBox pBAvatar;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.TableLayoutPanel pnlSocial;
    }
}
