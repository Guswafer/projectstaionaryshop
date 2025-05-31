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
    public partial class login : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public login()
        {
            InitializeComponent();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox3.Text;
            string password = guna2TextBox5.Text;
            string query = "SELECT * FROM login WHERE Username = @username AND Password = @password";
            // เชื่อมต่อกับฐานข้อมูล
            MySqlConnection conn = databaseConnection();
            conn.Open();

            // สร้างคำสั่ง SQL สำหรับการเลือกข้อมูลของผู้ใช้จากฐานข้อมูล
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            // สร้างอ่านผลลัพธ์
            MySqlDataReader reader = cmd.ExecuteReader();

            // ตรวจสอบว่าพบผู้ใช้หรือไม่
            if (reader.Read())
            {
                // ถ้าพบผู้ใช้ ทำการล็อกอิน
                MessageBox.Show("เข้าสู่ระบบสำเร็จ!");
                MenuAdmin AdminForm = new MenuAdmin();

                AdminForm.Show();

                this.Hide();
            }
            else
            {
                // หากไม่พบผู้ใช้ แสดงข้อความแจ้งเตือน
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
            }

            // ปิดการเชื่อมต่อ
            conn.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            main mainForm = new main();

            mainForm.Show();

            this.Hide();
        }
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked == true)
            {
                // แสดงรหัสผ่าน
                guna2TextBox5.UseSystemPasswordChar = false;
                guna2TextBox5.PasswordChar = '\0'; // เปลี่ยนเป็น null char เพื่อให้แสดงรหัสผ่าน
            }
            else
            {
                // ซ่อนรหัสผ่าน
                guna2TextBox5.UseSystemPasswordChar = true;
                guna2TextBox5.PasswordChar = '●';
            }
        }
        private void login_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
