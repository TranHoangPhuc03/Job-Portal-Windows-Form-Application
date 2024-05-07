namespace FindJobApplication
{
    partial class UCScheduleDay
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
            this.pnlDay = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblCountEvent = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.pnlDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDay
            // 
            this.pnlDay.BorderRadius = 10;
            this.pnlDay.Controls.Add(this.lblCountEvent);
            this.pnlDay.Controls.Add(this.lblDay);
            this.pnlDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDay.Location = new System.Drawing.Point(3, 3);
            this.pnlDay.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDay.Name = "pnlDay";
            this.pnlDay.Size = new System.Drawing.Size(94, 92);
            this.pnlDay.TabIndex = 0;
            this.pnlDay.Click += new System.EventHandler(this.pnlDay_Click);
            // 
            // lblCountEvent
            // 
            this.lblCountEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountEvent.AutoSize = true;
            this.lblCountEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblCountEvent.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountEvent.ForeColor = System.Drawing.Color.Coral;
            this.lblCountEvent.Location = new System.Drawing.Point(29, 53);
            this.lblCountEvent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountEvent.Name = "lblCountEvent";
            this.lblCountEvent.Size = new System.Drawing.Size(34, 23);
            this.lblCountEvent.TabIndex = 5;
            this.lblCountEvent.Text = "00";
            this.lblCountEvent.Visible = false;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.Transparent;
            this.lblDay.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(29, 8);
            this.lblDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(57, 39);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "00";
            // 
            // UCScheduleDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.Controls.Add(this.pnlDay);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCScheduleDay";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(100, 98);
            this.pnlDay.ResumeLayout(false);
            this.pnlDay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblCountEvent;
    }
}
