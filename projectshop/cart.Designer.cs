namespace projectshop
{
    partial class cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cart));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backbut = new Guna.UI2.WinForms.Guna2Button();
            this.ป = new Guna.UI2.WinForms.Guna2Panel();
            this.cartDataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.totalall = new Guna.UI2.WinForms.Guna2TextBox();
            this.editnum = new Guna.UI2.WinForms.Guna2Button();
            this.delproductincart = new Guna.UI2.WinForms.Guna2Button();
            this.payment = new Guna.UI2.WinForms.Guna2Button();
            this.totalpriceTextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceproductTextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.numproductTextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameproductTextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ป.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backbut
            // 
            this.backbut.AutoRoundedCorners = true;
            this.backbut.BackColor = System.Drawing.Color.Transparent;
            this.backbut.BorderRadius = 20;
            this.backbut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backbut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backbut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backbut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backbut.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbut.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.backbut.ForeColor = System.Drawing.Color.White;
            this.backbut.Location = new System.Drawing.Point(14, 2);
            this.backbut.Margin = new System.Windows.Forms.Padding(2);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(48, 42);
            this.backbut.TabIndex = 10;
            this.backbut.Text = "<";
            this.backbut.UseTransparentBackground = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // ป
            // 
            this.ป.BackColor = System.Drawing.Color.Red;
            this.ป.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ป.BackgroundImage")));
            this.ป.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ป.Controls.Add(this.cartDataGridView1);
            this.ป.Controls.Add(this.totalall);
            this.ป.Controls.Add(this.editnum);
            this.ป.Controls.Add(this.delproductincart);
            this.ป.Controls.Add(this.payment);
            this.ป.Controls.Add(this.totalpriceTextBox5);
            this.ป.Controls.Add(this.priceproductTextBox4);
            this.ป.Controls.Add(this.numproductTextBox3);
            this.ป.Controls.Add(this.nameproductTextBox2);
            this.ป.Controls.Add(this.IDTextBox1);
            this.ป.Controls.Add(this.PictureBox1);
            this.ป.ForeColor = System.Drawing.Color.Cornsilk;
            this.ป.Location = new System.Drawing.Point(0, 48);
            this.ป.Margin = new System.Windows.Forms.Padding(2);
            this.ป.Name = "ป";
            this.ป.Size = new System.Drawing.Size(1290, 589);
            this.ป.TabIndex = 0;
            this.ป.Paint += new System.Windows.Forms.PaintEventHandler(this.ป_Paint);
            // 
            // cartDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.cartDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cartDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cartDataGridView1.ColumnHeadersHeight = 20;
            this.cartDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cartDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.cartDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartDataGridView1.Location = new System.Drawing.Point(172, 368);
            this.cartDataGridView1.Name = "cartDataGridView1";
            this.cartDataGridView1.ReadOnly = true;
            this.cartDataGridView1.RowHeadersVisible = false;
            this.cartDataGridView1.RowHeadersWidth = 62;
            this.cartDataGridView1.Size = new System.Drawing.Size(987, 163);
            this.cartDataGridView1.TabIndex = 20;
            this.cartDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.cartDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.cartDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.cartDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.cartDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.cartDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.cartDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cartDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cartDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.cartDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.cartDataGridView1.ThemeStyle.HeaderStyle.Height = 20;
            this.cartDataGridView1.ThemeStyle.ReadOnly = true;
            this.cartDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.cartDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.cartDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Cornsilk;
            this.cartDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.cartDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.cartDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.cartDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartDataGridView1_CellContentClick_1);
            // 
            // totalall
            // 
            this.totalall.BorderColor = System.Drawing.Color.Azure;
            this.totalall.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalall.DefaultText = "";
            this.totalall.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalall.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalall.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalall.FillColor = System.Drawing.Color.Azure;
            this.totalall.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalall.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.totalall.ForeColor = System.Drawing.Color.Black;
            this.totalall.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalall.Location = new System.Drawing.Point(915, 197);
            this.totalall.Margin = new System.Windows.Forms.Padding(6);
            this.totalall.Name = "totalall";
            this.totalall.PasswordChar = '\0';
            this.totalall.PlaceholderText = "";
            this.totalall.ReadOnly = true;
            this.totalall.SelectedText = "";
            this.totalall.Size = new System.Drawing.Size(229, 41);
            this.totalall.TabIndex = 18;
            this.totalall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalall.TextChanged += new System.EventHandler(this.totalall_TextChanged);
            // 
            // editnum
            // 
            this.editnum.AutoRoundedCorners = true;
            this.editnum.BackColor = System.Drawing.Color.Transparent;
            this.editnum.BorderRadius = 27;
            this.editnum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editnum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editnum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editnum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editnum.FillColor = System.Drawing.Color.SkyBlue;
            this.editnum.Font = new System.Drawing.Font("LilyUPC", 18F, System.Drawing.FontStyle.Bold);
            this.editnum.ForeColor = System.Drawing.Color.White;
            this.editnum.Location = new System.Drawing.Point(587, 306);
            this.editnum.Margin = new System.Windows.Forms.Padding(2);
            this.editnum.Name = "editnum";
            this.editnum.Size = new System.Drawing.Size(159, 57);
            this.editnum.TabIndex = 17;
            this.editnum.Text = "แก้ไขจำนวนสินค้า";
            this.editnum.UseTransparentBackground = true;
            this.editnum.Click += new System.EventHandler(this.editnum_Click);
            // 
            // delproductincart
            // 
            this.delproductincart.AutoRoundedCorners = true;
            this.delproductincart.BackColor = System.Drawing.Color.Transparent;
            this.delproductincart.BorderRadius = 27;
            this.delproductincart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delproductincart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delproductincart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delproductincart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delproductincart.FillColor = System.Drawing.Color.SkyBlue;
            this.delproductincart.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.delproductincart.ForeColor = System.Drawing.Color.White;
            this.delproductincart.Location = new System.Drawing.Point(750, 306);
            this.delproductincart.Margin = new System.Windows.Forms.Padding(2);
            this.delproductincart.Name = "delproductincart";
            this.delproductincart.Size = new System.Drawing.Size(118, 57);
            this.delproductincart.TabIndex = 15;
            this.delproductincart.Text = "ลบสินค้า";
            this.delproductincart.UseTransparentBackground = true;
            this.delproductincart.Click += new System.EventHandler(this.delproductincart_Click);
            // 
            // payment
            // 
            this.payment.AutoRoundedCorners = true;
            this.payment.BackColor = System.Drawing.Color.Transparent;
            this.payment.BorderRadius = 27;
            this.payment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.payment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.payment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.payment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.payment.FillColor = System.Drawing.Color.SkyBlue;
            this.payment.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.payment.ForeColor = System.Drawing.Color.White;
            this.payment.Location = new System.Drawing.Point(952, 250);
            this.payment.Margin = new System.Windows.Forms.Padding(2);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(155, 57);
            this.payment.TabIndex = 14;
            this.payment.Text = "จ่ายเงิน";
            this.payment.UseTransparentBackground = true;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // totalpriceTextBox5
            // 
            this.totalpriceTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalpriceTextBox5.DefaultText = "";
            this.totalpriceTextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.totalpriceTextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.totalpriceTextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalpriceTextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.totalpriceTextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalpriceTextBox5.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.totalpriceTextBox5.ForeColor = System.Drawing.Color.Black;
            this.totalpriceTextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.totalpriceTextBox5.Location = new System.Drawing.Point(750, 250);
            this.totalpriceTextBox5.Margin = new System.Windows.Forms.Padding(6);
            this.totalpriceTextBox5.Name = "totalpriceTextBox5";
            this.totalpriceTextBox5.PasswordChar = '\0';
            this.totalpriceTextBox5.PlaceholderText = "";
            this.totalpriceTextBox5.ReadOnly = true;
            this.totalpriceTextBox5.SelectedText = "";
            this.totalpriceTextBox5.Size = new System.Drawing.Size(113, 41);
            this.totalpriceTextBox5.TabIndex = 6;
            this.totalpriceTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalpriceTextBox5.TextChanged += new System.EventHandler(this.totalpriceTextBox5_TextChanged);
            // 
            // priceproductTextBox4
            // 
            this.priceproductTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceproductTextBox4.DefaultText = "";
            this.priceproductTextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceproductTextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceproductTextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceproductTextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceproductTextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceproductTextBox4.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.priceproductTextBox4.ForeColor = System.Drawing.Color.Black;
            this.priceproductTextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceproductTextBox4.Location = new System.Drawing.Point(1021, 133);
            this.priceproductTextBox4.Margin = new System.Windows.Forms.Padding(6);
            this.priceproductTextBox4.Name = "priceproductTextBox4";
            this.priceproductTextBox4.PasswordChar = '\0';
            this.priceproductTextBox4.PlaceholderText = "";
            this.priceproductTextBox4.ReadOnly = true;
            this.priceproductTextBox4.SelectedText = "";
            this.priceproductTextBox4.Size = new System.Drawing.Size(123, 52);
            this.priceproductTextBox4.TabIndex = 5;
            this.priceproductTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceproductTextBox4.TextChanged += new System.EventHandler(this.priceproductTextBox4_TextChanged);
            // 
            // numproductTextBox3
            // 
            this.numproductTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numproductTextBox3.DefaultText = "";
            this.numproductTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numproductTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numproductTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numproductTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numproductTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numproductTextBox3.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.numproductTextBox3.ForeColor = System.Drawing.Color.Black;
            this.numproductTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numproductTextBox3.Location = new System.Drawing.Point(616, 250);
            this.numproductTextBox3.Margin = new System.Windows.Forms.Padding(6);
            this.numproductTextBox3.Name = "numproductTextBox3";
            this.numproductTextBox3.PasswordChar = '\0';
            this.numproductTextBox3.PlaceholderText = "";
            this.numproductTextBox3.SelectedText = "";
            this.numproductTextBox3.Size = new System.Drawing.Size(94, 41);
            this.numproductTextBox3.TabIndex = 4;
            this.numproductTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numproductTextBox3.TextChanged += new System.EventHandler(this.numproductTextBox3_TextChanged);
            // 
            // nameproductTextBox2
            // 
            this.nameproductTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameproductTextBox2.DefaultText = "";
            this.nameproductTextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameproductTextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameproductTextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameproductTextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameproductTextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameproductTextBox2.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.nameproductTextBox2.ForeColor = System.Drawing.Color.Black;
            this.nameproductTextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameproductTextBox2.Location = new System.Drawing.Point(737, 133);
            this.nameproductTextBox2.Margin = new System.Windows.Forms.Padding(6);
            this.nameproductTextBox2.Name = "nameproductTextBox2";
            this.nameproductTextBox2.PasswordChar = '\0';
            this.nameproductTextBox2.PlaceholderText = "";
            this.nameproductTextBox2.ReadOnly = true;
            this.nameproductTextBox2.SelectedText = "";
            this.nameproductTextBox2.Size = new System.Drawing.Size(272, 49);
            this.nameproductTextBox2.TabIndex = 3;
            this.nameproductTextBox2.TextChanged += new System.EventHandler(this.nameproductTextBox2_TextChanged);
            // 
            // IDTextBox1
            // 
            this.IDTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTextBox1.DefaultText = "";
            this.IDTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTextBox1.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.IDTextBox1.ForeColor = System.Drawing.Color.Black;
            this.IDTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTextBox1.Location = new System.Drawing.Point(616, 133);
            this.IDTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.IDTextBox1.Name = "IDTextBox1";
            this.IDTextBox1.PasswordChar = '\0';
            this.IDTextBox1.PlaceholderText = "";
            this.IDTextBox1.ReadOnly = true;
            this.IDTextBox1.SelectedText = "";
            this.IDTextBox1.Size = new System.Drawing.Size(109, 49);
            this.IDTextBox1.TabIndex = 2;
            this.IDTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IDTextBox1.TextChanged += new System.EventHandler(this.IDTextBox1_TextChanged);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.ImageRotate = 0F;
            this.PictureBox1.Location = new System.Drawing.Point(215, 88);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(243, 255);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.backbut);
            this.Controls.Add(this.ป);
            this.Name = "cart";
            this.Size = new System.Drawing.Size(1199, 557);
            this.Load += new System.EventHandler(this.cart_Load);
            this.ป.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ป;
        private Guna.UI2.WinForms.Guna2Button backbut;
        private Guna.UI2.WinForms.Guna2TextBox totalpriceTextBox5;
        private Guna.UI2.WinForms.Guna2TextBox priceproductTextBox4;
        private Guna.UI2.WinForms.Guna2TextBox numproductTextBox3;
        private Guna.UI2.WinForms.Guna2TextBox nameproductTextBox2;
        private Guna.UI2.WinForms.Guna2TextBox IDTextBox1;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox1;
        private Guna.UI2.WinForms.Guna2Button delproductincart;
        private Guna.UI2.WinForms.Guna2Button payment;
        private Guna.UI2.WinForms.Guna2Button editnum;
        private Guna.UI2.WinForms.Guna2TextBox totalall;
        private Guna.UI2.WinForms.Guna2DataGridView cartDataGridView1;
    }
}
