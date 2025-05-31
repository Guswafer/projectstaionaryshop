namespace projectshop
{
    partial class infoproduct
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
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.backbut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonplus = new Guna.UI2.WinForms.Guna2Button();
            this.buttondel = new Guna.UI2.WinForms.Guna2Button();
            this.numproduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.addtocart = new Guna.UI2.WinForms.Guna2Button();
            this.amountproduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceproduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.detailproduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameproduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.Picboxid = new Guna.UI2.WinForms.Guna2PictureBox();
            this.idproduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picboxid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
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
            this.backbut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.backbut.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.backbut.ForeColor = System.Drawing.Color.White;
            this.backbut.Location = new System.Drawing.Point(14, 8);
            this.backbut.Margin = new System.Windows.Forms.Padding(2);
            this.backbut.Name = "backbut";
            this.backbut.Size = new System.Drawing.Size(48, 42);
            this.backbut.TabIndex = 9;
            this.backbut.Text = "<";
            this.backbut.UseTransparentBackground = true;
            this.backbut.Click += new System.EventHandler(this.backbut_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Pink;
            this.guna2Panel1.BackgroundImage = global::projectshop.Properties.Resources.รหัสสินค้า__1_;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.buttonplus);
            this.guna2Panel1.Controls.Add(this.buttondel);
            this.guna2Panel1.Controls.Add(this.numproduct);
            this.guna2Panel1.Controls.Add(this.addtocart);
            this.guna2Panel1.Controls.Add(this.amountproduct);
            this.guna2Panel1.Controls.Add(this.priceproduct);
            this.guna2Panel1.Controls.Add(this.detailproduct);
            this.guna2Panel1.Controls.Add(this.nameproduct);
            this.guna2Panel1.Controls.Add(this.Picboxid);
            this.guna2Panel1.Controls.Add(this.idproduct);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 54);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1264, 575);
            this.guna2Panel1.TabIndex = 3;
            // 
            // buttonplus
            // 
            this.buttonplus.AutoRoundedCorners = true;
            this.buttonplus.BackColor = System.Drawing.Color.Transparent;
            this.buttonplus.BorderRadius = 17;
            this.buttonplus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonplus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonplus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonplus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonplus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonplus.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.buttonplus.ForeColor = System.Drawing.Color.White;
            this.buttonplus.Location = new System.Drawing.Point(718, 446);
            this.buttonplus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(37, 39);
            this.buttonplus.TabIndex = 11;
            this.buttonplus.Text = "+";
            this.buttonplus.UseTransparentBackground = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonplus_Click);
            // 
            // buttondel
            // 
            this.buttondel.AutoRoundedCorners = true;
            this.buttondel.BackColor = System.Drawing.Color.Transparent;
            this.buttondel.BorderRadius = 17;
            this.buttondel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttondel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttondel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttondel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttondel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttondel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.buttondel.ForeColor = System.Drawing.Color.White;
            this.buttondel.Location = new System.Drawing.Point(619, 446);
            this.buttondel.Margin = new System.Windows.Forms.Padding(2);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(37, 39);
            this.buttondel.TabIndex = 10;
            this.buttondel.Text = "-";
            this.buttondel.UseTransparentBackground = true;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // numproduct
            // 
            this.numproduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numproduct.DefaultText = "0";
            this.numproduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numproduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numproduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numproduct.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numproduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numproduct.Location = new System.Drawing.Point(661, 446);
            this.numproduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numproduct.Name = "numproduct";
            this.numproduct.PasswordChar = '\0';
            this.numproduct.PlaceholderText = "";
            this.numproduct.SelectedText = "";
            this.numproduct.Size = new System.Drawing.Size(52, 39);
            this.numproduct.TabIndex = 8;
            this.numproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numproduct.TextChanged += new System.EventHandler(this.numproduct_TextChanged);
            // 
            // addtocart
            // 
            this.addtocart.AutoRoundedCorners = true;
            this.addtocart.BackColor = System.Drawing.Color.Transparent;
            this.addtocart.BorderRadius = 27;
            this.addtocart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addtocart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addtocart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addtocart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addtocart.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.addtocart.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.addtocart.ForeColor = System.Drawing.Color.White;
            this.addtocart.Location = new System.Drawing.Point(787, 428);
            this.addtocart.Margin = new System.Windows.Forms.Padding(2);
            this.addtocart.Name = "addtocart";
            this.addtocart.Size = new System.Drawing.Size(155, 57);
            this.addtocart.TabIndex = 7;
            this.addtocart.Text = "เพิ่มลงตะกร้า";
            this.addtocart.UseTransparentBackground = true;
            this.addtocart.Click += new System.EventHandler(this.addtocart_Click);
            // 
            // amountproduct
            // 
            this.amountproduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountproduct.DefaultText = "";
            this.amountproduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amountproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amountproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountproduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountproduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amountproduct.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountproduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amountproduct.Location = new System.Drawing.Point(813, 363);
            this.amountproduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.amountproduct.Name = "amountproduct";
            this.amountproduct.PasswordChar = '\0';
            this.amountproduct.PlaceholderText = "";
            this.amountproduct.ReadOnly = true;
            this.amountproduct.SelectedText = "";
            this.amountproduct.Size = new System.Drawing.Size(129, 39);
            this.amountproduct.TabIndex = 6;
            this.amountproduct.TextChanged += new System.EventHandler(this.amountproduct_TextChanged);
            // 
            // priceproduct
            // 
            this.priceproduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceproduct.DefaultText = "";
            this.priceproduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceproduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceproduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceproduct.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceproduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceproduct.Location = new System.Drawing.Point(647, 363);
            this.priceproduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.priceproduct.Name = "priceproduct";
            this.priceproduct.PasswordChar = '\0';
            this.priceproduct.PlaceholderText = "";
            this.priceproduct.ReadOnly = true;
            this.priceproduct.SelectedText = "";
            this.priceproduct.Size = new System.Drawing.Size(111, 39);
            this.priceproduct.TabIndex = 5;
            this.priceproduct.TextChanged += new System.EventHandler(this.priceproduct_TextChanged);
            // 
            // detailproduct
            // 
            this.detailproduct.AutoScroll = true;
            this.detailproduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.detailproduct.DefaultText = "";
            this.detailproduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.detailproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.detailproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.detailproduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.detailproduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.detailproduct.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.detailproduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.detailproduct.Location = new System.Drawing.Point(647, 228);
            this.detailproduct.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.detailproduct.Multiline = true;
            this.detailproduct.Name = "detailproduct";
            this.detailproduct.PasswordChar = '\0';
            this.detailproduct.PlaceholderText = "";
            this.detailproduct.ReadOnly = true;
            this.detailproduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detailproduct.SelectedText = "";
            this.detailproduct.Size = new System.Drawing.Size(426, 99);
            this.detailproduct.TabIndex = 4;
            this.detailproduct.TextChanged += new System.EventHandler(this.detailproduct_TextChanged);
            // 
            // nameproduct
            // 
            this.nameproduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameproduct.DefaultText = "";
            this.nameproduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameproduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameproduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameproduct.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.nameproduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameproduct.Location = new System.Drawing.Point(813, 149);
            this.nameproduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nameproduct.Name = "nameproduct";
            this.nameproduct.PasswordChar = '\0';
            this.nameproduct.PlaceholderText = "";
            this.nameproduct.ReadOnly = true;
            this.nameproduct.SelectedText = "";
            this.nameproduct.Size = new System.Drawing.Size(340, 39);
            this.nameproduct.TabIndex = 3;
            this.nameproduct.TextChanged += new System.EventHandler(this.nameproduct_TextChanged);
            // 
            // Picboxid
            // 
            this.Picboxid.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.Picboxid.ImageRotate = 0F;
            this.Picboxid.Location = new System.Drawing.Point(150, 103);
            this.Picboxid.Margin = new System.Windows.Forms.Padding(2);
            this.Picboxid.Name = "Picboxid";
            this.Picboxid.Size = new System.Drawing.Size(371, 382);
            this.Picboxid.TabIndex = 1;
            this.Picboxid.TabStop = false;
            this.Picboxid.Click += new System.EventHandler(this.Picboxid_Click);
            // 
            // idproduct
            // 
            this.idproduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idproduct.DefaultText = "";
            this.idproduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idproduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idproduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idproduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idproduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idproduct.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idproduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idproduct.Location = new System.Drawing.Point(647, 149);
            this.idproduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.idproduct.Name = "idproduct";
            this.idproduct.PasswordChar = '\0';
            this.idproduct.PlaceholderText = "";
            this.idproduct.SelectedText = "";
            this.idproduct.Size = new System.Drawing.Size(111, 39);
            this.idproduct.TabIndex = 2;
            this.idproduct.TextChanged += new System.EventHandler(this.idproduct_TextChanged);
            // 
            // infoproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.backbut);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "infoproduct";
            this.Size = new System.Drawing.Size(1264, 629);
            this.Load += new System.EventHandler(this.infoproduct_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picboxid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2TextBox idproduct;
        private Guna.UI2.WinForms.Guna2PictureBox Picboxid;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button addtocart;
        private Guna.UI2.WinForms.Guna2TextBox amountproduct;
        private Guna.UI2.WinForms.Guna2TextBox priceproduct;
        private Guna.UI2.WinForms.Guna2TextBox detailproduct;
        private Guna.UI2.WinForms.Guna2TextBox nameproduct;
        private Guna.UI2.WinForms.Guna2TextBox numproduct;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2Button backbut;
        private Guna.UI2.WinForms.Guna2Button buttonplus;
        private Guna.UI2.WinForms.Guna2Button buttondel;
    }
}
