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
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace projectshop
{
    public partial class UCMemberAcc : UserControl
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public UCMemberAcc()
        {
            InitializeComponent();
        }
        private void showITEM()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name, Email, Tel, Username, Password, Address FROM member";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.ReadOnly = true;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = dataGridView1.Width / 4;
            }
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            string searchText = SearchTex.Text.Trim();
            string query = "SELECT ID, Name, Email, Tel, Username, Password, Address FROM member WHERE ID = @searchText OR Tel = @searchTel OR Name LIKE @searchName ORDER BY Name = @searchName DESC";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection());
                cmd.Parameters.AddWithValue("@searchText", searchText);
                cmd.Parameters.AddWithValue("@searchTel", searchText);
                cmd.Parameters.AddWithValue("@searchName", "%" + searchText + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    IDText.Text = ds.Tables[0].Rows[0]["ID"].ToString();
                    nametext.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    EmailText.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                    TelText.Text = ds.Tables[0].Rows[0]["Tel"].ToString();
                    UserText.Text = ds.Tables[0].Rows[0]["Username"].ToString();
                    PasswordText.Text = ds.Tables[0].Rows[0]["Password"].ToString();
                    addresstextBox1.Text = ds.Tables[0].Rows[0]["Address"].ToString();

                    MessageBox.Show("พบข้อมูลที่ต้องการค้นหา");

                    // Adjust column widths
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลที่ต้องการค้นหา");
                    ClearTextBoxes();
                    dataGridView1.DataSource = null; // Clear the DataGridView
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
                byte[] imageBytes = File.ReadAllBytes(filePath);

                using (MySqlConnection conn = databaseConnection())
                {
                    conn.Open();

                    string query = "INSERT INTO member (ID, Name, Email, Tel, Username, Password, Address) VALUES (@ID, @Name, @Email, @Tel, @Username, @Password, @Address)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", IDText.Text.Trim());
                        cmd.Parameters.AddWithValue("@Name", nametext.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", EmailText.Text.Trim());
                        cmd.Parameters.AddWithValue("@Tel", TelText.Text.Trim());
                        cmd.Parameters.AddWithValue("@Username", UserText.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", PasswordText.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", addresstextBox1.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                MessageBox.Show("บันทึกข้อมูลสำเร็จ");
                showITEM();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }
        private void ClearTextBoxes()
        {
            IDText.Text = string.Empty;
            nametext.Text = string.Empty;
            EmailText.Text = string.Empty;
            TelText.Text = string.Empty;
            UserText.Text = string.Empty;
            PasswordText.Text = string.Empty;
            addresstextBox1.Text = string.Empty;
        }

        private void SearchAllBut_Click(object sender, EventArgs e)
        {
            showITEM();
            IDText.Text = "";
            nametext.Text = "";
            EmailText.Text = "";
            TelText.Text = "";
            UserText.Text = "";
            PasswordText.Text = "";
            addresstextBox1.Text = "";
            //PicBox.Image = null; // ล้างรูปใน PictureBox
            MessageBox.Show("ข้อมูลสมาชิกทั้งหมด");
        }

        private void SaveBut_Click(object sender, EventArgs e)
        {
            if (IDText.Text.Trim() == "" || nametext.Text.Trim() == "" || EmailText.Text.Trim() == "" || TelText.Text.Trim() == "" || UserText.Text.Trim() == "" || PasswordText.Text.Trim() == "" || addresstextBox1.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง");
                return;
            }

            if (IsDuplicateID(IDText.Text.Trim()))
            {
                MessageBox.Show("รหัสสมาชิกซ้ำ กรุณาเปลี่ยนเลขรหัสสมาชิก!");
                return;
            }

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                UploadFileAndRegister(filePath);
            }
        }

        private void EditBut_Click(object sender, EventArgs e)
        {
            string id = IDText.Text.Trim();
            string name = nametext.Text.Trim();
            string Email = EmailText.Text.Trim();
            string Tel = TelText.Text.Trim();
            string Username = UserText.Text.Trim();
            string Password = PasswordText.Text.Trim();
            string Address = addresstextBox1.Text.Trim();

            try
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();

                MySqlCommand checkCmd = new MySqlCommand("SELECT COUNT(*) FROM member WHERE id = @id", conn);
                checkCmd.Parameters.AddWithValue("@id", id);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    string updateQuery = "UPDATE member SET name = @name, Email = @Email, Tel = @Tel, Username = @Username, Password = @Password, Address = @Address WHERE id = @id";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@name", name);
                    updateCmd.Parameters.AddWithValue("@Email", Email);
                    updateCmd.Parameters.AddWithValue("@Tel", Tel);
                    updateCmd.Parameters.AddWithValue("@id", id);
                    updateCmd.Parameters.AddWithValue("@Username", Username);
                    updateCmd.Parameters.AddWithValue("@Password", Password);
                    updateCmd.Parameters.AddWithValue("@Address", Address);

                    int rowsAffected = updateCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("บันทึกการแก้ไขข้อมูลแล้ว");
                        showLatestItem(id, name);
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถบันทึกการแก้ไขข้อมูลได้");
                    }
                }
                else
                {
                    MessageBox.Show("ไม่พบรหัสสมาชิกนี้ในฐานข้อมูล");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            IDText.Text = "";
            nametext.Text = "";
            EmailText.Text = "";
            TelText.Text = "";
            UserText.Text = "";
            PasswordText.Text = "";
            addresstextBox1.Text = "";
            //PicBox.Image = null;
        }

        private void deletbut_Click(object sender, EventArgs e)
        {
            {
                // ดึงรหัสสินค้าที่ต้องการลบจาก TextBox
                string id = IDText.Text.Trim();

                try
                {
                    // เชื่อมต่อกับฐานข้อมูล
                    MySqlConnection conn = databaseConnection();
                    conn.Open();

                    // สร้างคำสั่ง SQL เพื่อลบข้อมูล
                    string deleteQuery = "DELETE FROM member WHERE id = @id";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@id", id);

                    // ประมวลผลคำสั่ง SQL เพื่อลบข้อมูล
                    int rowsAffected = deleteCmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("ลบข้อมูลสำเร็จ");
                        showITEM();
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบข้อมูลได้ ไม่พบรหัสสมาชิกที่ต้องการลบ");
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }

            }
        }
        private void showLatestItem(string id, string name)
        {
            try
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();

                string query = "SELECT ID, Name, Email, Tel, Username, Password, Address FROM member WHERE id = @id AND name = @name";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0].DefaultView;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }
        private void ITEM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                IDText.Text = row.Cells["ID"].Value.ToString();
                nametext.Text = row.Cells["Name"].Value.ToString();
                EmailText.Text = row.Cells["Email"].Value.ToString();
                                addresstextBox1.Text = row.Cells["Address"].Value.ToString();
                TelText.Text = row.Cells["Tel"].Value.ToString();
                UserText.Text = row.Cells["Username"].Value.ToString();
                
            }
        }

        private bool IsDuplicateID(string id)
        {
            bool isDuplicate = false;

            try
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM member WHERE ID = @ID", conn);
                cmd.Parameters.AddWithValue("@ID", id);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    isDuplicate = true;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }

            return isDuplicate;
        }


        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void UCMemberAcc_Load(object sender, EventArgs e)
        {

        }

        private void IDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTex_TextChanged(object sender, EventArgs e)
        {

        }

        private void PicBox_Click(object sender, EventArgs e)
        {

        }

        private void addresstextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

