namespace projectshop
{
    partial class manageorder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.categoryComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.ป = new Guna.UI2.WinForms.Guna2Panel();
            this.PicBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.orderDataGridView2 = new System.Windows.Forms.DataGridView();
            this.status = new Guna.UI2.WinForms.Guna2TextBox();
            this.total = new Guna.UI2.WinForms.Guna2TextBox();
            this.time = new Guna.UI2.WinForms.Guna2TextBox();
            this.date = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameuser = new Guna.UI2.WinForms.Guna2TextBox();
            this.iduser = new Guna.UI2.WinForms.Guna2TextBox();
            this.idorder = new Guna.UI2.WinForms.Guna2TextBox();
            this.delorder = new Guna.UI2.WinForms.Guna2Button();
            this.payment = new Guna.UI2.WinForms.Guna2Button();
            this.ป.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.categoryComboBox.Location = new System.Drawing.Point(22, 14);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(350, 36);
            this.categoryComboBox.TabIndex = 3;
            this.categoryComboBox.Tag = "";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // ป
            // 
            this.ป.AutoScroll = true;
            this.ป.BackColor = System.Drawing.Color.LightGray;
            this.ป.BackgroundImage = global::projectshop.Properties.Resources.สำเนาของ_BG;
            this.ป.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ป.Controls.Add(this.PicBox);
            this.ป.Controls.Add(this.orderDataGridView2);
            this.ป.Controls.Add(this.status);
            this.ป.Controls.Add(this.total);
            this.ป.Controls.Add(this.time);
            this.ป.Controls.Add(this.date);
            this.ป.Controls.Add(this.nameuser);
            this.ป.Controls.Add(this.iduser);
            this.ป.Controls.Add(this.idorder);
            this.ป.Controls.Add(this.delorder);
            this.ป.Controls.Add(this.payment);
            this.ป.ForeColor = System.Drawing.Color.Cornsilk;
            this.ป.Location = new System.Drawing.Point(-20, 74);
            this.ป.Name = "ป";
            this.ป.Size = new System.Drawing.Size(1935, 931);
            this.ป.TabIndex = 4;
            this.ป.Paint += new System.Windows.Forms.PaintEventHandler(this.ป_Paint);
            // 
            // PicBox
            // 
            this.PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBox.ImageRotate = 0F;
            this.PicBox.Location = new System.Drawing.Point(1278, 52);
            this.PicBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(603, 835);
            this.PicBox.TabIndex = 30;
            this.PicBox.TabStop = false;
            this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
            // 
            // orderDataGridView2
            // 
            this.orderDataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderDataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.orderDataGridView2.Location = new System.Drawing.Point(42, 52);
            this.orderDataGridView2.Name = "orderDataGridView2";
            this.orderDataGridView2.ReadOnly = true;
            this.orderDataGridView2.RowHeadersWidth = 62;
            this.orderDataGridView2.RowTemplate.Height = 28;
            this.orderDataGridView2.Size = new System.Drawing.Size(1228, 266);
            this.orderDataGridView2.TabIndex = 29;
            this.orderDataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderDataGridView2_CellContentClick);
            // 
            // status
            // 
            this.status.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.status.DefaultText = "";
            this.status.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.status.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.status.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.status.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.status.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.status.ForeColor = System.Drawing.Color.Black;
            this.status.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.status.Location = new System.Drawing.Point(804, 668);
            this.status.Margin = new System.Windows.Forms.Padding(9);
            this.status.Name = "status";
            this.status.PasswordChar = '\0';
            this.status.PlaceholderText = "";
            this.status.ReadOnly = true;
            this.status.SelectedText = "";
            this.status.Size = new System.Drawing.Size(366, 75);
            this.status.TabIndex = 28;
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // total
            // 
            this.total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.total.DefaultText = "";
            this.total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.total.ForeColor = System.Drawing.Color.Black;
            this.total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total.Location = new System.Drawing.Point(567, 668);
            this.total.Margin = new System.Windows.Forms.Padding(9);
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.PlaceholderText = "";
            this.total.ReadOnly = true;
            this.total.SelectedText = "";
            this.total.Size = new System.Drawing.Size(219, 75);
            this.total.TabIndex = 26;
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // time
            // 
            this.time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.time.DefaultText = "";
            this.time.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.time.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.time.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.time.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.time.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.time.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Black;
            this.time.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.time.Location = new System.Drawing.Point(316, 668);
            this.time.Margin = new System.Windows.Forms.Padding(9);
            this.time.Name = "time";
            this.time.PasswordChar = '\0';
            this.time.PlaceholderText = "";
            this.time.ReadOnly = true;
            this.time.SelectedText = "";
            this.time.Size = new System.Drawing.Size(219, 75);
            this.time.TabIndex = 25;
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.TextChanged += new System.EventHandler(this.time_TextChanged);
            // 
            // date
            // 
            this.date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.date.DefaultText = "";
            this.date.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.date.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.date.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.date.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.date.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.date.Font = new System.Drawing.Font("LilyUPC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.date.Location = new System.Drawing.Point(64, 668);
            this.date.Margin = new System.Windows.Forms.Padding(9);
            this.date.Name = "date";
            this.date.PasswordChar = '\0';
            this.date.PlaceholderText = "";
            this.date.ReadOnly = true;
            this.date.SelectedText = "";
            this.date.Size = new System.Drawing.Size(219, 75);
            this.date.TabIndex = 24;
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.TextChanged += new System.EventHandler(this.date_TextChanged);
            // 
            // nameuser
            // 
            this.nameuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameuser.DefaultText = "";
            this.nameuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameuser.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.nameuser.ForeColor = System.Drawing.Color.Black;
            this.nameuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameuser.Location = new System.Drawing.Point(688, 445);
            this.nameuser.Margin = new System.Windows.Forms.Padding(9);
            this.nameuser.Name = "nameuser";
            this.nameuser.PasswordChar = '\0';
            this.nameuser.PlaceholderText = "";
            this.nameuser.ReadOnly = true;
            this.nameuser.SelectedText = "";
            this.nameuser.Size = new System.Drawing.Size(436, 75);
            this.nameuser.TabIndex = 23;
            this.nameuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameuser.TextChanged += new System.EventHandler(this.nameuser_TextChanged);
            // 
            // iduser
            // 
            this.iduser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.iduser.DefaultText = "";
            this.iduser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.iduser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.iduser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iduser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.iduser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iduser.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.iduser.ForeColor = System.Drawing.Color.Black;
            this.iduser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.iduser.Location = new System.Drawing.Point(444, 445);
            this.iduser.Margin = new System.Windows.Forms.Padding(9);
            this.iduser.Name = "iduser";
            this.iduser.PasswordChar = '\0';
            this.iduser.PlaceholderText = "";
            this.iduser.ReadOnly = true;
            this.iduser.SelectedText = "";
            this.iduser.Size = new System.Drawing.Size(206, 75);
            this.iduser.TabIndex = 22;
            this.iduser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iduser.TextChanged += new System.EventHandler(this.iduser_TextChanged);
            // 
            // idorder
            // 
            this.idorder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idorder.DefaultText = "";
            this.idorder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idorder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idorder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idorder.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.idorder.ForeColor = System.Drawing.Color.Black;
            this.idorder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idorder.Location = new System.Drawing.Point(111, 445);
            this.idorder.Margin = new System.Windows.Forms.Padding(9);
            this.idorder.Name = "idorder";
            this.idorder.PasswordChar = '\0';
            this.idorder.PlaceholderText = "";
            this.idorder.ReadOnly = true;
            this.idorder.SelectedText = "";
            this.idorder.Size = new System.Drawing.Size(210, 75);
            this.idorder.TabIndex = 21;
            this.idorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idorder.TextChanged += new System.EventHandler(this.idorder_TextChanged);
            // 
            // delorder
            // 
            this.delorder.AutoRoundedCorners = true;
            this.delorder.BackColor = System.Drawing.Color.Transparent;
            this.delorder.BorderRadius = 43;
            this.delorder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delorder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delorder.FillColor = System.Drawing.Color.SkyBlue;
            this.delorder.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.delorder.ForeColor = System.Drawing.Color.White;
            this.delorder.Location = new System.Drawing.Point(732, 789);
            this.delorder.Name = "delorder";
            this.delorder.Size = new System.Drawing.Size(264, 88);
            this.delorder.TabIndex = 15;
            this.delorder.Text = "ยกเลิกคำสั่งซื้อ";
            this.delorder.UseTransparentBackground = true;
            this.delorder.Click += new System.EventHandler(this.delorder_Click);
            // 
            // payment
            // 
            this.payment.AutoRoundedCorners = true;
            this.payment.BackColor = System.Drawing.Color.Transparent;
            this.payment.BorderRadius = 43;
            this.payment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.payment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.payment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.payment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.payment.FillColor = System.Drawing.Color.SkyBlue;
            this.payment.Font = new System.Drawing.Font("LilyUPC", 24F, System.Drawing.FontStyle.Bold);
            this.payment.ForeColor = System.Drawing.Color.White;
            this.payment.Location = new System.Drawing.Point(342, 789);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(286, 88);
            this.payment.TabIndex = 14;
            this.payment.Text = "ยืนยันการชำระเงิน";
            this.payment.UseTransparentBackground = true;
            this.payment.Click += new System.EventHandler(this.payment_Click);
            // 
            // manageorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.ป);
            this.Controls.Add(this.categoryComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "manageorder";
            this.Size = new System.Drawing.Size(1896, 1005);
            this.Load += new System.EventHandler(this.MemberAcc_Load);
            this.ป.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox categoryComboBox;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2Panel ป;
        private Guna.UI2.WinForms.Guna2Button delorder;
        private Guna.UI2.WinForms.Guna2Button payment;
        private Guna.UI2.WinForms.Guna2TextBox nameuser;
        private Guna.UI2.WinForms.Guna2TextBox iduser;
        private Guna.UI2.WinForms.Guna2TextBox idorder;
        private Guna.UI2.WinForms.Guna2TextBox status;
        private Guna.UI2.WinForms.Guna2TextBox total;
        private Guna.UI2.WinForms.Guna2TextBox time;
        private Guna.UI2.WinForms.Guna2TextBox date;
        private System.Windows.Forms.DataGridView orderDataGridView2;
        private Guna.UI2.WinForms.Guna2PictureBox PicBox;
    }
}
