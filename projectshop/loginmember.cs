using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace projectshop
{
    public partial class loginmember : Form
    {
        public static string LoggedInUserID { get; private set; } // เพิ่มบรรทัดนี้เพื่อเก็บรหัสผู้ใช้

        public loginmember()
        {
            InitializeComponent();
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox3.Text;
            string password = guna2TextBox4.Text;
            string query = "SELECT * FROM member WHERE Username = @username AND Password = @password";

            MySqlConnection conn = databaseConnection();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                LoggedInUserID = reader["ID"].ToString(); // เก็บรหัสผู้ใช้
                string userName = reader["Name"].ToString();
                MessageBox.Show("เข้าสู่ระบบสำเร็จ!");

                Menumember MenumemberForm = new Menumember(LoggedInUserID, userName);
                MenumemberForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง");
            }

            conn.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            registermember regismemberForm = new registermember();
            regismemberForm.Show();
            this.Hide();
        }

       
        private void guna2Button1_Click(object sender, EventArgs e)
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
                guna2TextBox4.UseSystemPasswordChar = false;
                guna2TextBox4.PasswordChar = '\0'; // เปลี่ยนเป็น null char เพื่อให้แสดงรหัสผ่าน
            }
            else
            {
                // ซ่อนรหัสผ่าน
                guna2TextBox4.UseSystemPasswordChar = true;
                guna2TextBox4.PasswordChar = '●';
            }
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginmember_Load(object sender, EventArgs e)
        {

        }
    }
}