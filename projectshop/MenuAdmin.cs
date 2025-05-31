
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
namespace projectshop
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void adduserControl(UserControl userControl) 
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void MemberBut_Click(object sender, EventArgs e)
        {
            UCMemberAcc uc = new UCMemberAcc();
            adduserControl(uc);
        }

        private void CartBut_Click(object sender, EventArgs e)
        {
            UCStock uc = new UCStock();
            adduserControl(uc);
        }

        private void ReportBut_Click(object sender, EventArgs e)
        {
            summary uc = new summary();
            adduserControl(uc);
        }

        private void LogoutBut_Click(object sender, EventArgs e)
        {
            login loginForm = new login();

            loginForm.Show();

            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminBut1_Click(object sender, EventArgs e)
        {
            manageorder uc = new manageorder();
            adduserControl(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
