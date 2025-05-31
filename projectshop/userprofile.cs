using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectshop
{
    public partial class userprofile : UserControl
    {
        private string userID;

        public userprofile(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            LoadUserProfile();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void LoadUserProfile()
        {
            MySqlConnection conn = databaseConnection();
            string query = "SELECT * FROM member WHERE ID = @userID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userID", userID);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IDText.Text = reader["ID"].ToString();
                    nametext.Text = reader["Name"].ToString();
                    EmailText.Text = reader["Email"].ToString();
                    TelText.Text = reader["Tel"].ToString();
                    addresstextBox1.Text = reader["Address"].ToString();
                    UserText.Text = reader["Username"].ToString();
                    PasswordText.Text = reader["Password"].ToString();
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
        
        private bool IsDuplicateEmail1(string Email)
        {
            string query = "SELECT COUNT(*) FROM member WHERE Email = @Email AND ID != @userID";
            MySqlConnection conn = databaseConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@userID", userID);

            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return count > 0;
        }
        private bool IsDuplicateUsername(string Username)
        {
            string query = "SELECT COUNT(*) FROM member WHERE Username = @Username AND ID != @userID";
            MySqlConnection conn = databaseConnection();
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@userID", userID);

            conn.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            return count > 0;
        }

        private void editbut_Click(object sender, EventArgs e)
        {
            // Check if email is duplicated
            if (IsDuplicateEmail1(EmailText.Text.Trim()))
            {
                MessageBox.Show("อีเมลซ้ำ กรุณาใช้อีเมลอื่น");
                return;
            }

            // Check if username is duplicated
            if (IsDuplicateUsername(UserText.Text.Trim()))
            {
                MessageBox.Show("ชื่อผู้ใช้ซ้ำ กรุณาเปลี่ยนชื่อผู้ใช้");
                return;
            }

            // Check if all fields are filled
            if (nametext.Text.Trim() == "" || EmailText.Text.Trim() == "" || TelText.Text.Trim() == "" || addresstextBox1.Text.Trim() == "" || UserText.Text.Trim() == "" || PasswordText.Text.Trim() == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง");
                return;
            }

            // Check if Tel is numeric and has 10 digits
            if (!IsNumeric(TelText.Text.Trim()) || TelText.Text.Trim().Length != 10)
            {
                MessageBox.Show("กรุณาป้อนเบอร์โทรศัพท์ให้ถูกต้อง (10 หลักเป็นตัวเลขเท่านั้น)");
                return;
            }

            // Check if email is valid
            if (!IsValidEmail(EmailText.Text.Trim()))
            {
                MessageBox.Show("กรุณาป้อนอีเมลให้ถูกต้อง");
                return;
            }

            // If all checks pass, proceed with updating the user profile
            MySqlConnection conn = databaseConnection();
            string query = "UPDATE member SET Name = @name, Email = @Email, Tel = @Tel, Address = @Address, Username = @Username, Password = @Password WHERE ID = @userID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", nametext.Text);
            cmd.Parameters.AddWithValue("@Email", EmailText.Text);
            cmd.Parameters.AddWithValue("@Tel", TelText.Text);
            cmd.Parameters.AddWithValue("@Address", addresstextBox1.Text);
            cmd.Parameters.AddWithValue("@Username", UserText.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordText.Text);
            cmd.Parameters.AddWithValue("@userID", userID);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("แก้ไขโปรไฟล์สำเร็จ!!.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดให้การแก้ไขข้อมูล: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void guna2CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                // แสดงรหัสผ่าน
                PasswordText.UseSystemPasswordChar = false;
                PasswordText.PasswordChar = '\0'; // เปลี่ยนเป็น null char เพื่อให้แสดงรหัสผ่าน
            }
            else
            {
                // ซ่อนรหัสผ่าน
                PasswordText.UseSystemPasswordChar = true;
                PasswordText.PasswordChar = '●';
            }
        }
        private bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }

        private bool IsNumeric(string str)
        {
            double result;
            return double.TryParse(str, out result);
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

        private void addresstextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backbut_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
