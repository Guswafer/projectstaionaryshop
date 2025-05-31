using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using Saladpuk.PromptPay.Facades;
using Saladpuk.PromptPay.Contracts;
using Guna.UI2.WinForms;
namespace projectshop
{
    public partial class cart : UserControl
    {
        public cart()
        {
            InitializeComponent();
            cartDataGridView1.CellFormatting += cartDataGridView1_CellFormatting;
            LoadCartItems();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void LoadCartItems()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = databaseConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT c.product_id, c.product_name, c.quantity, s.cost, c.total_cost, c.price, c.total_price FROM cart c INNER JOIN stock s ON c.product_id = s.id WHERE c.user_id = @user_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", loginmember.LoggedInUserID);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }

                    UpdateTotalPrices(dt);

                    cartDataGridView1.DataSource = dt;
                    cartDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    // ปิดการมองเห็นคอลัมน์ที่ไม่ต้องการ
                    cartDataGridView1.Columns["cost"].Visible = false;
                    cartDataGridView1.Columns["total_cost"].Visible = false;

                    decimal totalCost = CalculateTotalCost(dt);
                    decimal totalall = CalculateTotal(dt);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void cartDataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // ตรวจสอบว่าคอลัมน์ที่ต้องการจัดรูปแบบคือ "quantity", "price", หรือ "total_price"
            if (cartDataGridView1.Columns[e.ColumnIndex].Name == "quantity" ||
                cartDataGridView1.Columns[e.ColumnIndex].Name == "price" ||
                cartDataGridView1.Columns[e.ColumnIndex].Name == "total_price")
            {
                if (e.Value != null)
                {
                    // แปลงค่าเป็น decimal เพื่อจัดรูปแบบ
                    decimal number;
                    if (decimal.TryParse(e.Value.ToString(), out number))
                    {
                        // ใช้การจัดรูปแบบเพื่อใส่เครื่องหมายคั่นหลัก
                        e.Value = number.ToString("#,##0.00");
                        e.FormattingApplied = true; // บอกว่าได้จัดรูปแบบแล้ว
                    }
                }
            }
        }

        private void UpdateTotalPrices(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (dt.Columns.Contains("total_price"))
                {
                    decimal price = Convert.ToDecimal(row["price"]);
                    decimal cost = Convert.ToDecimal(row["cost"]);
                    int quantity = Convert.ToInt32(row["quantity"]);
                    decimal totalCost = cost * quantity;
                    decimal totalPrice = price * quantity;
                    string productId = Convert.ToString(row["product_id"]); // เปลี่ยนเป็น string
                    UpdateTotalPriceInDatabase(productId, totalPrice, totalCost, quantity); // แก้ productId เป็น string
                }
                else
                {
                    MessageBox.Show("Column 'total_price' does not exist in the DataTable.");
                }
            }
        }

        private void UpdateTotalPriceInDatabase(string productId, decimal totalPrice, decimal totalCost, int quantity)
        {
            MySqlConnection conn = databaseConnection();
            try
            {
                conn.Open();
                string updateTotalQuery = "UPDATE cart SET total_price = @total_price, total_cost = @total_cost, cost = @cost WHERE user_id = @user_id AND product_id = @product_id";
                MySqlCommand updateTotalCmd = new MySqlCommand(updateTotalQuery, conn);
                updateTotalCmd.Parameters.AddWithValue("@total_price", totalPrice);
                updateTotalCmd.Parameters.AddWithValue("@total_cost", totalCost);
                updateTotalCmd.Parameters.AddWithValue("@cost", totalCost / quantity); // Assume cost per unit is total_cost / quantity
                updateTotalCmd.Parameters.AddWithValue("@user_id", loginmember.LoggedInUserID);
                updateTotalCmd.Parameters.AddWithValue("@product_id", productId); // Change to string

                updateTotalCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private decimal CalculateTotal(DataTable dt)
        {
            decimal total = 0;

            foreach (DataRow row in dt.Rows)
            {
                total += Convert.ToDecimal(row["total_price"]);
            }

            totalall.Text = "Total: " + total.ToString("N2") + " ฿";
            return total;
        }

        private decimal CalculateTotalCost(DataTable dt)
        {
            decimal totalCost = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (row["total_cost"] != DBNull.Value)
                {
                    totalCost += Convert.ToDecimal(row["total_cost"]);
                }
            }

            return totalCost;
        }

        private void editnum_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numproductTextBox3.Text, out int newQuantity))
            {
                if (newQuantity > 0) // Check if new quantity is greater than 0
                {
                    string productId = IDTextBox1.Text; // Change to string
                    int availableStock = GetAvailableStock(productId); // Change GetAvailableStock to accept string

                    if (newQuantity <= availableStock)
                    {
                        DialogResult result = MessageBox.Show("คุณแน่ใจหรือไม่ว่าต้องการแก้ไขจำนวนสินค้า?", "ยืนยันการแก้ไขจำนวนสินค้า", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            MySqlConnection conn = databaseConnection();
                            try
                            {
                                conn.Open();
                                decimal pricePerUnit = GetPricePerUnit(productId);
                                decimal costPerUnit = GetCostPerUnit(productId);

                                string updateQuery = "UPDATE cart SET quantity = @quantity WHERE user_id = @user_id AND product_id = @product_id";
                                MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                                updateCmd.Parameters.AddWithValue("@quantity", newQuantity);
                                updateCmd.Parameters.AddWithValue("@user_id", loginmember.LoggedInUserID);
                                updateCmd.Parameters.AddWithValue("@product_id", productId); // Change to string
                                updateCmd.ExecuteNonQuery();

                                decimal newTotalPrice = newQuantity * pricePerUnit;
                                decimal newTotalCost = newQuantity * costPerUnit;

                                UpdateTotalPriceInDatabase(productId, newTotalPrice, newTotalCost, newQuantity);

                                totalpriceTextBox5.Text = newTotalPrice.ToString("N2");

                                MessageBox.Show("อัปเดตสินค้าเรียบร้อย.");
                                LoadCartItems();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("จำนวนสินค้าไม่เพียงพอ จำนวนสินค้าในคลังมีทั้งหมด." + availableStock + " ชิ้น");
                    }
                }
                else
                {
                    MessageBox.Show("โปรดใส่จำนวนสินค้าที่มากกว่าศูนย์.");
                }
            }
            else
            {
                MessageBox.Show("โปรดใส่จำนวนสินค้าให้ถูกต้อง.");
            }
        }
        private decimal GetCostPerUnit(string productId) // Change to accept string
        {
            decimal costPerUnit = 0;
            MySqlConnection conn = databaseConnection();
            try
            {
                conn.Open();
                string query = "SELECT cost FROM stock WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", productId); // Change to string
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    costPerUnit = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return costPerUnit;
        }


        private int GetAvailableStock(string productId) // Change to accept string
        {
            int availableStock = 0;
            MySqlConnection conn = databaseConnection();
            try
            {
                conn.Open();
                string query = "SELECT amount FROM stock WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", productId); // Change to string
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    availableStock = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return availableStock;
        }

        private decimal GetPricePerUnit(string productId) // Change to accept string
        {
            decimal pricePerUnit = 0;
            MySqlConnection conn = databaseConnection();
            try
            {
                conn.Open();
                string query = "SELECT price FROM stock WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", productId); // Change to string
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    pricePerUnit = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return pricePerUnit;
        }
        private void LoadProductImage(string productId)
        {
            MySqlConnection conn = databaseConnection();
            try
            {
                conn.Open();
                string query = "SELECT Photo FROM stock WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", productId);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    byte[] imgData = (byte[])result;
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        // Load image from MemoryStream
                        Image img = Image.FromStream(ms);
                        // Resize image to fit PictureBox
                        Image resizedImg = ResizeImage(img, 243, 255);
                        // Set PictureBox image
                        PictureBox1.Image = resizedImg;
                    }
                }
                else
                {
                    // If no image is found, set PictureBox image to null
                    PictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private Image ResizeImage(Image imgToResize, int width, int height)
        {
            // Resize image while keeping aspect ratio
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;
            float ratio = Math.Min((float)width / sourceWidth, (float)height / sourceHeight);
            int newWidth = (int)(sourceWidth * ratio);
            int newHeight = (int)(sourceHeight * ratio);
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        private void payment_Click(object sender, EventArgs e)
        {
            payment Payment = new payment(); // สร้าง instance ของ UCproduct
                                             // เพิ่ม UCproduct เข้าไปใน Parent Control (Panel, Form, หรือ Control อื่นๆ)
                                             // ตัวอย่างเช่นถ้า UCproduct อยู่ใน Form ใหญ่ สามารถใช้คำสั่งนี้ได้
            this.Parent.Controls.Add(Payment);
            // นำ UCproduct มาแสดง
            Payment.Dock = DockStyle.Fill;
            Payment.BringToFront();
            // ลบ infoproduct ออกจาก Parent Control
            this.Parent.Controls.Remove(this);
        }

        private void delproductincart_Click(object sender, EventArgs e)
        {
            // Check if a product is selected
            if (!string.IsNullOrEmpty(IDTextBox1.Text))
            {
                string productId = Convert.ToString(IDTextBox1.Text);

                MySqlConnection conn = databaseConnection();

                try
                {
                    conn.Open();
                    // Confirmation dialog
                    DialogResult result = MessageBox.Show("คุณแน่ใจหรือไม่ที่ต้องการลบสินค้านี้ออกจากตะกร้า?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Delete the selected product from the cart
                        string deleteQuery = "DELETE FROM cart WHERE user_id = @user_id AND product_id = @product_id";
                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("@user_id", loginmember.LoggedInUserID);
                        deleteCmd.Parameters.AddWithValue("@product_id", productId);
                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        // Check if deletion was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ลบสินค้าออกจากตะกร้าเรียบร้อยแล้ว");
                            // Reload cart items to reflect changes
                            LoadCartItems();
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถลบสินค้าออกจากตะกร้าได้");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("โปรดเลือกสินค้าที่ต้องการลบ");
            }
        }
        private void backbut_Click(object sender, EventArgs e)
        {
            UCproduct ucProduct = new UCproduct(); // สร้าง instance ของ UCproduct
                                                   // เพิ่ม UCproduct เข้าไปใน Parent Control (Panel, Form, หรือ Control อื่นๆ)
                                                   // ตัวอย่างเช่นถ้า UCproduct อยู่ใน Form ใหญ่ สามารถใช้คำสั่งนี้ได้
            this.Parent.Controls.Add(ucProduct);
            // นำ UCproduct มาแสดง
            ucProduct.Dock = DockStyle.Fill;
            ucProduct.BringToFront();
            // ลบ infoproduct ออกจาก Parent Control
            this.Parent.Controls.Remove(this);
        }
        private void cartDataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is clicked and ensure it is not the new row for adding entries
            if (e.RowIndex >= 0 && !cartDataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                // Get the selected row
                DataGridViewRow row = cartDataGridView1.Rows[e.RowIndex];

                // Update the textboxes with the selected product details
                IDTextBox1.Text = row.Cells["product_id"].Value.ToString();
                nameproductTextBox2.Text = row.Cells["product_name"].Value.ToString();
                numproductTextBox3.Text = row.Cells["quantity"].Value.ToString();
                priceproductTextBox4.Text = row.Cells["price"].Value.ToString();
                totalpriceTextBox5.Text = row.Cells["total_price"].Value.ToString();

                // Load product image using the product ID
                string productId = IDTextBox1.Text; // productId is already a string, no need for Convert
                LoadProductImage(productId);
            }
        }
        //private void GenerateAndDisplayQRCode(decimal total)
        //{
        //    IPromptPayBuilder builder = PPay.DynamicQR;
        //    string qr = builder.MobileNumber("0636257988").Amount((double)total).CreateCreditTransferQrCode();

        //    QRCodeGenerator qrGenerator = new QRCodeGenerator();
        //    QRCodeData qrCodeData = qrGenerator.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q);
        //    QRCode qrCode = new QRCode(qrCodeData);
        //    Bitmap qrCodeImage = qrCode.GetGraphic(10);

        //    Bitmap resizedQRCodeImage = new Bitmap(qrCodeImage, new Size(202, 212));

        //    guna2PictureBox1.Image = resizedQRCodeImage;
        //}

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IDTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameproductTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceproductTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalpriceTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(totalpriceTextBox5.Text.Replace("฿", "").Replace(",", "").Trim(), out decimal parsedValue))
            {
                totalpriceTextBox5.Text = String.Format("{0:N0} ฿", parsedValue);
            }
        }

        private void numproductTextBox3_TextChanged(object sender, EventArgs e)
        {

        }


        
        private void totalall_TextChanged(object sender, EventArgs e)
        {

        }
            
        private void ป_Paint(object sender, PaintEventArgs e)
        {

        }

        private void qrPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cart_Load(object sender, EventArgs e)
        {

        }
    }
}