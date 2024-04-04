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
            this.pnlSocial = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUpSocial
            // 
            this.txtUpSocial.BorderRadius = 10;
            this.txtUpSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUpSocial.DefaultText = "";
            this.txtUpSocial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUpSocial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUpSocial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpSocial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUpSocial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpSocial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUpSocial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUpSocial.Location = new System.Drawing.Point(111, 17);
            this.txtUpSocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpSocial.Name = "txtUpSocial";
            this.txtUpSocial.PasswordChar = '\0';
            this.txtUpSocial.PlaceholderText = "What you\'re thinking";
            this.txtUpSocial.ReadOnly = true;
            this.txtUpSocial.SelectedText = "";
            this.txtUpSocial.Size = new System.Drawing.Size(1397, 60);
            this.txtUpSocial.TabIndex = 0;
            this.txtUpSocial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUpSocial_MouseClick);
            // 
            // pnlSocial
            // 
            this.pnlSocial.AutoScroll = true;
            this.pnlSocial.Location = new System.Drawing.Point(23, 102);
            this.pnlSocial.Name = "pnlSocial";
            this.pnlSocial.Size = new System.Drawing.Size(1510, 722);
            this.pnlSocial.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FindJobApplication.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(23, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // UCSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSocial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUpSocial);
            this.Name = "UCSocial";
            this.Size = new System.Drawing.Size(1547, 863);
            this.Load += new System.EventHandler(this.UCSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtUpSocial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel pnlSocial;
    }
}
