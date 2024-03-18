namespace FindJobApplication
{
    partial class UCUserProfileSkill
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
            this.btnSkill = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnSkill
            // 
            this.btnSkill.BackColor = System.Drawing.Color.White;
            this.btnSkill.BorderRadius = 20;
            this.btnSkill.BorderThickness = 1;
            this.btnSkill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSkill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSkill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSkill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSkill.FillColor = System.Drawing.Color.White;
            this.btnSkill.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkill.ForeColor = System.Drawing.Color.Black;
            this.btnSkill.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSkill.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnSkill.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSkill.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSkill.Location = new System.Drawing.Point(3, 3);
            this.btnSkill.Name = "btnSkill";
            this.btnSkill.Size = new System.Drawing.Size(117, 45);
            this.btnSkill.TabIndex = 0;
            this.btnSkill.Text = ".Net";
            // 
            // UCUserProfileSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSkill);
            this.Name = "UCUserProfileSkill";
            this.Size = new System.Drawing.Size(124, 52);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSkill;
    }
}
