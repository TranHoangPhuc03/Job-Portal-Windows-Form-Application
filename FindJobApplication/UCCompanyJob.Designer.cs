namespace FindJobApplication
{
    partial class UCCompanyJob
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
            this.pnTupleTableJob = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCountApplied = new Guna.UI.WinForms.GunaLinkLabel();
            this.lblId = new Guna.UI.WinForms.GunaLabel();
            this.lblNameJob = new Guna.UI.WinForms.GunaLabel();
            this.lblSalary = new Guna.UI.WinForms.GunaLabel();
            this.lblExpirationDate = new Guna.UI.WinForms.GunaLabel();
            this.lblPostDate = new Guna.UI.WinForms.GunaLabel();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.pBDelete = new System.Windows.Forms.PictureBox();
            this.pnTupleTableJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTupleTableJob
            // 
            this.pnTupleTableJob.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnTupleTableJob.BorderColor = System.Drawing.Color.DarkGray;
            this.pnTupleTableJob.BorderRadius = 10;
            this.pnTupleTableJob.BorderThickness = 1;
            this.pnTupleTableJob.Controls.Add(this.lblCountApplied);
            this.pnTupleTableJob.Controls.Add(this.lblId);
            this.pnTupleTableJob.Controls.Add(this.lblNameJob);
            this.pnTupleTableJob.Controls.Add(this.lblSalary);
            this.pnTupleTableJob.Controls.Add(this.lblExpirationDate);
            this.pnTupleTableJob.Controls.Add(this.lblPostDate);
            this.pnTupleTableJob.Controls.Add(this.pbEdit);
            this.pnTupleTableJob.Controls.Add(this.pBDelete);
            this.pnTupleTableJob.FillColor = System.Drawing.Color.White;
            this.pnTupleTableJob.Location = new System.Drawing.Point(0, 0);
            this.pnTupleTableJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnTupleTableJob.Name = "pnTupleTableJob";
            this.pnTupleTableJob.Size = new System.Drawing.Size(1449, 42);
            this.pnTupleTableJob.TabIndex = 1;
            // 
            // lblCountApplied
            // 
            this.lblCountApplied.AutoSize = true;
            this.lblCountApplied.BackColor = System.Drawing.Color.White;
            this.lblCountApplied.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountApplied.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblCountApplied.Location = new System.Drawing.Point(1128, 8);
            this.lblCountApplied.Name = "lblCountApplied";
            this.lblCountApplied.Size = new System.Drawing.Size(83, 30);
            this.lblCountApplied.TabIndex = 18;
            this.lblCountApplied.TabStop = true;
            this.lblCountApplied.Text = "count";
            this.lblCountApplied.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCountApplied_LinkClicked);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.White;
            this.lblId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(18, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 30);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID";
            // 
            // lblNameJob
            // 
            this.lblNameJob.AutoSize = true;
            this.lblNameJob.BackColor = System.Drawing.Color.White;
            this.lblNameJob.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameJob.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNameJob.ImageKey = "(none)";
            this.lblNameJob.Location = new System.Drawing.Point(190, 8);
            this.lblNameJob.Name = "lblNameJob";
            this.lblNameJob.Size = new System.Drawing.Size(87, 30);
            this.lblNameJob.TabIndex = 9;
            this.lblNameJob.Text = "Name";
            this.lblNameJob.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.White;
            this.lblSalary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(908, 8);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(83, 30);
            this.lblSalary.TabIndex = 12;
            this.lblSalary.Text = "Salary";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.BackColor = System.Drawing.Color.White;
            this.lblExpirationDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.Location = new System.Drawing.Point(608, 8);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(193, 30);
            this.lblExpirationDate.TabIndex = 11;
            this.lblExpirationDate.Text = "Expiration Date";
            // 
            // lblPostDate
            // 
            this.lblPostDate.AutoSize = true;
            this.lblPostDate.BackColor = System.Drawing.Color.White;
            this.lblPostDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostDate.Location = new System.Drawing.Point(376, 8);
            this.lblPostDate.Name = "lblPostDate";
            this.lblPostDate.Size = new System.Drawing.Size(126, 30);
            this.lblPostDate.TabIndex = 10;
            this.lblPostDate.Text = "Post Date";
            // 
            // pbEdit
            // 
            this.pbEdit.BackColor = System.Drawing.Color.White;
            this.pbEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEdit.Image = global::FindJobApplication.Properties.Resources.edit1;
            this.pbEdit.Location = new System.Drawing.Point(1382, 8);
            this.pbEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(55, 31);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit.TabIndex = 5;
            this.pbEdit.TabStop = false;
            // 
            // pBDelete
            // 
            this.pBDelete.BackColor = System.Drawing.Color.White;
            this.pBDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBDelete.Image = global::FindJobApplication.Properties.Resources.delete;
            this.pBDelete.Location = new System.Drawing.Point(1320, 8);
            this.pBDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBDelete.Name = "pBDelete";
            this.pBDelete.Size = new System.Drawing.Size(55, 31);
            this.pBDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBDelete.TabIndex = 4;
            this.pBDelete.TabStop = false;
            // 
            // UCCompanyJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnTupleTableJob);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCCompanyJob";
            this.Size = new System.Drawing.Size(1449, 45);
            this.pnTupleTableJob.ResumeLayout(false);
            this.pnTupleTableJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnTupleTableJob;
        private System.Windows.Forms.PictureBox pBDelete;
        private System.Windows.Forms.PictureBox pbEdit;
        private Guna.UI.WinForms.GunaLabel lblId;
        private Guna.UI.WinForms.GunaLabel lblNameJob;
        private Guna.UI.WinForms.GunaLabel lblSalary;
        private Guna.UI.WinForms.GunaLabel lblExpirationDate;
        private Guna.UI.WinForms.GunaLabel lblPostDate;
        private Guna.UI.WinForms.GunaLinkLabel lblCountApplied;
    }
}
