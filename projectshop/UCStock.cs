using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace projectshop
{
    public partial class UCStock : UserControl
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showITEM()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id, name, Category, detail, cost, Price, Amount, Photo FROM stock";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            ITEM.DataSource = ds.Tables[0].DefaultView;
            ITEM.ReadOnly = true;

            foreach (DataGridViewColumn column in ITEM.Columns)
            {
                column.Width = ITEM.Width / 4;
            }
        }

        private void LoadCategories()
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT Category FROM stock", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                categoryComboBox.Items.Add(reader["Category"].ToString());
            }

            conn.Close();
        }

        public UCStock()
        {
            InitializeComponent();
        }

        private void UCStock_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            string searchText = SearchTex.Text.Trim();
            string query = "SELECT ID, Name, Category, detail, cost, price, amount, photo FROM stock WHERE ID = @searchText OR Name = @searchName OR Name LIKE @searchName";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection());
                cmd.Parameters.AddWithValue("@searchText", searchText);
                cmd.Parameters.AddWithValue("@searchName", searchText);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    IDText.Text = ds.Tables[0].Rows[0]["ID"].ToString();
                    NameText.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    categoryComboBox.SelectedItem = ds.Tables[0].Rows[0]["Category"].ToString(); // Set selected category
                    detailTextbox.Text = ds.Tables[0].Rows[0]["detail"].ToString();
                    costtext.Text = ds.Tables[0].Rows[0]["cost"].ToString();
                    priceText.Text = ds.Tables[0].Rows[0]["price"].ToString();
                    amountText.Text = ds.Tables[0].Rows[0]["amount"].ToString();

                    byte[] imageData = (byte[])ds.Tables[0].Rows[0]["photo"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image originalImage = Image.FromStream(ms);
                        Image resizedImage = ResizeImage(originalImage, 294, 314);
                        PicBox.Image = resizedImage;
                    }

                    MessageBox.Show("พบข้อมูลที่ต้องการค้นหา");
                    ds.Tables[0].Columns.Remove("photo");
                    ITEM.DataSource = ds.Tables[0].DefaultView;

                    foreach (DataGridViewColumn column in ITEM.Columns)
                    {
                        column.Width = ITEM.Width / ITEM.Columns.Count;
                    }
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลที่ต้องการค้นหา");
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }

        private void UploadFileAndRegister(string filePath)
        {
            try
            {
                // Check if the selected file is an image
                if (!IsImageFile(filePath))
                {
                    MessageBox.Show("กรุณาเลือกไฟล์ภาพที่ถูกต้อง");
                    return;
                }

                Image originalImage = Image.FromFile(filePath);
                Image resizedImage = ResizeImage(originalImage, 294, 314);

                byte[] fileBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    resizedImage.Save(ms, originalImage.RawFormat);
                    fileBytes = ms.ToArray();
                }

                string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO stock (photo, id, Name, price, amount, category, detail, cost) VALUES (@photo, @id, @name, @price, @amount, @category, @detail, @cost)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@photo", fileBytes);
                        cmd.Parameters.AddWithValue("@id", IDText.Text.Trim());
                        cmd.Parameters.AddWithValue("@name", NameText.Text.Trim());
                        cmd.Parameters.AddWithValue("@category", categoryComboBox.SelectedItem);
                        cmd.Parameters.AddWithValue("@detail", detailTextbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@cost", costtext.Text.Trim());
                        cmd.Parameters.AddWithValue("@price", priceText.Text.Trim());
                        cmd.Parameters.AddWithValue("@amount", amountText.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            PicBox.Image = resizedImage; // Display the resized image
                            MessageBox.Show("อัพโหลดรูปสินค้าสำเร็จ!!");
                        }
                        else
                        {
                            MessageBox.Show("มีข้อผิดพลาดในการอัปโหลดรูปสินค้า");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }

        // Method to resize image
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedBitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedBitmap))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedBitmap;
        }

        // Method to check if the file is an image
        private bool IsImageFile(string filePath)
        {
            string[] validExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            string extension = Path.GetExtension(filePath).ToLower();
            return validExtensions.Contains(extension);
        }



        private void SearchAllBut_Click(object sender, EventArgs e)
        {
            showITEM();
            IDText.Text = "";
            NameText.Text = "";
            categoryComboBox.SelectedItem = null;
            detailTextbox.Text = "";
            costtext.Text = "";
            priceText.Text = "";
            amountText.Text = "";
            PicBox.Image = null; // ล้างรูปใน PictureBox
            MessageBox.Show("ข้อมูลสินค้าทั้งหมด");
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if (IDText.Text.Trim() == "" || NameText.Text.Trim() == "" || priceText.Text.Trim() == "" || amountText.Text.Trim() == "" || categoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง");
                return;
            }

            if (IsDuplicateName(NameText.Text.Trim()))
            {
                MessageBox.Show("ชื่อสินค้าซ้ำ กรุณาเปลี่ยนชื่อสินค้า!");
                return;
            }
            if (IsDuplicateID(IDText.Text.Trim()))
            {
                MessageBox.Show("รหัสสินค้าซ้ำ กรุณาเปลี่ยนเลขรหัสสินค้า!");
                return;
            }

            // Open file dialog for image selection
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select an Image File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                UploadFileAndRegister(filePath);
            }
        }


        private void ClearFields()
        {
            IDText.Text = "";
            NameText.Text = "";
            categoryComboBox.SelectedIndex = -1; // Clear selected category
            detailTextbox.Text = "";
            costtext.Text = "";
            priceText.Text = "";
            amountText.Text = "";
            PicBox.Image = null;
        }
        private bool IsDuplicateName(string name)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM stock WHERE Name = @name", conn);
            cmd.Parameters.AddWithValue("@name", name);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            return count > 0;
        }

        private bool IsDuplicateID(string id)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM stock WHERE ID = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();
            return count > 0;
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            string id = IDText.Text.Trim();  // ID ใหม่ที่ผู้ใช้ป้อน
            string name = NameText.Text.Trim();
            string category = categoryComboBox.SelectedItem?.ToString(); // ใช้หมวดหมู่ที่เลือก
            string detail = detailTextbox.Text.Trim();
            string cost = costtext.Text.Trim();
            string price = priceText.Text.Trim();
            string amount = amountText.Text.Trim();

            try
            {
                using (MySqlConnection conn = databaseConnection())
                {
                    conn.Open();

                    // ตรวจสอบว่ามี ID เดิมอยู่ในฐานข้อมูลหรือไม่
                    MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM stock WHERE id = @id", conn);
                    checkCmd.Parameters.AddWithValue("@id", id);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // อัปเดตข้อมูลในฐานข้อมูล
                        string updateQuery = "UPDATE stock SET name = @name, category = @category, detail = @detail, cost = @cost, price = @price, amount = @amount WHERE id = @id";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@id", id); // ID ใหม่
                        updateCmd.Parameters.AddWithValue("@name", name);
                        updateCmd.Parameters.AddWithValue("@category", category);
                        updateCmd.Parameters.AddWithValue("@detail", detail);
                        updateCmd.Parameters.AddWithValue("@cost", cost);
                        updateCmd.Parameters.AddWithValue("@price", price);
                        updateCmd.Parameters.AddWithValue("@amount", amount);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("บันทึกการแก้ไขข้อมูลแล้ว");
                            showITEM(); // แสดงข้อมูลหลังจากแก้ไข
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถบันทึกการแก้ไขข้อมูลได้");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลที่ต้องการแก้ไข");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }
    
        private void PicBox_Click(object sender, EventArgs e)
        {

        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            IDText.Text = "";
            NameText.Text = "";
            categoryComboBox.SelectedItem = null;
            detailTextbox.Text = "";
            priceText.Text = "";
            costtext.Text = "";
            amountText.Text = "";
            PicBox.Image = null;
            showITEM();
        }

        private void deletbut_Click(object sender, EventArgs e)
        {
            {
                string id = IDText.Text.Trim();

                try
                {
                    MySqlConnection conn = databaseConnection();
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM stock WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("ลบข้อมูลสินค้าสำเร็จ");
                        ClearFields();
                        showITEM();
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบข้อมูลที่ต้องการลบ");
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }

        private void EditpicBut_Click(object sender, EventArgs e)
        {
            // เช็คว่ามีการเลือกรหัสสมาชิกหรือไม่
            if (string.IsNullOrEmpty(IDText.Text.Trim()))
            {
                MessageBox.Show("กรุณาเลือกรหัสสินค้าก่อน");
                return;
            }

            // สร้าง OpenFileDialog สำหรับเลือกรูปภาพ
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff;*.jfif";

            // เมื่อผู้ใช้เลือกรูปภาพ
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // อ่านที่อยู่ของไฟล์รูปภาพที่เลือก
                    string filePath = openFileDialog.FileName;

                    // อ่านรหัสสมาชิกจาก TextBox
                    string memberId = IDText.Text.Trim();

                    // อ่านขนาดรูปภาพและปรับขนาดให้เป็น 312x382
                    Image selectedImage = Image.FromFile(filePath);
                    Image resizedImage = ResizeImage(selectedImage, 294, 314);

                    // แปลงรูปภาพเป็น byte array
                    byte[] imageData;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        resizedImage.Save(ms, selectedImage.RawFormat);
                        imageData = ms.ToArray();
                    }

                    // เชื่อมต่อฐานข้อมูล
                    using (MySqlConnection conn = databaseConnection())
                    {
                        conn.Open();

                        // สร้างคำสั่ง SQL เพื่ออัปเดตรูปภาพของสมาชิก
                        string query = "UPDATE stock SET photo = @photo WHERE id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@photo", imageData);
                            cmd.Parameters.AddWithValue("@id", memberId);

                            // ประมวลผลคำสั่ง SQL
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // แสดงรูปภาพใน PictureBox
                                PicBox.Image = resizedImage;
                                MessageBox.Show("อัปเดตรูปภาพสำเร็จ");
                            }
                            else
                            {
                                MessageBox.Show("ไม่สามารถอัปเดตรูปภาพได้");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }


        private void ITEM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ตรวจสอบว่าคลิกที่คอลัมน์ "ID" เท่านั้น
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = ITEM.Rows[e.RowIndex];
                IDText.Text = row.Cells["id"].Value.ToString();
                NameText.Text = row.Cells["Name"].Value.ToString();
                categoryComboBox.SelectedItem = row.Cells["Category"].Value.ToString(); // Set selected category
                detailTextbox.Text = row.Cells["detail"].Value.ToString();
                costtext.Text = row.Cells["cost"].Value.ToString();
                priceText.Text = row.Cells["price"].Value.ToString();
                amountText.Text = row.Cells["amount"].Value.ToString();

                if (ITEM.Columns.Contains("photo"))
                {
                    byte[] imageData = (byte[])row.Cells["photo"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image originalImage = Image.FromStream(ms);
                        Image resizedImage = ResizeImage(originalImage, 294, 314);
                        PicBox.Image = resizedImage;
                    }
                }
            }
        }

        private void showLatestItem(string id, string name)
        {
            try
            {
                // เชื่อมต่อกับฐานข้อมูล
                MySqlConnection conn = databaseConnection();
                conn.Open();

                // สร้างคำสั่ง SQL เพื่อดึงข้อมูลล่าสุดที่บันทึกเข้าไปเฉพาะ ID และ Name นั้นๆ
                string query = "SELECT ID, Name,category,detail,cost, Price, Amount FROM stock WHERE id = @id AND name = @name";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);

                // สร้าง DataAdapter และ DataSet เพื่อเก็บข้อมูล
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                // โชว์ข้อมูลในตาราง
                ITEM.DataSource = ds.Tables[0].DefaultView;

                // ปิดการเชื่อมต่อ
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void IDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountText_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTex_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PicBox_Click_1(object sender, EventArgs e)
        {

        }

        private void CategoryTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void detailTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void costtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}