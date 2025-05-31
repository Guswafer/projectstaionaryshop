using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectshop
{
    public partial class summary : UserControl
    {
        public summary()
        {
            // เติมตัวเลือกใน ChooseComboBox
            
            InitializeComponent();
            LoadOrderSummary();
            FillDateComboBox();
            FillMonthComboBox();
            FillYearComboBox();
            summarysell.CellFormatting += summarysell_CellFormatting;
            ChooseComboBox.Items.Add("รายวัน");
            ChooseComboBox.Items.Add("รายเดือน");
            ChooseComboBox.Items.Add("รายปี");
            // ตั้งค่าเป็นวันที่ปัจจุบัน
            SetCurrentDate();
        }
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=localhost;user=Guswafer;password=1234;database=shop;";
            return new MySqlConnection(connectionString);
        }

        private void LoadOrderSummary()
        {
            MySqlConnection conn = databaseConnection();

            try
            {
                conn.Open();
                string query = @"
            SELECT 
                CAST(orderid AS UNSIGNED) AS 'หมายเลขออเดอร์', 
                GROUP_CONCAT(CONCAT(product_name, ' x', quantity) SEPARATOR ', ') AS 'สินค้าและจำนวน', 
                SUM(total_price) AS 'ราคาทั้งหมด',  
                SUM(total_cost) AS 'ต้นทุนทั้งหมด',  
                SUM(discounttotal) AS 'ส่วนลด',
                SUM(sum_price) AS 'ราคาลดแล้ว',              
                SUM(vat7) AS 'Vat 7%',
                SUM(sum_total) AS 'ราคารวม', 
                date AS 'วันที่', 
                time AS 'เวลา', 
                status AS 'สถานะ'
            FROM ordercustomer 
            WHERE status = 'ยืนยันการชำระเงิน'
            GROUP BY orderid, date, time, status
            ORDER BY CAST(orderid AS UNSIGNED)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", loginmember.LoggedInUserID);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the DataTable to the DataGridView
                summarysell.DataSource = dt;

                // Adjust the column width for "สินค้าและจำนวน"
                summarysell.Columns["สินค้าและจำนวน"].Width = 350;
                summarysell.Columns["สถานะ"].Width = 100;
                summarysell.Columns["ราคาทั้งหมด"].Width = 70;
                summarysell.Columns["ต้นทุนทั้งหมด"].Width = 70;
                summarysell.Columns["ราคาลดแล้ว"].Width = 70;
                summarysell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                summarysell.Columns["สถานะ"].Visible = false;
                // Make sure the wider column doesn't shrink
                summarysell.Columns["สินค้าและจำนวน"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

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
        private void summarysell_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // ตรวจสอบคอลัมน์ที่ต้องการจัดรูปแบบคือ "ราคารวม", "ต้นทุนทั้งหมด", "Vat 7%", หรือ "ส่วนลด"
            if (summarysell.Columns[e.ColumnIndex].Name == "ราคารวม" ||
                summarysell.Columns[e.ColumnIndex].Name == "ต้นทุนทั้งหมด" ||
                summarysell.Columns[e.ColumnIndex].Name == "Vat 7%" ||
                summarysell.Columns[e.ColumnIndex].Name == "ส่วนลด" ||
                summarysell.Columns[e.ColumnIndex].Name == "กำไร")
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



        // ฟังก์ชันสำหรับเติมข้อมูลวัน
        private void FillDateComboBox()
        {
            DateComboBox.Items.Clear();
            for (int day = 1; day <= 31; day++)
            {
                DateComboBox.Items.Add(day.ToString("00"));  // เติมวันในรูปแบบ 01, 02, ..., 31
            }
        }

        // ฟังก์ชันสำหรับเติมข้อมูลเดือน
        private void FillMonthComboBox()
        {
            MonthComboBox.Items.Clear();
            for (int month = 1; month <= 12; month++)
            {
                MonthComboBox.Items.Add(month.ToString("00"));  // เติมเดือนในรูปแบบ 01, 02, ..., 12
            }
        }

        // ฟังก์ชันสำหรับเติมข้อมูลปี
        private void FillYearComboBox()
        {
            yearComboBox.Items.Clear();
            int currentYearBE = DateTime.Now.Year + 543;  // Convert to Buddhist Era
            for (int year = currentYearBE - 10; year <= currentYearBE + 10; year++)  // ให้เลือกปีในช่วง 10 ปีที่ผ่านมาและอนาคต
            {
                yearComboBox.Items.Add(year.ToString());
            }

            // ตั้งค่าเป็นปีปัจจุบันใน B.E.
            yearComboBox.SelectedItem = currentYearBE.ToString();
        }


        // ฟังก์ชันสำหรับตั้งค่าเป็นวันที่ปัจจุบัน
        private void SetCurrentDate()
        {
            DateTime currentDate = DateTime.Now;

            // ตั้งค่าเป็นวันปัจจุบันใน DateComboBox
            DateComboBox.SelectedItem = currentDate.Day.ToString("00");

            // ตั้งค่าเป็นเดือนปัจจุบันใน MonthComboBox
            MonthComboBox.SelectedItem = currentDate.Month.ToString("00");

            // ตั้งค่าเป็นปีปัจจุบันใน YearComboBox
            yearComboBox.SelectedItem = currentDate.Year.ToString();
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadTopSellingProducts(string selectedOption, string selectedDate, string selectedMonth, string selectedYear)
        {
            MySqlConnection conn = databaseConnection();

            try
            {
                conn.Open();
                string query = string.Empty;

                // SQL Query based on selection (daily, monthly, yearly)
                if (selectedOption == "รายวัน")
                {
                    query = @"
SELECT 
    product_name, 
    SUM(quantity) AS total_quantity
FROM ordercustomer 
WHERE status = 'ยืนยันการชำระเงิน'
AND STR_TO_DATE(date, '%d/%m/%Y') = STR_TO_DATE(CONCAT(@selectedDay, '/', @selectedMonth, '/', @selectedYear), '%d/%m/%Y')
GROUP BY product_name
ORDER BY total_quantity DESC
LIMIT 3";
                }
                else if (selectedOption == "รายเดือน")
                {
                    query = @"
SELECT 
    product_name, 
    SUM(quantity) AS total_quantity
FROM ordercustomer 
WHERE status = 'ยืนยันการชำระเงิน'
AND MONTH(STR_TO_DATE(date, '%d/%m/%Y')) = @selectedMonth
AND YEAR(STR_TO_DATE(date, '%d/%m/%Y')) = @selectedYear
GROUP BY product_name
ORDER BY total_quantity DESC
LIMIT 3";
                }
                else if (selectedOption == "รายปี")
                {
                    query = @"
SELECT 
    product_name, 
    SUM(quantity) AS total_quantity
FROM ordercustomer 
WHERE status = 'ยืนยันการชำระเงิน'
AND YEAR(STR_TO_DATE(date, '%d/%m/%Y')) = @selectedYear
GROUP BY product_name
ORDER BY total_quantity DESC
LIMIT 3";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@selectedDay", selectedDate);
                cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth);
                cmd.Parameters.AddWithValue("@selectedYear", selectedYear);

                // Execute query and load results into a DataTable
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Top3item.Multiline = true; // ตั้งค่า TextBox ให้สามารถแสดงข้อความหลายบรรทัด
                    string topItems = "Top 3 ขายดี:" + Environment.NewLine + Environment.NewLine; // สตริงเริ่มต้น พร้อมเว้นบรรทัดหลังจากหัวข้อ
                    int index = 1; // เริ่มต้นตัวเลขสำหรับการนับ
                    foreach (DataRow row in dt.Rows)
                    {
                        topItems += $"{index}. {row["product_name"]}: {row["total_quantity"]} ชิ้น" + Environment.NewLine; // เพิ่ม Environment.NewLine เพื่อเว้นบรรทัดหลังแต่ละรายการ
                        index++; // เพิ่มหมายเลข
                    }
                    Top3item.Text = topItems; // ตั้งค่าข้อความใน TextBox
                }
                else
                {
                    Top3item.Text = "ไม่มีข้อมูลสินค้า"; // แสดงข้อความหากไม่มีข้อมูล
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading top selling products: " + ex.Message);
            }
            finally
            {
                conn.Close(); // ปิดการเชื่อมต่อ
            }
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            if (ChooseComboBox.SelectedItem == null ||
                DateComboBox.SelectedItem == null ||
                MonthComboBox.SelectedItem == null ||
                yearComboBox.SelectedItem == null)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลทั้งหมด");
                return;
            }

            string selectedOption = ChooseComboBox.SelectedItem.ToString();
            string selectedDate = DateComboBox.SelectedItem.ToString();
            string selectedMonth = MonthComboBox.SelectedItem.ToString();
            string selectedYear = yearComboBox.SelectedItem.ToString();

            MySqlConnection conn = databaseConnection();

            try
            {
                conn.Open();
                string query = string.Empty;
                MySqlCommand cmd = new MySqlCommand();

                // สร้าง Query ตามประเภทที่เลือก (รายวัน, รายเดือน, รายปี) และรวมสินค้าในแต่ละหมายเลขออเดอร์
                if (selectedOption == "รายวัน")
                {
                    query = @"
                SELECT 
                    orderid AS 'หมายเลขออเดอร์', 
                    GROUP_CONCAT(CONCAT(product_name, ' x', quantity) SEPARATOR ', ') AS 'สินค้าและจำนวน',
                    SUM(sum_total) AS 'ราคารวม',
                    SUM(total_cost) AS 'ต้นทุน',
                    SUM(vat7) AS 'vat7',
                    SUM(discounttotal) AS 'ส่วนลด',
                    SUM(sum_total - total_cost) AS 'กำไร',
                    date AS 'วันที่'
                FROM ordercustomer 
                WHERE status = 'ยืนยันการชำระเงิน'
                AND STR_TO_DATE(date, '%d/%m/%Y') = STR_TO_DATE(CONCAT(@selectedDay, '/', @selectedMonth, '/', @selectedYear), '%d/%m/%Y')
                GROUP BY orderid
                ORDER BY CAST(orderid AS UNSIGNED)";

                    cmd.Parameters.AddWithValue("@selectedDay", selectedDate);
                    cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth);
                    cmd.Parameters.AddWithValue("@selectedYear", selectedYear);
                }
                else if (selectedOption == "รายเดือน")
                {
                    query = @"
                SELECT 
                    orderid AS 'หมายเลขออเดอร์', 
                    GROUP_CONCAT(CONCAT(product_name, ' x', quantity) SEPARATOR ', ') AS 'สินค้าและจำนวน',
                    SUM(sum_total) AS 'ราคารวม',
                    SUM(total_cost) AS 'ต้นทุน',
                    SUM(vat7) AS 'vat7',
                    SUM(discounttotal) AS 'ส่วนลด',
                    SUM(sum_total - total_cost) AS 'กำไร',
                    date AS 'วันที่'
                FROM ordercustomer 
                WHERE status = 'ยืนยันการชำระเงิน'
                AND MONTH(STR_TO_DATE(date, '%d/%m/%Y')) = @selectedMonth
                AND YEAR(STR_TO_DATE(date, '%d/%m/%Y')) = @selectedYear
                GROUP BY orderid
                ORDER BY CAST(orderid AS UNSIGNED)";

                    cmd.Parameters.AddWithValue("@selectedMonth", selectedMonth);
                    cmd.Parameters.AddWithValue("@selectedYear", selectedYear);
                }
                else if (selectedOption == "รายปี")
                {
                    query = @"
                SELECT 
                    orderid AS 'หมายเลขออเดอร์', 
                    GROUP_CONCAT(CONCAT(product_name, ' x', quantity) SEPARATOR ', ') AS 'สินค้าและจำนวน',
                    SUM(sum_total) AS 'ราคารวม',
                    SUM(total_cost) AS 'ต้นทุน',
                    SUM(vat7) AS 'vat7',
                    SUM(discounttotal) AS 'ส่วนลด',
                    SUM(sum_total - total_cost) AS 'กำไร',
                    date AS 'วันที่'
                FROM ordercustomer 
                WHERE status = 'ยืนยันการชำระเงิน'
                AND YEAR(STR_TO_DATE(date, '%d/%m/%Y')) = @selectedYear
                GROUP BY orderid
                ORDER BY CAST(orderid AS UNSIGNED)";

                    cmd.Parameters.AddWithValue("@selectedYear", selectedYear);
                }

                cmd.Connection = conn;
                cmd.CommandText = query;

                // ดึงข้อมูลและใส่ใน DataGridView
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // ปรับการแสดงข้อมูลใน DataGridView
                summarysell.DataSource = dt;
                LoadTopSellingProducts(selectedOption, selectedDate, selectedMonth, selectedYear);
                // คำนวณผลรวมและแสดงใน TextBox ตามปกติ
                decimal totalSum = 0, totalCost = 0, totalVat = 0, totalDiscount = 0, totalProfit = 0;
                int totalQuantity = 0;

                foreach (DataRow row in dt.Rows)
                {
                    totalSum += Convert.ToDecimal(row["ราคารวม"]);
                    totalCost += Convert.ToDecimal(row["ต้นทุน"]);
                    totalVat += Convert.ToDecimal(row["vat7"]);
                    totalDiscount += Convert.ToDecimal(row["ส่วนลด"]);
                    totalProfit += Convert.ToDecimal(row["กำไร"]);

                    // Extract quantity from the product_and_quantity column
                    string productAndQuantity = row["สินค้าและจำนวน"].ToString();
                    string[] parts = productAndQuantity.Split('x');
                    if (parts.Length == 2 && int.TryParse(parts[1].Trim(), out int quantity))
                    {
                        totalQuantity += quantity; // Sum the quantities
                    }
                }
                totalsumbox.Text = "ราคารวม: " + totalSum.ToString("#,##0.00") + "฿";
                costbox.Text = "ต้นทุน: " + totalCost.ToString("#,##0.00") + "฿";
                vat7box.Text = "vat7: " + totalVat.ToString("#,##0.00") + "฿";
                discountbox.Text = "ส่วนลด: " + totalDiscount.ToString("#,##0.00") + "฿";
                profitbox.Text = "กำไร: " + totalProfit.ToString("#,##0.00") + "฿";
                //quantitybox.Text = "จำนวนสินค้า: " + 135;
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


        private void ป_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalsumbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void costbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vat7box_TextChanged(object sender, EventArgs e)
        {

        }

        private void profitbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void summarysell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChooseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totalquantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantitybox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Top3item_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
