using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QRCoder;
using Saladpuk.PromptPay.Contracts;
using Saladpuk.PromptPay.Facades;
using System.IO;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace projectshop
{
    public partial class payment : UserControl
    {
        public payment()
        {
            InitializeComponent();
            LoadCartItems();
            cartDataGridView1.CellFormatting += cartDataGridView1_CellFormatting;
        }

       
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void LoadCartItems()
        {
            MySqlConnection conn = databaseConnection();

            try
            {
                conn.Open();
                string query = "SELECT product_id, product_name, quantity, price, total_price,total_cost FROM cart WHERE user_id = @user_id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_id", loginmember.LoggedInUserID);

                DataTable dt = new DataTable();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }

                cartDataGridView1.DataSource = dt;
                cartDataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                cartDataGridView1.Columns["total_cost"].Visible = false;
                decimal total = CalculateTotal(dt);
                UpdateFinancialDetails(total);
                GenerateAndDisplayQRCode();
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
        private decimal CalculateTotal(DataTable dt)
        {
            decimal total = 0;

            foreach (DataRow row in dt.Rows)
            {
                total += Convert.ToDecimal(row["total_price"]);
            }

            totalprice.Text = "ราคาสินค้า: " + total.ToString("N2") + " ฿";
            return total;
        }

        
        private void GenerateAndDisplayQRCode()
        {
            if (decimal.TryParse(TotalsumTextBox1.Text.Replace("ราคารวม: ", "").Replace(" ฿", ""), out decimal total))
            {
                IPromptPayBuilder builder = PPay.DynamicQR;
                string qr = builder.MobileNumber("0636257988").Amount((double)total).CreateCreditTransferQrCode();

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(10);

                Bitmap resizedQRCodeImage = new Bitmap(qrCodeImage, new Size(324, 307));

                qrPictureBox1.Image = resizedQRCodeImage;
            }
            else
            {
                MessageBox.Show("Invalid total amount for QR code generation.");
            }
        }
        private void backbut_Click(object sender, EventArgs e)
        {
            cart Cart = new cart(); // สร้าง instance ของ UCproduct
                                                   // เพิ่ม UCproduct เข้าไปใน Parent Control (Panel, Form, หรือ Control อื่นๆ)
                                                   // ตัวอย่างเช่นถ้า UCproduct อยู่ใน Form ใหญ่ สามารถใช้คำสั่งนี้ได้
            this.Parent.Controls.Add(Cart);
            // นำ UCproduct มาแสดง
            Cart.Dock = DockStyle.Fill;
            Cart.BringToFront();
            // ลบ infoproduct ออกจาก Parent Control
            this.Parent.Controls.Remove(this);
        }

        private void ConfirmpaymentButton1_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีการเลือกไฟล์ slip หรือไม่
            OpenFileDialog openFileDialog = new OpenFileDialog(); 
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff;*.jfif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // นำข้อมูลการสั่งซื้อมาเตรียมสำหรับบันทึกลงในฐานข้อมูล
                string userID = loginmember.LoggedInUserID;
                string userName = GetUserName(userID);
                DataTable cartItems = (DataTable)cartDataGridView1.DataSource;
                decimal totalCost = CalculateTotalCostFromCart(cartItems);
                decimal totalPrice = CalculateTotal(cartItems);
                decimal vat7 = decimal.Parse(vat7TextBox1.Text.Replace("Vat 7%: ", "").Replace(" ฿", ""));
                decimal discount = decimal.Parse(discounttextbox.Text.Replace("ส่วนลด 5%: ", "").Replace(" ฿", ""));
                decimal sumTotal = decimal.Parse(TotalsumTextBox1.Text.Replace("ราคารวม: ", "").Replace(" ฿", ""));
                decimal sumPrice = decimal.Parse(sumpriceTextBox1.Text.Replace("ราคาลด: ", "").Replace(" ฿", ""));

                MySqlConnection conn = databaseConnection();
                try
                {
                    conn.Open();

                    // Generate a unique order ID for the transaction
                    string orderid = GenerateUniqueOrderID(conn);

                    string query = @"INSERT INTO ordercustomer (user_id, user_name, product_id, product_name, quantity, total_price, vat7, discounttotal, sum_total, sum_price, total_cost, date, time, slip, orderid, status) 
VALUES (@userID, @userName, @productID, @productName, @quantity, @totalPrice, @vat7, @discounttotal, @sumTotal, @sumPrice, @totalCost, @Date, @Time, @slip, @orderid, 'รอยืนยันคำสั่งซื้อ')";

                    foreach (DataRow row in cartItems.Rows)
                    {
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@productID", row["product_id"]);
                        cmd.Parameters.AddWithValue("@productName", row["product_name"]);
                        cmd.Parameters.AddWithValue("@quantity", row["quantity"]);
                        cmd.Parameters.AddWithValue("@totalPrice", row["total_price"]);
                        cmd.Parameters.AddWithValue("@vat7", vat7);
                        cmd.Parameters.AddWithValue("@discounttotal", discount);
                        cmd.Parameters.AddWithValue("@sumTotal", sumTotal);
                        cmd.Parameters.AddWithValue("@sumPrice", sumPrice);
                        cmd.Parameters.AddWithValue("@totalCost", totalCost); // ใส่ total_cost ที่คำนวณได้
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToString("dd/MM/yyyy")); // วันที่ปัจจุบัน
                        cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString("HH:mm:ss")); // เวลาปัจจุบัน

                        // Resize the image slip and convert it to a byte array
                        byte[] imageData = ResizeImage(imagePath, 402, 543);
                        cmd.Parameters.AddWithValue("@slip", imageData);
                        cmd.Parameters.AddWithValue("@orderid", orderid);
                        cmd.ExecuteNonQuery();
                    }

                    // ลดจำนวนสินค้าที่ซื้อออกจาก stock ในฐานข้อมูล
                    foreach (DataRow row in cartItems.Rows)
                    {
                        UpdateStock(row["product_id"].ToString(), int.Parse(row["quantity"].ToString()), conn);
                    }

                    // ลบรายการสินค้าที่ถูกชำระเงินออกจากตะกร้า
                    ClearCart(userID, conn);

                    // Generate PDF receipt
                    GeneratePdfReceipt(userName, cartItems, vat7, discount, sumTotal, sumPrice, imagePath, totalPrice);

                    MessageBox.Show("จ่ายเงินสำเร็จ");

                    // กลับไปยังหน้าจอหลักหลังจากการทำรายการเสร็จสิ้น
                    cart Cart = new cart();
                    this.Parent.Controls.Add(Cart);
                    Cart.Dock = DockStyle.Fill;
                    Cart.BringToFront();
                    this.Parent.Controls.Remove(this);
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
            else
            {
                MessageBox.Show("กรุณาเลือกรูปภาพสลิปการโอนเงิน");
            }
        }

        private decimal CalculateTotalCostFromCart(DataTable cartItems)
        {
            decimal totalCost = 0;

            foreach (DataRow row in cartItems.Rows)
            {
                totalCost += Convert.ToDecimal(row["total_cost"]); // รวมค่า total_cost จากแต่ละแถว
            }

            return totalCost; // คืนค่าผลรวม
        }

        // Helper method to resize the image
        private byte[] ResizeImage(string imagePath, int width, int height)
        {
            using (Image originalImage = Image.FromFile(imagePath))
            {
                Bitmap resizedImage = new Bitmap(width, height);
                using (Graphics graphics = Graphics.FromImage(resizedImage))
                {
                    graphics.DrawImage(originalImage, 0, 0, width, height);
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    resizedImage.Save(ms, originalImage.RawFormat);
                    return ms.ToArray();
                }
            }
        }


        private static int orderCounter = 0; // Counter for order IDs
        private static readonly object orderCounterLock = new object(); // Lock for thread-safety

        private int GetLastOrderID(MySqlConnection conn)
        {
            int lastOrderID = 0;
            try
            {
                string query = "SELECT MAX(orderid) FROM ordercustomer WHERE user_id = @userID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", loginmember.LoggedInUserID);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    lastOrderID = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching last order ID: " + ex.Message);
            }
            return lastOrderID;
        }

        private string GenerateUniqueOrderID(MySqlConnection conn)
        {
            lock (orderCounterLock)
            {
                // ทำการเพิ่ม orderCounter ก่อนเพื่อให้มั่นใจว่ามีหมายเลขใหม่
                orderCounter++;

                // ตรวจสอบว่า orderCounter นี้มีอยู่ในฐานข้อมูลหรือไม่
                while (IsOrderIDExists(conn, orderCounter))
                {
                    orderCounter++; // ถ้ามีอยู่แล้วให้เพิ่มค่า orderCounter
                }

                return orderCounter.ToString();
            }
        }

        // ฟังก์ชันสำหรับตรวจสอบว่า orderID มีอยู่ในฐานข้อมูลหรือไม่
        private bool IsOrderIDExists(MySqlConnection conn, int orderId)
        {
            string query = "SELECT COUNT(*) FROM ordercustomer WHERE orderid = @OrderID";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0; // ถ้ามีหมายเลขนี้จะส่งคืน true
            }
        }




        public void GeneratePdfReceipt(string userName, DataTable cartItems, decimal vat7, decimal discount, decimal sumTotal, decimal sumPrice, string imagePath, decimal total)
        {
            try
            {
                string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Receipt.pdf");
                PdfDocument document = new PdfDocument();
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                // Set margins and font
                double margin = 30;
                XFont font = new XFont("Angsana New", 12, XFontStyle.Regular);
                XFont boldFont = new XFont("Angsana New", 12, XFontStyle.Bold);
                double yPoint = margin;

                // Header Section
                gfx.DrawString("ใบเสร็จรับเงิน", boldFont, XBrushes.Black, new XRect(0, yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopCenter);
                yPoint += 40;

                gfx.DrawString("Staionary Shop By Gus", boldFont, XBrushes.Black, new XPoint(margin, yPoint));
                yPoint += 20;
                gfx.DrawString("140/313 อุดลยาราม ซอย ๗/๑๐ ตำบลในเมือง อำเภอเมืองขอนแก่น ขอนแก่น 40000", font, XBrushes.Black, new XPoint(margin, yPoint));
                yPoint += 20;
                gfx.DrawString($"เบอร์โทร: 012-345-6789", font, XBrushes.Black, new XPoint(margin, yPoint)); // Phone number
                yPoint += 35;
                gfx.DrawString($"ชื่อผู้ใช้: {userName}", font, XBrushes.Black, new XPoint(margin, yPoint));
                yPoint += 20;
                gfx.DrawString($"วันที่: {DateTime.Now:dd/MM/yyyy}", font, XBrushes.Black, new XPoint(margin, yPoint));
                yPoint += 20;
                gfx.DrawString($"เวลา: {DateTime.Now:HH:mm:ss}", font, XBrushes.Black, new XPoint(margin, yPoint));
                yPoint += 30;

                    // Table Header
                    gfx.DrawLine(XPens.Black, margin, yPoint, page.Width - margin, yPoint);  // Top border
                    yPoint += 15;
                // Draw Header Cells
                gfx.DrawString("สินค้า", boldFont, XBrushes.Black, new XPoint(margin+5, yPoint+ 0));
                    gfx.DrawString("จำนวน", boldFont, XBrushes.Black, new XPoint(margin + 112, yPoint + 0));
                    gfx.DrawString("ราคา", boldFont, XBrushes.Black, new XPoint(margin + 176, yPoint + 0));
                    gfx.DrawString("ราคารวม", boldFont, XBrushes.Black, new XPoint(margin + 275, yPoint + 0));
                gfx.DrawString("หมายเหตุ", boldFont, XBrushes.Black, new XPoint(margin + 435, yPoint + 0));
                // Draw vertical lines for header
                gfx.DrawLine(XPens.Black, margin + 100, yPoint - 15, margin + 100, yPoint + 5); // First vertical line
                    gfx.DrawLine(XPens.Black, margin + 150, yPoint - 15, margin + 150, yPoint + 5); // Second vertical line
                    gfx.DrawLine(XPens.Black, margin + 220, yPoint - 15, margin + 220, yPoint + 5); // Third vertical line
                gfx.DrawLine(XPens.Black, margin + 363, yPoint - 15, margin + 363, yPoint + 5); // Third vertical line
                yPoint += 10;

                    // Draw horizontal line for header bottom border
                    gfx.DrawLine(XPens.Black, margin, yPoint, page.Width - margin, yPoint);  // Header bottom border
                    yPoint += 5; // Space before content

                // Table Content
                // Table Content
                foreach (DataRow row in cartItems.Rows)
                {
                    // Draw Content Cells
                    gfx.DrawString(row["product_name"].ToString(), font, XBrushes.Black, new XPoint(margin + 5, yPoint + 10));
                    gfx.DrawString(row["quantity"].ToString(), font, XBrushes.Black, new XPoint(margin + 122, yPoint + 10));
                    gfx.DrawString($"{Convert.ToDecimal(row["price"]):N2}", font, XBrushes.Black, new XPoint(margin + 178, yPoint + 10));
                    gfx.DrawString($"{Convert.ToDecimal(row["total_price"]):N2}", font, XBrushes.Black, new XPoint(margin + 280, yPoint + 10));

                    // Draw vertical lines for content
                    gfx.DrawLine(XPens.Black, margin + 100, yPoint - 15, margin + 100, yPoint + 20); // First vertical line
                    gfx.DrawLine(XPens.Black, margin + 0, yPoint - 30, margin + 0, yPoint + 20);     // Second vertical line (Left)
                    gfx.DrawLine(XPens.Black, margin + 535, yPoint - 30, margin + 535, yPoint + 20); // Third vertical line (Right)
                    gfx.DrawLine(XPens.Black, margin + 150, yPoint - 15, margin + 150, yPoint + 20); // Fourth vertical line
                    gfx.DrawLine(XPens.Black, margin + 220, yPoint - 15, margin + 220, yPoint + 20); // Fifth vertical line
                    gfx.DrawLine(XPens.Black, margin + 363, yPoint - 15, margin + 363, yPoint + 20); // Third vertical line
                    // Draw horizontal line between items
                    gfx.DrawLine(XPens.Black, margin, yPoint + 20, page.Width - margin, yPoint + 20); // Horizontal line after each item

                    yPoint += 20; // Move to the next row
                }


                // Draw final bottom border of the table
                gfx.DrawLine(XPens.Black, margin, yPoint, page.Width - margin, yPoint);  // Content bottom border
                yPoint += 15;


                // Summary Section
                gfx.DrawString($"ราคาสินค้า: {sumPrice:N2} บาท", font, XBrushes.Black, new XPoint(page.Width - 200, yPoint));
                yPoint += 20;
                gfx.DrawString($"ส่วนลด: {discount:N2} บาท", font, XBrushes.Black, new XPoint(page.Width - 200, yPoint));
                yPoint += 20;
                gfx.DrawString($"ภาษีมูลค่าเพิ่ม 7%: {vat7:N2} บาท", font, XBrushes.Black, new XPoint(page.Width - 200, yPoint));
                yPoint += 20;
                gfx.DrawLine(XPens.Black, page.Width - 200, yPoint, page.Width - margin, yPoint);  // Line above total
                yPoint += 20;
                gfx.DrawString($"ราคารวมสุทธิ: {sumTotal:N2} บาท", boldFont, XBrushes.Black, new XPoint(page.Width - 200, yPoint));
                yPoint += 15;

                // Footer Section
                gfx.DrawString("ขอบคุณที่ใช้บริการ!", boldFont, XBrushes.Black, new XPoint(margin, yPoint));
                yPoint += 20;
                gfx.DrawString("อย่าลืมแวะมาอีกนะครับ!", font, XBrushes.Black, new XPoint(margin, yPoint));
                yPoint += 20;

                

                // Save document
                document.Save(pdfPath);
                MessageBox.Show("สลิปใบเสร็จถูกสร้างขึ้นแล้ว.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF: " + ex.Message);
            }
        }


        private void UpdateFinancialDetails(decimal total)
        {
            decimal discount = total * 0.05m; // 5% discount
            decimal discountedTotal = total - discount; // Total after discount

            decimal vat7 = discountedTotal * 0.07m; // VAT on the discounted total
            decimal finalTotal = discountedTotal + vat7; // Final total after applying VAT

            // Rounding logic for the final total
            vat7TextBox1.Text = "Vat 7%: " + vat7.ToString("N2") + " ฿";
            sumpriceTextBox1.Text = "ราคาลด: " + discountedTotal.ToString("N2") + " ฿";
            discounttextbox.Text = "ส่วนลด 5%: " + discount.ToString("N2") + " ฿";
            TotalsumTextBox1.Text = "ราคารวม: " + finalTotal.ToString("N2") + " ฿";
        }

        private void ClearCart(string userID, MySqlConnection conn)
        {
            try
            {
                string query = "DELETE FROM cart WHERE user_id = @userID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.ExecuteNonQuery();

                // รีเซ็ตตารางหลังจากเคลียร์ตะกร้า
                ResetCartTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing cart: " + ex.Message);
            }
        }

        private string GetUserName(string userID)
        {
            string userName = "";
            MySqlConnection conn = databaseConnection();
            try
            {
                conn.Open();
                string query = "SELECT name FROM member WHERE id = @userID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                userName = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return userName;
        }

        private void UpdateStock(string ID, int quantity, MySqlConnection conn)
        {
            try
            {
                string query = "UPDATE stock SET amount = amount - @quantity WHERE id = @ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ResetCartTable()
        {
            DataTable emptyTable = new DataTable();
            cartDataGridView1.DataSource = emptyTable;
            cartDataGridView1.Refresh();
        }
        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void ป_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vat7TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sumtotalTextBox1_TextChanged(object sender, EventArgs e)
        {

        }   

        private void discounttextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalsumTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cartDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
