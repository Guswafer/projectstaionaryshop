using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectshop
{
    public partial class Historycustomer : UserControl
    {
        public Historycustomer()
        {
            InitializeComponent();
            historybuy.CellFormatting += historybuy_CellFormatting;
            LoadOrderHistory();
        }

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            return new MySqlConnection(connectionString);
        }

        private void LoadOrderHistory()
        {
            MySqlConnection conn = databaseConnection();

            try
            {
                conn.Open();
                string query = @"
                SELECT 
                    CAST(orderid AS UNSIGNED) AS 'หมายเลขออเดอร์', 
                    GROUP_CONCAT(CONCAT(product_name, ' x', quantity) SEPARATOR ', ') AS 'สินค้าและจำนวน', 
                    SUM(sum_price) AS 'ราคาสินค้า', 
                    SUM(discounttotal) AS 'ส่วนลด',
                    SUM(vat7) AS 'Vat 7%',
                    SUM(sum_total) AS 'ราคารวม', 
                    date AS 'วันที่', 
                    time AS 'เวลา', 
                    status AS 'สถานะ'
                FROM ordercustomer 
                WHERE user_id = @userID 
                GROUP BY orderid, date, time, status
                ORDER BY CAST(orderid AS UNSIGNED)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", loginmember.LoggedInUserID);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView
                historybuy.DataSource = dt;

                // Adjust the column width for "สินค้าและจำนวน"
                historybuy.Columns["สินค้าและจำนวน"].Width = 400;  // Set a wider width
                historybuy.Columns["สถานะ"].Width = 100;       // Optionally, set AutoSize mode for other columns
                historybuy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Make sure the wider column doesn't shrink
                historybuy.Columns["สินค้าและจำนวน"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order history: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Historycustomer_Load(object sender, EventArgs e)
        {
            // Load order history when the control loads
            LoadOrderHistory();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Custom paint logic if needed
        }
        private void historybuy_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // ตรวจสอบว่าคอลัมน์ที่ต้องการจัดรูปแบบคือ "ราคาสินค้า", "ส่วนลด", "Vat 7%", หรือ "ราคารวม"
            if (historybuy.Columns[e.ColumnIndex].Name == "ราคาสินค้า" ||
                historybuy.Columns[e.ColumnIndex].Name == "ส่วนลด" ||
                historybuy.Columns[e.ColumnIndex].Name == "Vat 7%" ||
                historybuy.Columns[e.ColumnIndex].Name == "ราคารวม")
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
            private void historybuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
