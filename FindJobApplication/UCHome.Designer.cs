namespace FindJobApplication
{
    partial class UCHome
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
            this.pnlListJob = new System.Windows.Forms.FlowLayoutPanel();
            this.cbSalary = new Guna.UI.WinForms.GunaComboBox();
            this.cbExperience = new Guna.UI.WinForms.GunaComboBox();
            this.cbLocation = new Guna.UI.WinForms.GunaComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // pnlListJob
            // 
            this.pnlListJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListJob.AutoScroll = true;
            this.pnlListJob.Location = new System.Drawing.Point(4, 59);
            this.pnlListJob.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlListJob.Name = "pnlListJob";
            this.pnlListJob.Size = new System.Drawing.Size(1022, 476);
            this.pnlListJob.TabIndex = 41;
            // 
            // cbSalary
            // 
            this.cbSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSalary.BackColor = System.Drawing.Color.Transparent;
            this.cbSalary.BaseColor = System.Drawing.Color.White;
            this.cbSalary.BorderColor = System.Drawing.Color.Silver;
            this.cbSalary.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSalary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSalary.FocusedColor = System.Drawing.Color.Empty;
            this.cbSalary.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSalary.ForeColor = System.Drawing.Color.Black;
            this.cbSalary.FormattingEnabled = true;
            this.cbSalary.ItemHeight = 49;
            this.cbSalary.Items.AddRange(new object[] {
            "All salary",
            "Under 1000$",
            "1000$ - 3000$",
            "3000$ - 5000$",
            "Over 5000$"});
            this.cbSalary.Location = new System.Drawing.Point(709, 7);
            this.cbSalary.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbSalary.Name = "cbSalary";
            this.cbSalary.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbSalary.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbSalary.Radius = 10;
            this.cbSalary.Size = new System.Drawing.Size(156, 55);
            this.cbSalary.StartIndex = 0;
            this.cbSalary.TabIndex = 3;
            // 
            // cbExperience
            // 
            this.cbExperience.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExperience.BackColor = System.Drawing.Color.Transparent;
            this.cbExperience.BaseColor = System.Drawing.Color.White;
            this.cbExperience.BorderColor = System.Drawing.Color.Silver;
            this.cbExperience.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExperience.FocusedColor = System.Drawing.Color.Empty;
            this.cbExperience.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExperience.ForeColor = System.Drawing.Color.Black;
            this.cbExperience.FormattingEnabled = true;
            this.cbExperience.ItemHeight = 49;
            this.cbExperience.Items.AddRange(new object[] {
            "All experience",
            "< 1 year experience",
            "1 - 2 year experience",
            "2 - 3 year experience",
            "> 3 year experience"});
            this.cbExperience.Location = new System.Drawing.Point(530, 6);
            this.cbExperience.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbExperience.Name = "cbExperience";
            this.cbExperience.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbExperience.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbExperience.Radius = 10;
            this.cbExperience.Size = new System.Drawing.Size(156, 55);
            this.cbExperience.StartIndex = 0;
            this.cbExperience.TabIndex = 2;
            // 
            // cbLocation
            // 
            this.cbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbLocation.BaseColor = System.Drawing.Color.White;
            this.cbLocation.BorderColor = System.Drawing.Color.Silver;
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FocusedColor = System.Drawing.Color.Empty;
            this.cbLocation.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.ForeColor = System.Drawing.Color.Black;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.IntegralHeight = false;
            this.cbLocation.ItemHeight = 49;
            this.cbLocation.Items.AddRange(new object[] {
            "All  location",
            "Ho Chi Minh City"});
            this.cbLocation.Location = new System.Drawing.Point(351, 7);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbLocation.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbLocation.Radius = 10;
            this.cbLocation.Size = new System.Drawing.Size(156, 55);
            this.cbLocation.StartIndex = 0;
            this.cbLocation.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::FindJobApplication.Properties.Resources.find;
            this.txtSearch.Location = new System.Drawing.Point(4, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search (Ex: Java, C#, Backend, ...)";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(323, 35);
            this.txtSearch.TabIndex = 42;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.Turquoise;
            this.btnSearch.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.BorderSize = 1;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::FindJobApplication.Properties.Resources.find1;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.Location = new System.Drawing.Point(887, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(11, 1, 2, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 10;
            this.btnSearch.Size = new System.Drawing.Size(135, 34);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSalary);
            this.Controls.Add(this.cbExperience);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.pnlListJob);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(1029, 553);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlListJob;
        private Guna.UI.WinForms.GunaComboBox cbSalary;
        private Guna.UI.WinForms.GunaComboBox cbExperience;
        private Guna.UI.WinForms.GunaComboBox cbLocation;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
