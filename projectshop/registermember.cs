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
    using Guna.UI2.WinForms;
    using MySql.Data.MySqlClient;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
    namespace projectshop
    {
        public partial class registermember : Form
        {
            private MySqlConnection databaseConnection()
            {
                string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
                MySqlConnection conn = new MySqlConnection(connectionString);
                return conn;
            }
            public registermember()
            {
                InitializeComponent();
            }

            private void registermember_Load(object sender, EventArgs e)
            {
                try
                {
                    // เชื่อมต่อกับฐานข้อมูล
                    MySqlConnection conn = databaseConnection();
                    conn.Open();

                    // คำสั่ง SQL เพื่อดึง ID ล่าสุดจากตาราง member
                    MySqlCommand cmd = new MySqlCommand("SELECT MAX(ID) FROM member", conn);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int lastID = Convert.ToInt32(result);
                        // เพิ่ม 1 เข้าไปในค่า ID ล่าสุด
                        int nextID = lastID + 1;

                        // แสดงค่า ID ถัดไปในกล่องข้อความ
                        IDCardText.Text = nextID.ToString();
                    }
                    else
                    {
                        // ถ้าไม่มีข้อมูลในตาราง
                        // กำหนดค่าเริ่มต้นให้ ID เป็น 1
                        IDCardText.Text = "1";
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
                finally
                {
                    // ตั้งค่าให้กล่องข้อความมีค่าเท่านั้นและไม่สามารถแก้ไขได้
                    IDCardText.ReadOnly = true;
                }
            }
         
            private void UsernameText_TextChanged(object sender, EventArgs e)
            {
                string input = UsernameText.Text.Trim();
                if (!IsAlphanumeric(input))
                {
                    MessageBox.Show("ชื่อผู้ใช้สามารถรับเฉพาะภาษาอังกฤษและตัวเลขเท่านั้น");
                    UsernameText.Text = RemoveNonAlphanumeric(input);
                    UsernameText.SelectionStart = UsernameText.Text.Length;
                }
            }
            private void PasswordText_TextChanged(object sender, EventArgs e)
            {
                string input = PasswordText.Text.Trim();
                if (!IsAlphanumeric(input))
                {
                    MessageBox.Show("รหัสผ่านสามารถรับเฉพาะภาษาอังกฤษและตัวเลขเท่านั้น");
                    PasswordText.Text = RemoveNonAlphanumeric(input);
                    PasswordText.SelectionStart = PasswordText.Text.Length;
                }
            }
            private bool IsAlphanumeric(string str)
            {
                foreach (char c in str)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }

            private string RemoveNonAlphanumeric(string str)
            {
                StringBuilder sb = new StringBuilder();
                foreach (char c in str)
                {
                    if (char.IsLetterOrDigit(c))
                    {
                        sb.Append(c);
                    }
                }
                return sb.ToString();
            }
            private void guna2Button1_Click(object sender, EventArgs e)
            {
                loginmember loginmemberForm = new loginmember();

                loginmemberForm.Show();

                this.Hide();
            }


            private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
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
            private void Regisbut_Click(object sender, EventArgs e)
            {
                // เช็คว่าข้อมูลทั้งหมดถูกกรอกครบถ้วนหรือไม่
                if (Nametext.Text.Trim() == "" || EmailText.Text.Trim() == "" || IDCardText.Text.Trim() == "" || TelTex.Text.Trim() == "" || UsernameText.Text.Trim() == "" || PasswordText.Text.Trim() == "" || addresstextBox1.Text.Trim() == "")
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง");
                    return;
                }
                if (IsDuplicatePhoneNumber(TelTex.Text.Trim()))
                {
                    MessageBox.Show("เบอร์โทรศัพท์หมายเลขนี้ถูกใช้ในระบบแล้ว โปรดเปลี่ยนหมายเลข!.");
                    return;
                }
                // เช็คว่า Tel เป็นตัวเลขทั้งหมดหรือไม่ และมีความยาว 10 หลัก
                if (!IsNumeric(TelTex.Text.Trim()) || TelTex.Text.Trim().Length != 10)
                {
                    MessageBox.Show("กรุณาป้อนเบอร์โทรศัพท์ให้ถูกต้อง (10 หลักเป็นตัวเลขเท่านั้น)");
                    return;
                }

                // เช็คว่าอีเมลมีรูปแบบที่ถูกต้องหรือไม่
                if (!IsValidEmail(EmailText.Text.Trim()))
                {
                    MessageBox.Show("กรุณาป้อนอีเมลให้ถูกต้อง");
                    return;
                }

                // เช็คว่ามีชื่อผู้ใช้ซ้ำหรือไม่
                if (IsDuplicateUsername(UsernameText.Text.Trim()))
                {
                    MessageBox.Show("ชื่อ Username ซ้ำ กรุณาเปลี่ยนชื่อ Username");
                    return;
                }
                if (IsDuplicateEmail(EmailText.Text.Trim()))
                {
                    MessageBox.Show("อีเมลซ้ำ กรุณาใช้อีเมลอื่น");
                    return;
                }

                // เมื่อผ่านการตรวจสอบข้อมูลทั้งหมดแล้ว
                // ทำการสมัครสมาชิก
                RegisterMember();
            }


            private bool IsValidEmail(string email)
            {
                return email.Contains("@");
            }


        private void RegisterMember()
        {
            try
            {
                string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
                MySqlConnection conn = new MySqlConnection(connectionString);
                {
                    conn.Open();
                    string query = "INSERT INTO member (Name, ID, Email, Tel, Address, Username, Password) VALUES (@name, @ID, @Email, @Tel, @Address, @Username, @Password)"; // แทรกข้อมูลลงในฐานข้อมูล

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", Nametext.Text.Trim());
                        cmd.Parameters.AddWithValue("@ID", IDCardText.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", EmailText.Text.Trim());
                        cmd.Parameters.AddWithValue("@Tel", TelTex.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", addresstextBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@Username", UsernameText.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", PasswordText.Text.Trim());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("สมัครสมาชิกสำเร็จ!!");

                            // Refresh the form after successful registration
                            this.Hide();
                            registermember newForm = new registermember();
                            newForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("มีข้อผิดพลาดในการสมัครสมาชิก");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
            }
        }



        private bool IsDuplicateUsername(string Username)
            {
                // สร้างคำสั่ง SQL เพื่อตรวจสอบ ID ในฐานข้อมูล
                string query = "SELECT COUNT(*) FROM member WHERE Username = @Username";
                MySqlConnection conn = databaseConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // เพิ่มค่าพารามิเตอร์
                cmd.Parameters.AddWithValue("@Username", Username);

                // ประมวลผลและคืนค่าจำนวนรายการที่พบ
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return count > 0;
            }
            private bool IsNumeric(string str)
            {
                double result;
                return double.TryParse(str, out result);
            }
            private bool IsDuplicatePhoneNumber(string phoneNumber)
            {
                // Create SQL query to check if the phone number already exists in the database
                string query = "SELECT COUNT(*) FROM member WHERE Tel = @PhoneNumber";
                MySqlConnection conn = databaseConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add parameter for the phone number
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                // Execute the query and get the count of matching phone numbers
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                // If count is greater than 0, it means the phone number already exists
                return count > 0;
            }

            private bool IsDuplicateEmail(string Email)
            {
                // สร้างคำสั่ง SQL เพื่อตรวจสอบ ID ในฐานข้อมูล
                string query = "SELECT COUNT(*) FROM member WHERE Email = @Email";
                MySqlConnection conn = databaseConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // เพิ่มค่าพารามิเตอร์
                cmd.Parameters.AddWithValue("@Email", Email);

                // ประมวลผลและคืนค่าจำนวนรายการที่พบ
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();

                return count > 0;
            }
        private void addresstextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDCardText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelTex_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
