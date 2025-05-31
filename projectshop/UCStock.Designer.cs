namespace projectshop
{
    partial class UCStock
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
            this.components = new System.ComponentModel.Container();
            this.ITEM = new System.Windows.Forms.DataGridView();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.NameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.amountText = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceText = new Guna.UI2.WinForms.Guna2TextBox();
            this.SaveBut = new Guna.UI2.WinForms.Guna2Button();
            this.EditBut = new Guna.UI2.WinForms.Guna2Button();
            this.CancelBut = new Guna.UI2.WinForms.Guna2Button();
            this.deletbut = new Guna.UI2.WinForms.Guna2Button();
            this.SearchAllBut = new Guna.UI2.WinForms.Guna2Button();
            this.SearchTex = new Guna.UI2.WinForms.Guna2TextBox();
            this.PicBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.EditpicBut = new Guna.UI2.WinForms.Guna2Button();
            this.detailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchBut = new Guna.UI2.WinForms.Guna2Button();
            this.costtext = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.categoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.IDText = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ITEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ITEM
            // 
            this.ITEM.BackgroundColor = System.Drawing.Color.Plum;
            this.ITEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ITEM.Location = new System.Drawing.Point(1266, 209);
            this.ITEM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ITEM.Name = "ITEM";
            this.ITEM.RowHeadersWidth = 62;
            this.ITEM.Size = new System.Drawing.Size(604, 737);
            this.ITEM.TabIndex = 0;
            this.ITEM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ITEM_CellContentClick);
            // 
            // NameText
            // 
            this.NameText.AutoRoundedCorners = true;
            this.NameText.BorderColor = System.Drawing.Color.White;
            this.NameText.BorderRadius = 33;
            this.NameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameText.DefaultText = "";
            this.NameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.NameText.ForeColor = System.Drawing.Color.Black;
            this.NameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.Location = new System.Drawing.Point(224, 218);
            this.NameText.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.NameText.Name = "NameText";
            this.NameText.PasswordChar = '\0';
            this.NameText.PlaceholderText = "";
            this.NameText.SelectedText = "";
            this.NameText.Size = new System.Drawing.Size(507, 68);
            this.NameText.TabIndex = 11;
            this.NameText.TextOffset = new System.Drawing.Point(2, -3);
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // amountText
            // 
            this.amountText.AutoRoundedCorners = true;
            this.amountText.BorderColor = System.Drawing.Color.White;
            this.amountText.BorderRadius = 32;
            this.amountText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountText.DefaultText = "";
            this.amountText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amountText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amountText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amountText.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.amountText.ForeColor = System.Drawing.Color.Black;
            this.amountText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amountText.Location = new System.Drawing.Point(224, 547);
            this.amountText.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.amountText.Name = "amountText";
            this.amountText.PasswordChar = '\0';
            this.amountText.PlaceholderText = "";
            this.amountText.SelectedText = "";
            this.amountText.Size = new System.Drawing.Size(507, 66);
            this.amountText.TabIndex = 12;
            this.amountText.TextOffset = new System.Drawing.Point(2, -3);
            this.amountText.TextChanged += new System.EventHandler(this.amountText_TextChanged);
            // 
            // priceText
            // 
            this.priceText.AutoRoundedCorners = true;
            this.priceText.BorderColor = System.Drawing.Color.White;
            this.priceText.BorderRadius = 35;
            this.priceText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceText.DefaultText = "";
            this.priceText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceText.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.priceText.ForeColor = System.Drawing.Color.Black;
            this.priceText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceText.Location = new System.Drawing.Point(224, 651);
            this.priceText.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.priceText.Name = "priceText";
            this.priceText.PasswordChar = '\0';
            this.priceText.PlaceholderText = "";
            this.priceText.SelectedText = "";
            this.priceText.Size = new System.Drawing.Size(507, 72);
            this.priceText.TabIndex = 13;
            this.priceText.TextOffset = new System.Drawing.Point(2, -3);
            this.priceText.TextChanged += new System.EventHandler(this.priceText_TextChanged);
            // 
            // SaveBut
            // 
            this.SaveBut.AutoRoundedCorners = true;
            this.SaveBut.BackColor = System.Drawing.Color.Transparent;
            this.SaveBut.BorderRadius = 37;
            this.SaveBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBut.FillColor = System.Drawing.Color.Plum;
            this.SaveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBut.ForeColor = System.Drawing.Color.White;
            this.SaveBut.Location = new System.Drawing.Point(254, 859);
            this.SaveBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveBut.Name = "SaveBut";
            this.SaveBut.Size = new System.Drawing.Size(201, 77);
            this.SaveBut.TabIndex = 15;
            this.SaveBut.Text = "บันทึกข้อมูล";
            this.SaveBut.UseTransparentBackground = true;
            this.SaveBut.Click += new System.EventHandler(this.SaveBut_Click);
            // 
            // EditBut
            // 
            this.EditBut.AutoRoundedCorners = true;
            this.EditBut.BackColor = System.Drawing.Color.Transparent;
            this.EditBut.BorderRadius = 37;
            this.EditBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditBut.FillColor = System.Drawing.Color.Plum;
            this.EditBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBut.ForeColor = System.Drawing.Color.White;
            this.EditBut.Location = new System.Drawing.Point(500, 859);
            this.EditBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditBut.Name = "EditBut";
            this.EditBut.Size = new System.Drawing.Size(207, 77);
            this.EditBut.TabIndex = 16;
            this.EditBut.Text = "แก้ไขข้อมูล";
            this.EditBut.UseTransparentBackground = true;
            this.EditBut.Click += new System.EventHandler(this.EditBut_Click);
            // 
            // CancelBut
            // 
            this.CancelBut.AutoRoundedCorners = true;
            this.CancelBut.BackColor = System.Drawing.Color.Transparent;
            this.CancelBut.BorderRadius = 30;
            this.CancelBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CancelBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CancelBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CancelBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CancelBut.FillColor = System.Drawing.Color.Plum;
            this.CancelBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.CancelBut.ForeColor = System.Drawing.Color.White;
            this.CancelBut.Location = new System.Drawing.Point(254, 944);
            this.CancelBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelBut.Name = "CancelBut";
            this.CancelBut.Size = new System.Drawing.Size(201, 63);
            this.CancelBut.TabIndex = 19;
            this.CancelBut.Text = "ยกเลิก";
            this.CancelBut.UseTransparentBackground = true;
            this.CancelBut.Click += new System.EventHandler(this.CancelBut_Click);
            // 
            // deletbut
            // 
            this.deletbut.AutoRoundedCorners = true;
            this.deletbut.BackColor = System.Drawing.Color.Transparent;
            this.deletbut.BorderRadius = 30;
            this.deletbut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deletbut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deletbut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deletbut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deletbut.FillColor = System.Drawing.Color.Plum;
            this.deletbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.deletbut.ForeColor = System.Drawing.Color.White;
            this.deletbut.Location = new System.Drawing.Point(500, 944);
            this.deletbut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletbut.Name = "deletbut";
            this.deletbut.Size = new System.Drawing.Size(207, 63);
            this.deletbut.TabIndex = 20;
            this.deletbut.Text = "ลบข้อมูล";
            this.deletbut.UseTransparentBackground = true;
            this.deletbut.Click += new System.EventHandler(this.deletbut_Click);
            // 
            // SearchAllBut
            // 
            this.SearchAllBut.AutoRoundedCorners = true;
            this.SearchAllBut.BackColor = System.Drawing.Color.Transparent;
            this.SearchAllBut.BorderRadius = 33;
            this.SearchAllBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchAllBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchAllBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchAllBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchAllBut.FillColor = System.Drawing.Color.Plum;
            this.SearchAllBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SearchAllBut.ForeColor = System.Drawing.Color.White;
            this.SearchAllBut.Location = new System.Drawing.Point(1617, 117);
            this.SearchAllBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchAllBut.Name = "SearchAllBut";
            this.SearchAllBut.Size = new System.Drawing.Size(230, 69);
            this.SearchAllBut.TabIndex = 8;
            this.SearchAllBut.Text = "ค้นหาทั้งหมด";
            this.SearchAllBut.UseTransparentBackground = true;
            this.SearchAllBut.Click += new System.EventHandler(this.SearchAllBut_Click);
            // 
            // SearchTex
            // 
            this.SearchTex.BorderColor = System.Drawing.Color.White;
            this.SearchTex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTex.DefaultText = "";
            this.SearchTex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTex.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.SearchTex.ForeColor = System.Drawing.Color.Black;
            this.SearchTex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTex.Location = new System.Drawing.Point(1428, 28);
            this.SearchTex.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.SearchTex.Name = "SearchTex";
            this.SearchTex.PasswordChar = '\0';
            this.SearchTex.PlaceholderText = "";
            this.SearchTex.SelectedText = "";
            this.SearchTex.Size = new System.Drawing.Size(368, 62);
            this.SearchTex.TabIndex = 5;
            this.SearchTex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchTex.TextOffset = new System.Drawing.Point(2, -3);
            this.SearchTex.TextChanged += new System.EventHandler(this.SearchTex_TextChanged);
            // 
            // PicBox
            // 
            this.PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBox.ImageRotate = 0F;
            this.PicBox.Location = new System.Drawing.Point(800, 209);
            this.PicBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(441, 483);
            this.PicBox.TabIndex = 21;
            this.PicBox.TabStop = false;
            this.PicBox.Click += new System.EventHandler(this.PicBox_Click_1);
            // 
            // EditpicBut
            // 
            this.EditpicBut.AutoRoundedCorners = true;
            this.EditpicBut.BackColor = System.Drawing.Color.Transparent;
            this.EditpicBut.BorderRadius = 46;
            this.EditpicBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EditpicBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EditpicBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EditpicBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EditpicBut.FillColor = System.Drawing.Color.Plum;
            this.EditpicBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.EditpicBut.ForeColor = System.Drawing.Color.White;
            this.EditpicBut.Location = new System.Drawing.Point(882, 711);
            this.EditpicBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditpicBut.Name = "EditpicBut";
            this.EditpicBut.Size = new System.Drawing.Size(207, 94);
            this.EditpicBut.TabIndex = 22;
            this.EditpicBut.Text = "แก้ไขรูป";
            this.EditpicBut.UseTransparentBackground = true;
            this.EditpicBut.Click += new System.EventHandler(this.EditpicBut_Click);
            // 
            // detailTextbox
            // 
            this.detailTextbox.AutoRoundedCorners = true;
            this.detailTextbox.BorderColor = System.Drawing.Color.White;
            this.detailTextbox.BorderRadius = 32;
            this.detailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.detailTextbox.DefaultText = "";
            this.detailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.detailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.detailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.detailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.detailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.detailTextbox.Font = new System.Drawing.Font("Segoe UI", 14.5F);
            this.detailTextbox.ForeColor = System.Drawing.Color.Black;
            this.detailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.detailTextbox.Location = new System.Drawing.Point(224, 436);
            this.detailTextbox.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.detailTextbox.Multiline = true;
            this.detailTextbox.Name = "detailTextbox";
            this.detailTextbox.PasswordChar = '\0';
            this.detailTextbox.PlaceholderText = "";
            this.detailTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detailTextbox.SelectedText = "";
            this.detailTextbox.Size = new System.Drawing.Size(507, 66);
            this.detailTextbox.TabIndex = 24;
            this.detailTextbox.TextOffset = new System.Drawing.Point(2, -3);
            this.detailTextbox.TextChanged += new System.EventHandler(this.detailTextbox_TextChanged);
            // 
            // SearchBut
            // 
            this.SearchBut.AutoRoundedCorners = true;
            this.SearchBut.BackColor = System.Drawing.Color.Transparent;
            this.SearchBut.BorderRadius = 33;
            this.SearchBut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBut.FillColor = System.Drawing.Color.Plum;
            this.SearchBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SearchBut.ForeColor = System.Drawing.Color.White;
            this.SearchBut.Location = new System.Drawing.Point(1401, 117);
            this.SearchBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(140, 69);
            this.SearchBut.TabIndex = 7;
            this.SearchBut.Text = "ค้นหา";
            this.SearchBut.UseTransparentBackground = true;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // costtext
            // 
            this.costtext.AutoRoundedCorners = true;
            this.costtext.BorderColor = System.Drawing.Color.White;
            this.costtext.BorderRadius = 35;
            this.costtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.costtext.DefaultText = "";
            this.costtext.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.costtext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.costtext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.costtext.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.costtext.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.costtext.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.costtext.ForeColor = System.Drawing.Color.Black;
            this.costtext.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.costtext.Location = new System.Drawing.Point(224, 758);
            this.costtext.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.costtext.Name = "costtext";
            this.costtext.PasswordChar = '\0';
            this.costtext.PlaceholderText = "";
            this.costtext.SelectedText = "";
            this.costtext.Size = new System.Drawing.Size(507, 72);
            this.costtext.TabIndex = 25;
            this.costtext.TextOffset = new System.Drawing.Point(2, -3);
            this.costtext.TextChanged += new System.EventHandler(this.costtext_TextChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.Transparent;
            this.categoryComboBox.BorderThickness = 0;
            this.categoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryComboBox.Font = new System.Drawing.Font("LilyUPC", 18F, System.Drawing.FontStyle.Bold);
            this.categoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.categoryComboBox.ItemHeight = 30;
            this.categoryComboBox.Location = new System.Drawing.Point(224, 325);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(505, 36);
            this.categoryComboBox.TabIndex = 26;
            this.categoryComboBox.Tag = "";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // IDText
            // 
            this.IDText.AutoRoundedCorners = true;
            this.IDText.BorderColor = System.Drawing.Color.White;
            this.IDText.BorderRadius = 33;
            this.IDText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDText.DefaultText = "";
            this.IDText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDText.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.IDText.ForeColor = System.Drawing.Color.Black;
            this.IDText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDText.Location = new System.Drawing.Point(224, 113);
            this.IDText.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.IDText.Name = "IDText";
            this.IDText.PasswordChar = '\0';
            this.IDText.PlaceholderText = "";
            this.IDText.SelectedText = "";
            this.IDText.Size = new System.Drawing.Size(507, 68);
            this.IDText.TabIndex = 27;
            this.IDText.TextOffset = new System.Drawing.Point(2, -3);
            // 
            // UCStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::projectshop.Properties.Resources.จัดการสินค้า2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.costtext);
            this.Controls.Add(this.detailTextbox);
            this.Controls.Add(this.EditpicBut);
            this.Controls.Add(this.SearchAllBut);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.SearchTex);
            this.Controls.Add(this.deletbut);
            this.Controls.Add(this.CancelBut);
            this.Controls.Add(this.EditBut);
            this.Controls.Add(this.SaveBut);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.amountText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.ITEM);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCStock";
            this.Size = new System.Drawing.Size(1950, 968);
            this.Load += new System.EventHandler(this.UCStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ITEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ITEM;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2TextBox NameText;
        private Guna.UI2.WinForms.Guna2TextBox amountText;
        private Guna.UI2.WinForms.Guna2TextBox priceText;
        private Guna.UI2.WinForms.Guna2Button SaveBut;
        private Guna.UI2.WinForms.Guna2Button EditBut;
        private Guna.UI2.WinForms.Guna2Button CancelBut;
        private Guna.UI2.WinForms.Guna2Button deletbut;
        private Guna.UI2.WinForms.Guna2PictureBox PicBox;
        private Guna.UI2.WinForms.Guna2Button SearchAllBut;
        private Guna.UI2.WinForms.Guna2TextBox SearchTex;
        private Guna.UI2.WinForms.Guna2Button EditpicBut;
        private Guna.UI2.WinForms.Guna2TextBox detailTextbox;
        private Guna.UI2.WinForms.Guna2Button SearchBut;
        private Guna.UI2.WinForms.Guna2TextBox costtext;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2ComboBox categoryComboBox;
        private Guna.UI2.WinForms.Guna2TextBox IDText;
    }
}
