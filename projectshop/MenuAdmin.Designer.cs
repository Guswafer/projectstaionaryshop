namespace projectshop
{
    partial class MenuAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.manageorderBut1 = new Guna.UI2.WinForms.Guna2Button();
            this.LogoutBut = new Guna.UI2.WinForms.Guna2Button();
            this.ReportBut = new Guna.UI2.WinForms.Guna2Button();
            this.CartBut = new Guna.UI2.WinForms.Guna2Button();
            this.MemberBut = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 85);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projectshop.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.manageorderBut1);
            this.panel2.Controls.Add(this.LogoutBut);
            this.panel2.Controls.Add(this.ReportBut);
            this.panel2.Controls.Add(this.CartBut);
            this.panel2.Controls.Add(this.MemberBut);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 67);
            this.panel2.TabIndex = 2;
            // 
            // manageorderBut1
            // 
            this.manageorderBut1.BorderColor = System.Drawing.Color.Empty;
            this.manageorderBut1.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.manageorderBut1.CheckedState.FillColor = System.Drawing.Color.White;
            this.manageorderBut1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.manageorderBut1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageorderBut1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageorderBut1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageorderBut1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageorderBut1.FillColor = System.Drawing.Color.White;
            this.manageorderBut1.FocusedColor = System.Drawing.Color.Black;
            this.manageorderBut1.Font = new System.Drawing.Font("LilyUPC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageorderBut1.ForeColor = System.Drawing.Color.Black;
            this.manageorderBut1.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.manageorderBut1.Location = new System.Drawing.Point(0, 3);
            this.manageorderBut1.Name = "manageorderBut1";
            this.manageorderBut1.Size = new System.Drawing.Size(234, 61);
            this.manageorderBut1.TabIndex = 5;
            this.manageorderBut1.Text = "จัดการคำสั่งซื้อ";
            this.manageorderBut1.Click += new System.EventHandler(this.AdminBut1_Click);
            // 
            // LogoutBut
            // 
            this.LogoutBut.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.LogoutBut.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.LogoutBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LogoutBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LogoutBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LogoutBut.FillColor = System.Drawing.Color.White;
            this.LogoutBut.FocusedColor = System.Drawing.Color.Black;
            this.LogoutBut.Font = new System.Drawing.Font("LilyUPC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBut.ForeColor = System.Drawing.Color.Black;
            this.LogoutBut.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.LogoutBut.Location = new System.Drawing.Point(1018, 3);
            this.LogoutBut.Name = "LogoutBut";
            this.LogoutBut.Size = new System.Drawing.Size(243, 61);
            this.LogoutBut.TabIndex = 4;
            this.LogoutBut.Text = "ออกจากระบบ";
            this.LogoutBut.Click += new System.EventHandler(this.LogoutBut_Click);
            // 
            // ReportBut
            // 
            this.ReportBut.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.ReportBut.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ReportBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ReportBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ReportBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ReportBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ReportBut.FillColor = System.Drawing.Color.White;
            this.ReportBut.FocusedColor = System.Drawing.Color.Black;
            this.ReportBut.Font = new System.Drawing.Font("LilyUPC", 26.25F, System.Drawing.FontStyle.Bold);
            this.ReportBut.ForeColor = System.Drawing.Color.Black;
            this.ReportBut.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.ReportBut.Location = new System.Drawing.Point(790, 3);
            this.ReportBut.Name = "ReportBut";
            this.ReportBut.Size = new System.Drawing.Size(234, 61);
            this.ReportBut.TabIndex = 3;
            this.ReportBut.Text = "สรุปยอดขาย";
            this.ReportBut.Click += new System.EventHandler(this.ReportBut_Click);
            // 
            // CartBut
            // 
            this.CartBut.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.CartBut.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.CartBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CartBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CartBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CartBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CartBut.FillColor = System.Drawing.Color.White;
            this.CartBut.FocusedColor = System.Drawing.Color.Black;
            this.CartBut.Font = new System.Drawing.Font("LilyUPC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartBut.ForeColor = System.Drawing.Color.Black;
            this.CartBut.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.CartBut.Location = new System.Drawing.Point(522, 6);
            this.CartBut.Name = "CartBut";
            this.CartBut.Size = new System.Drawing.Size(262, 61);
            this.CartBut.TabIndex = 2;
            this.CartBut.Text = "จัดการสินค้า";
            this.CartBut.Click += new System.EventHandler(this.CartBut_Click);
            // 
            // MemberBut
            // 
            this.MemberBut.CheckedState.CustomBorderColor = System.Drawing.Color.Navy;
            this.MemberBut.CheckedState.FillColor = System.Drawing.Color.White;
            this.MemberBut.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.MemberBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MemberBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MemberBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MemberBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MemberBut.FillColor = System.Drawing.Color.White;
            this.MemberBut.FocusedColor = System.Drawing.Color.Black;
            this.MemberBut.Font = new System.Drawing.Font("LilyUPC", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberBut.ForeColor = System.Drawing.Color.Black;
            this.MemberBut.HoverState.CustomBorderColor = System.Drawing.Color.Navy;
            this.MemberBut.Location = new System.Drawing.Point(240, 3);
            this.MemberBut.Name = "MemberBut";
            this.MemberBut.Size = new System.Drawing.Size(276, 61);
            this.MemberBut.TabIndex = 1;
            this.MemberBut.Text = "จัดการบัญชีสมาชิก";
            this.MemberBut.Click += new System.EventHandler(this.MemberBut_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 152);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1262, 657);
            this.panelContainer.TabIndex = 3;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 809);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button LogoutBut;
        private Guna.UI2.WinForms.Guna2Button ReportBut;
        private Guna.UI2.WinForms.Guna2Button CartBut;
        private Guna.UI2.WinForms.Guna2Button MemberBut;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button manageorderBut1;
    }
}