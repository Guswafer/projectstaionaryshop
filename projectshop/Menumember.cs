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
    public partial class Menumember : Form
    {
        private string userId;
        private string userName;

        public Menumember(string userId, string userName)
        {
            InitializeComponent();
            this.userId = userId;
            this.userName = userName;
        }

        private void adduserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Historycustomer uc = new Historycustomer();
            adduserControl(uc);
        }

        private void Homebut_Click_1(object sender, EventArgs e)
        {
            UCproduct uc = new UCproduct();
            adduserControl(uc);
        }

        private void PointBut_Click(object sender, EventArgs e)
        {

        }

        private void CartBut_Click(object sender, EventArgs e)
        {
            cart uc = new cart();
            adduserControl(uc);
        }

        private void ProfileBut_Click(object sender, EventArgs e)
        {
            userprofile uc = new userprofile(userId);
            adduserControl(uc);
        }

        private void LogoutBut_Click(object sender, EventArgs e)
        {
            loginmember loginmemberForm = new loginmember();
            loginmemberForm.Show();
            this.Hide();
        }

        private void Menumember_Load(object sender, EventArgs e)
        {
            // แสดงข้อมูลผู้ใช้
            guna2TextBoxid.Text = "ID:" + userId;
            guna2TextBoxUserName.Text = userName;
        }

        private void guna2TextBoxid_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}