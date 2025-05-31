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

namespace projectshop
{
    public partial class infoproduct : UserControl
    {
        public infoproduct(string idproduct) // เปลี่ยนจาก int เป็น string
        {
            InitializeComponent();
            LoadProductDetails(idproduct);
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void LoadProductDetails(string idProduct) // เปลี่ยนจาก int เป็น string
        {
            MySqlConnection conn = databaseConnection();
            string query = "SELECT id, name, detail, price, Photo, amount FROM stock WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", idProduct); // ใช้ idProduct ตรงๆ ไม่ต้องแปลง

            try
            {
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idproduct.Text = reader.GetString("id"); // แปลงเป็น string
                        nameproduct.Text = reader.GetString("name");
                        detailproduct.Text = reader.GetString("detail");
                        priceproduct.Text = reader.GetDecimal("price").ToString("F2");
                        amountproduct.Text = reader.GetInt32("amount").ToString();

                        byte[] photoBytes = (byte[])reader["Photo"];
                        using (MemoryStream ms = new MemoryStream(photoBytes))
                        {
                            Picboxid.Image = Image.FromStream(ms);
                            Picboxid.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }

                // ปิด DataReader ก่อนที่จะทำการ query ครั้งถัดไป
                conn.Close();
                conn.Open();

                // ตรวจสอบจำนวนสินค้าที่มีอยู่ในตะกร้า
                string checkCartQuery = "SELECT quantity FROM cart WHERE user_id = @user_id AND product_id = @product_id";
                MySqlCommand checkCartCmd = new MySqlCommand(checkCartQuery, conn);
                checkCartCmd.Parameters.AddWithValue("@user_id", loginmember.LoggedInUserID);
                checkCartCmd.Parameters.AddWithValue("@product_id", idProduct); // ใช้ idProduct ตรงๆ

                object result = checkCartCmd.ExecuteScalar();
                if (result != null)
                {
                    numproduct.Text = result.ToString();
                }
                else
                {
                    numproduct.Text = "1"; // ค่าเริ่มต้นคือ 1 หากไม่มีสินค้าในตะกร้า
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

        private void addtocart_Click(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(numproduct.Text, out quantity) && quantity > 0)
            {
                int availableAmount = int.Parse(amountproduct.Text);
                if (quantity <= availableAmount) // ตรวจสอบจำนวนสินค้าว่ามีพอหรือไม่
                {
                    MySqlConnection conn = databaseConnection();
                    string checkQuery = "SELECT quantity, price FROM cart WHERE user_id = @user_id AND product_id = @product_id";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@user_id", loginmember.LoggedInUserID);
                    checkCmd.Parameters.AddWithValue("@product_id", idproduct.Text); // ใช้ idproduct ตรงๆ

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // ถ้ามีสินค้าอยู่แล้วในตะกร้า ให้แก้ไขจำนวนสินค้าและราคาสินค้าในตะกร้าให้ตรงกับ quantity
                                int existingQuantity = reader.GetInt32("quantity");
                                decimal price = reader.GetDecimal("price");
                                decimal totalPrice = quantity * price;

                                // ปิด DataReader ก่อนที่จะทำการ query ครั้งถัดไป
                                reader.Close();

                                string updateQuery = "UPDATE cart SET quantity = @quantity, total_price = @total_price WHERE user_id = @user_id AND product_id = @product_id";
                                MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                                updateCmd.Parameters.AddWithValue("@quantity", quantity);
                                updateCmd.Parameters.AddWithValue("@total_price", totalPrice);
                                updateCmd.Parameters.AddWithValue("@user_id", loginmember.LoggedInUserID);
                                updateCmd.Parameters.AddWithValue("@product_id", idproduct.Text); // ใช้ idproduct ตรงๆ
                                updateCmd.ExecuteNonQuery();
                                MessageBox.Show("อัปเดตจำนวนสินค้าในตะกร้าแล้ว");
                            }
                            else
                            {
                                // ถ้าไม่มีสินค้าอยู่ในตะกร้า ให้เพิ่มสินค้าใหม่ในตะกร้า
                                decimal price = decimal.Parse(priceproduct.Text);
                                decimal totalPrice = quantity * price;

                                reader.Close();

                                string insertQuery = "INSERT INTO cart (user_id, product_id, product_name, quantity, price, total_price) VALUES (@user_id, @product_id, @product_name, @quantity, @price, @total_price)";
                                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                                insertCmd.Parameters.AddWithValue("@user_id", loginmember.LoggedInUserID);
                                insertCmd.Parameters.AddWithValue("@product_id", idproduct.Text); // ใช้ idproduct ตรงๆ
                                insertCmd.Parameters.AddWithValue("@product_name", nameproduct.Text);
                                insertCmd.Parameters.AddWithValue("@quantity", quantity);
                                insertCmd.Parameters.AddWithValue("@price", price);
                                insertCmd.Parameters.AddWithValue("@total_price", totalPrice);
                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("เพิ่มสินค้าลงตะกร้าแล้ว");
                            }
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
                else
                {
                    MessageBox.Show("จำนวนสินค้าไม่เพียงพอ");
                }
            }
            else
            {
                MessageBox.Show("กรุณาใส่จำนวนสินค้าที่ถูกต้อง");
            }
        }
        private void backbut_Click(object sender, EventArgs e)
        {
            UCproduct ucProduct = new UCproduct(); // สร้าง instance ของ UCproduct
            // เพิ่ม UCproduct เข้าไปใน Parent Control (Panel, Form, หรือ Control อื่นๆ)
            this.Parent.Controls.Add(ucProduct);
            // นำ UCproduct มาแสดง
            ucProduct.Dock = DockStyle.Fill;
            ucProduct.BringToFront();
            // ลบ infoproduct ออกจาก Parent Control
            this.Parent.Controls.Remove(this);
        }
        private void buttondel_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(numproduct.Text);
            if (currentValue > 0)
            {
                numproduct.Text = (currentValue - 1).ToString();
            }
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            int currentValue = int.Parse(numproduct.Text);
            numproduct.Text = (currentValue + 1).ToString();
        }
        private void infoproduct_Load(object sender, EventArgs e)
        {

        }

        private void Picboxid_Click(object sender, EventArgs e)
        {

        }

        

        private void idproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void detailproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void numproduct_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
