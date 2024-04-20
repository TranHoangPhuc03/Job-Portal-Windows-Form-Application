using System.Windows.Forms;

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
            this.cbExperience = new Guna.UI.WinForms.GunaComboBox();
            this.cbLocation = new Guna.UI.WinForms.GunaComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.pnlListJob = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pnlListJob
            // 
            this.pnlListJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListJob.AutoScroll = true;
            this.pnlListJob.Location = new System.Drawing.Point(20, 94);
            this.pnlListJob.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlListJob.Name = "pnlListJob";
            this.pnlListJob.Size = new System.Drawing.Size(1144, 818);
            this.pnlListJob.TabIndex = 41;
            // 
            // cbExperience
            // 
            this.cbExperience.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExperience.BackColor = System.Drawing.Color.Transparent;
            this.cbExperience.BaseColor = System.Drawing.Color.White;
            this.cbExperience.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.cbExperience.BorderSize = 1;
            this.cbExperience.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExperience.FocusedColor = System.Drawing.Color.Empty;
            this.cbExperience.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExperience.ForeColor = System.Drawing.Color.Black;
            this.cbExperience.FormattingEnabled = true;
            this.cbExperience.ItemHeight = 38;
            this.cbExperience.Items.AddRange(new object[] {
            "All experience",
            "< 1 year experience",
            "1 - 2 year experience",
            "2 - 3 year experience",
            "> 3 year experience"});
            this.cbExperience.Location = new System.Drawing.Point(474, 18);
            this.cbExperience.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbExperience.Name = "cbExperience";
            this.cbExperience.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbExperience.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbExperience.Radius = 4;
            this.cbExperience.Size = new System.Drawing.Size(224, 44);
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
            this.cbLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.cbLocation.BorderSize = 1;
            this.cbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FocusedColor = System.Drawing.Color.Empty;
            this.cbLocation.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocation.ForeColor = System.Drawing.Color.Black;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.IntegralHeight = false;
            this.cbLocation.ItemHeight = 38;
            this.cbLocation.Items.AddRange(new object[] {
            "All  location",
            "Ho Chi Minh City"});
            this.cbLocation.Location = new System.Drawing.Point(752, 18);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbLocation.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbLocation.Radius = 4;
            this.cbLocation.Size = new System.Drawing.Size(218, 44);
            this.cbLocation.StartIndex = 0;
            this.cbLocation.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.txtSearch.BorderRadius = 4;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::FindJobApplication.Properties.Resources.find;
            this.txtSearch.Location = new System.Drawing.Point(20, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search (Ex: Java, C#, Backend, ...)";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(400, 43);
            this.txtSearch.TabIndex = 42;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 4;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Inter SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnSearch.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearch.ImageSize = new System.Drawing.Size(32, 32);
            this.btnSearch.Location = new System.Drawing.Point(1024, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 40);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.Text = "Search";
            // 
            // pnlListJob
            // 
            this.pnlListJob.AutoScroll = true;
            this.pnlListJob.Location = new System.Drawing.Point(20, 119);
            this.pnlListJob.Margin = new System.Windows.Forms.Padding(0);
            this.pnlListJob.Name = "pnlListJob";
            this.pnlListJob.Size = new System.Drawing.Size(1144, 816);
            this.pnlListJob.TabIndex = 44;
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlListJob);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.cbExperience);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(1184, 935);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaComboBox cbExperience;
        private Guna.UI.WinForms.GunaComboBox cbLocation;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private FlowLayoutPanel pnlListJob;
    }
}
