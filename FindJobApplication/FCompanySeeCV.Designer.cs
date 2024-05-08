namespace FindJobApplication
{
    partial class FCompanySeeCV
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
            this.pBFile = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBFile)).BeginInit();
            this.SuspendLayout();
            // 
            // pBFile
            // 
            this.pBFile.Image = global::FindJobApplication.Properties.Resources.CV;
            this.pBFile.ImageRotate = 0F;
            this.pBFile.Location = new System.Drawing.Point(46, 25);
            this.pBFile.Name = "pBFile";
            this.pBFile.Size = new System.Drawing.Size(566, 669);
            this.pBFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBFile.TabIndex = 0;
            this.pBFile.TabStop = false;
            // 
            // FCompanySeeCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(681, 717);
            this.Controls.Add(this.pBFile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FCompanySeeCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.FCompanySeeCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pBFile;
    }
}