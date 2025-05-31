using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectshop
{
    public partial class manageorder : UserControl
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            return new MySqlConnection(connectionString);
        }

        public manageorder()
        {
            InitializeComponent();
        }
        private void MemberAcc_Load(object sender, EventArgs e)
        {
            // Load the categoryComboBox with statuses
            categoryComboBox.Items.Add("คำสั่งซื้้อทั้งหมด");
            categoryComboBox.Items.Add("ยืนยันการชำระเงิน");
            categoryComboBox.Items.Add("รอยืนยันคำสั่งซื้อ");
            categoryComboBox.Items.Add("ยกเลิกคำสั่งซื้อ");
            categoryComboBox.SelectedIndex = 0; // Default to "All Orders"
            LoadOrders(); // Load all orders initially
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            idorder.Text = "";
            iduser.Text = "";
            nameuser.Text = "";
            date.Text = "";
            time.Text = "";
            total.Text = "";
            status.Text = "";

            string selectedStatus = categoryComboBox.SelectedItem.ToString();
            string query = "SELECT DISTINCT orderid, user_id, user_name, date, time, sum_total, slip, Status FROM ordercustomer";

            if (selectedStatus == "ยืนยันการชำระเงิน")
            {
                query += " WHERE Status = 'ยืนยันการชำระเงิน'";
            }
            else if (selectedStatus == "รอยืนยันคำสั่งซื้อ")
            {
                query += " WHERE Status = 'รอยืนยันคำสั่งซื้อ'";
            }
            else if (selectedStatus == "ยกเลิกคำสั่งซื้อ")
            {
                query += " WHERE Status = 'ยกเลิกคำสั่งซื้อ'";
            }
            else if (selectedStatus == "คำสั่งซื้้อทั้งหมด")
            {
                query += " WHERE Status != 'ยกเลิกคำสั่งซื้อ'";
            }

            query += " GROUP BY orderid";

            using (MySqlConnection conn = databaseConnection())
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    row["sum_total"] = String.Format("{0:N0}", Convert.ToDecimal(row["sum_total"]));
                }

                orderDataGridView2.DataSource = dt;
            }
        }
        private void orderDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = orderDataGridView2.Rows[e.RowIndex];

                idorder.Text = row.Cells["orderid"].Value.ToString();
                iduser.Text = row.Cells["user_id"].Value.ToString();
                nameuser.Text = row.Cells["user_name"].Value.ToString();
                date.Text = row.Cells["date"].Value.ToString();
                time.Text = row.Cells["time"].Value.ToString();
                total.Text = String.Format("{0:N0} ฿", Convert.ToDecimal(row.Cells["sum_total"].Value));
                status.Text = row.Cells["Status"].Value.ToString();

                byte[] imageData = (byte[])row.Cells["slip"].Value;
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image originalImage = Image.FromStream(ms);
                        Image resizedImage = ResizeImage(originalImage, 402, 543);
                        PicBox.Image = resizedImage;
                    }
                }
                else
                {
                    PicBox.Image = null;
                }
            }
        }

        private Image ResizeImage(Image imgToResize, int width, int height)
        {
            // สร้าง Bitmap ขนาด 340x368
            Bitmap b = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage((Image)b))
            {
                // ตั้งค่าโหมดการ Interpolation แบบ Bicubic เพื่อให้ภาพดูมีคุณภาพ
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                // วาดภาพในขนาดใหม่
                g.DrawImage(imgToResize, 0, 0, width, height);
            }

            return (Image)b;
        }

        private void payment_Click(object sender, EventArgs e)
        {
            // แสดงหน้าต่างยืนยันการชำระเงิน
            DialogResult result = MessageBox.Show("คุณต้องการยืนยันการชำระเงินหรือไม่?", "ยืนยันการชำระเงิน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // สร้างคำสั่ง SQL สำหรับอัปเดตสถานะคำสั่งซื้อ
                string orderId = idorder.Text; // หรือใช้ค่าที่เก็บไว้ในตัวแปร
                string updateQuery = "UPDATE ordercustomer SET Status = 'ยืนยันการชำระเงิน' WHERE orderid = @orderId";

                using (MySqlConnection conn = databaseConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    conn.Open();
                    cmd.ExecuteNonQuery(); // ประมวลผลคำสั่ง SQL
                    conn.Close();
                }

                MessageBox.Show("การชำระเงินถูกยืนยันเรียบร้อยแล้ว!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOrders(); // โหลดรายการคำสั่งซื้อใหม่
            }
        }


        private void delorder_Click(object sender, EventArgs e)
        {
            // แสดงหน้าต่างยกเลิกคำสั่งซื้อ
            DialogResult result = MessageBox.Show("คุณต้องการยกเลิกคำสั่งซื้อนี้หรือไม่?", "ยกเลิกคำสั่งซื้อ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // สร้างคำสั่ง SQL สำหรับอัปเดตสถานะคำสั่งซื้อ
                string orderId = idorder.Text; // หรือใช้ค่าที่เก็บไว้ในตัวแปร
                string updateQuery = "UPDATE ordercustomer SET Status = 'ยกเลิกคำสั่งซื้อ' WHERE orderid = @orderId";

                using (MySqlConnection conn = databaseConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    conn.Open();
                    cmd.ExecuteNonQuery(); // ประมวลผลคำสั่ง SQL
                    conn.Close();
                }

                MessageBox.Show("คำสั่งซื้อถูกยกเลิกเรียบร้อยแล้ว!", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadOrders(); // โหลดรายการคำสั่งซื้อใหม่
            }
        }


        private void ป_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idorder_TextChanged(object sender, EventArgs e)
        {

        }

        private void iduser_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_TextChanged(object sender, EventArgs e)
        {

        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(total.Text.Replace("฿", "").Replace(",", "").Trim(), out decimal parsedValue))
            {
                total.Text = String.Format("{0:N0} ฿", parsedValue);
            }
        }


        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void PicBox_Click(object sender, EventArgs e)
        {

        }
    }
}
