namespace projectshop
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.Admin = new Guna.UI2.WinForms.Guna2Button();
            this.Customer = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.AutoRoundedCorners = true;
            this.Admin.BackColor = System.Drawing.Color.Transparent;
            this.Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Admin.BorderRadius = 66;
            this.Admin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Admin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Admin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Admin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Admin.FillColor = System.Drawing.SystemColors.Desktop;
            this.Admin.Font = new System.Drawing.Font("LilyUPC", 48F, System.Drawing.FontStyle.Bold);
            this.Admin.ForeColor = System.Drawing.Color.White;
            this.Admin.Location = new System.Drawing.Point(495, 728);
            this.Admin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Admin.Name = "Admin";
            this.Admin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Admin.Size = new System.Drawing.Size(506, 135);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "แอดมิน";
            this.Admin.UseTransparentBackground = true;
            this.Admin.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Customer
            // 
            this.Customer.AutoRoundedCorners = true;
            this.Customer.BackColor = System.Drawing.Color.Transparent;
            this.Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Customer.BorderRadius = 68;
            this.Customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Customer.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.Customer.Font = new System.Drawing.Font("LilyUPC", 48F, System.Drawing.FontStyle.Bold);
            this.Customer.ForeColor = System.Drawing.Color.White;
            this.Customer.Location = new System.Drawing.Point(495, 511);
            this.Customer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Customer.Name = "Customer";
            this.Customer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Customer.Size = new System.Drawing.Size(506, 138);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "ลูกค้า";
            this.Customer.UseTransparentBackground = true;
            this.Customer.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1512, 1109);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Admin);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Admin;
        private Guna.UI2.WinForms.Guna2Button Customer;
    }
}

