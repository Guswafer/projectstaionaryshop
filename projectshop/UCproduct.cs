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

namespace projectshop
{
    public partial class UCproduct : UserControl
    {
        public UCproduct()
        {
            InitializeComponent();
            LoadPhoto();
            LoadCategories();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void LoadPhoto()
        {
            MySqlConnection conn = databaseConnection();
            string query = "SELECT id, name, price, Photo FROM stock";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string idProduct = reader.GetString("id");
                        string name = reader.GetString("name");
                        int price = reader.GetInt32("price");
                        byte[] photoBytes = (byte[])reader["Photo"];

                        // สร้าง Panel เพื่อเก็บข้อมูลสินค้าแต่ละรายการ
                        Panel panel = new Panel();
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Width = 250; // ปรับขนาดกว้างของพาเนล
                        panel.Height = 250; // ปรับขนาดสูงของพาเนล
                        panel.Margin = new Padding(30);
                        panel.Padding = new Padding(6);

                        // สร้าง PictureBox เพื่อแสดงรูปภาพสินค้า
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromStream(new System.IO.MemoryStream(photoBytes));
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 170; // ปรับขนาดความกว้างของ PictureBox
                        pictureBox.Height = 170 ; // ปรับขนาดความสูงของ PictureBox
                        pictureBox.Dock = DockStyle.Top;

                        // เพิ่ม Click Event ให้ PictureBox
                        pictureBox.Click += (s, e) => PictureBox_Click(s, e, idProduct);

                        // สร้าง Label สำหรับชื่อสินค้า
                        Label nameLabel = new Label();
                        nameLabel.Text = name;
                        nameLabel.AutoSize = true;
                        nameLabel.Dock = DockStyle.Top;
                        nameLabel.Font = new Font("LilyUPC", 25, FontStyle.Bold);

                        // สร้าง Label สำหรับราคา
                        Label priceLabel = new Label();
                        priceLabel.Text = price.ToString("N0") + " ฿";
                        priceLabel.AutoSize = true;
                        priceLabel.Dock = DockStyle.Bottom;
                        priceLabel.Font = new Font("LilyUPC", 20, FontStyle.Bold);

                        // เพิ่ม PictureBox, Name Label, และ Price Label เข้าไปใน Panel
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(nameLabel);
                        panel.Controls.Add(priceLabel);

                        // เพิ่ม Panel ลงใน FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(panel);
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

        private void LoadCategories()
        {
            MySqlConnection conn = databaseConnection();
            string query = "SELECT DISTINCT category FROM stock"; // เลือก DISTINCT เพื่อให้ไม่ซ้ำกัน
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string categoryName = reader.GetString("category");
                        categoryComboBox.Items.Add(categoryName);
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

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = categoryComboBox.SelectedItem.ToString();
            LoadProductsByCategory(selectedCategory);
        }

        private void LoadProductsByCategory(string category)
        {
            MySqlConnection conn = databaseConnection();
            string query = "SELECT id, name, price, Photo FROM stock WHERE category = @category";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@category", category);

            try
            {
                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Clear existing products
                    flowLayoutPanel1.Controls.Clear();
                    while (reader.Read())
                    {
                        string idProduct = reader.GetString("id");
                        string name = reader.GetString("name");
                        int price = reader.GetInt32("price");
                        byte[] photoBytes = (byte[])reader["Photo"];

                        // Create Panel
                        Panel panel = new Panel();
                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Width = 250; // Adjust panel width
                        panel.Height = 250; // Adjust panel height
                        panel.Margin = new Padding(30);
                        panel.Padding = new Padding(6);

                        // Create PictureBox
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromStream(new System.IO.MemoryStream(photoBytes));
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 170; // Adjust PictureBox width
                        pictureBox.Height = 170; // Adjust PictureBox height
                        pictureBox.Dock = DockStyle.Top;

                        // Add Click Event to PictureBox
                        pictureBox.Click += (s, e) => PictureBox_Click(s, e, idProduct);

                        // Create Label for product name
                        Label nameLabel = new Label();
                        nameLabel.Text = name;
                        nameLabel.AutoSize = true;
                        nameLabel.Dock = DockStyle.Top;
                        nameLabel.Font = new Font("LilyUPC", 25, FontStyle.Bold);

                        // Create Label for price
                        Label priceLabel = new Label();
                        priceLabel.Text = price.ToString("N0") + " ฿"; // ใช้ "N0" เพื่อใส่คอมม่าในเลขราคา
                        priceLabel.AutoSize = true;
                        priceLabel.Dock = DockStyle.Bottom;
                        priceLabel.Font = new Font("LilyUPC", 20, FontStyle.Bold);


                        // Add PictureBox, Name Label, and Price Label to Panel
                        panel.Controls.Add(pictureBox);
                        panel.Controls.Add(nameLabel);
                        panel.Controls.Add(priceLabel);

                        // Add Panel to FlowLayoutPanel
                        flowLayoutPanel1.Controls.Add(panel);
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

        private void PictureBox_Click(object sender, EventArgs e, string idProduct)
        {
            // สร้าง UserControl ใหม่ของหน้า infoproduct และส่ง ID สินค้าไปยัง Constructor
            infoproduct InfoProductForm = new infoproduct(idProduct);

            // เพิ่ม UserControl ใหม่ลงใน Container Control ของหน้าปัจจุบัน
            // ในกรณีนี้คือ UserControl ที่มี FlowLayoutPanel เป็น Container Control
            this.Parent.Controls.Add(InfoProductForm);

            // ปิด UserControl ปัจจุบัน (UCproduct) หลังจากเปิด UserControl ใหม่ (infoproduct)
            this.Dispose();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Do nothing
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // เมื่อเลือกหมวดหมู่ใหม่ เรียกเมธอดโหลดสินค้าอีกครั้งโดยใช้ชื่อหมวดหมู่ที่เลือก
            string selectedCategory = categoryComboBox.SelectedItem.ToString();
            LoadProductsByCategory(selectedCategory);

        }

        private void UCproduct_Load(object sender, EventArgs e)
        {
            // Do nothing
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
