namespace FindJobApplication
{
    partial class UCUserProfileProject
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
            this.lblEndDay = new Guna.UI.WinForms.GunaLabel();
            this.lblStartDay = new Guna.UI.WinForms.GunaLabel();
            this.lblNameProject = new Guna.UI.WinForms.GunaLabel();
            this.pbDeleteProject = new System.Windows.Forms.PictureBox();
            this.pbEditProject = new System.Windows.Forms.PictureBox();
            this.lblSeeProject = new Guna.UI.WinForms.GunaLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditProject)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEndDay
            // 
            this.lblEndDay.AutoSize = true;
            this.lblEndDay.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDay.Location = new System.Drawing.Point(82, 46);
            this.lblEndDay.Name = "lblEndDay";
            this.lblEndDay.Size = new System.Drawing.Size(54, 23);
            this.lblEndDay.TabIndex = 9;
            this.lblEndDay.Text = "Now";
            // 
            // lblStartDay
            // 
            this.lblStartDay.AutoSize = true;
            this.lblStartDay.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDay.Location = new System.Drawing.Point(3, 46);
            this.lblStartDay.Name = "lblStartDay";
            this.lblStartDay.Size = new System.Drawing.Size(73, 23);
            this.lblStartDay.TabIndex = 8;
            this.lblStartDay.Text = "9-2022";
            // 
            // lblNameProject
            // 
            this.lblNameProject.AutoSize = true;
            this.lblNameProject.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProject.Location = new System.Drawing.Point(3, 14);
            this.lblNameProject.Name = "lblNameProject";
            this.lblNameProject.Size = new System.Drawing.Size(230, 23);
            this.lblNameProject.TabIndex = 6;
            this.lblNameProject.Text = "Video viewing website";
            // 
            // pbDeleteProject
            // 
            this.pbDeleteProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDeleteProject.Image = global::FindJobApplication.Properties.Resources.delete;
            this.pbDeleteProject.Location = new System.Drawing.Point(779, 14);
            this.pbDeleteProject.Name = "pbDeleteProject";
            this.pbDeleteProject.Size = new System.Drawing.Size(54, 35);
            this.pbDeleteProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDeleteProject.TabIndex = 11;
            this.pbDeleteProject.TabStop = false;
            // 
            // pbEditProject
            // 
            this.pbEditProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEditProject.Image = global::FindJobApplication.Properties.Resources.edit1;
            this.pbEditProject.Location = new System.Drawing.Point(719, 14);
            this.pbEditProject.Name = "pbEditProject";
            this.pbEditProject.Size = new System.Drawing.Size(54, 35);
            this.pbEditProject.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditProject.TabIndex = 10;
            this.pbEditProject.TabStop = false;
            // 
            // lblSeeProject
            // 
            this.lblSeeProject.AutoSize = true;
            this.lblSeeProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSeeProject.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeeProject.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblSeeProject.Location = new System.Drawing.Point(7, 73);
            this.lblSeeProject.Name = "lblSeeProject";
            this.lblSeeProject.Size = new System.Drawing.Size(121, 23);
            this.lblSeeProject.TabIndex = 12;
            this.lblSeeProject.TabStop = true;
            this.lblSeeProject.Text = "See project";
            this.lblSeeProject.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSeeProject_LinkClicked);
            // 
            // UCUserProfileProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSeeProject);
            this.Controls.Add(this.pbDeleteProject);
            this.Controls.Add(this.pbEditProject);
            this.Controls.Add(this.lblEndDay);
            this.Controls.Add(this.lblStartDay);
            this.Controls.Add(this.lblNameProject);
            this.Name = "UCUserProfileProject";
            this.Size = new System.Drawing.Size(836, 115);
            ((System.ComponentModel.ISupportInitialize)(this.pbDeleteProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lblEndDay;
        private Guna.UI.WinForms.GunaLabel lblStartDay;
        private Guna.UI.WinForms.GunaLabel lblNameProject;
        private Guna.UI.WinForms.GunaLinkLabel lblSeeProject;
        public System.Windows.Forms.PictureBox pbDeleteProject;
        public System.Windows.Forms.PictureBox pbEditProject;
    }
}
