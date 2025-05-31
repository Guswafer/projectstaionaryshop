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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            loginmember loginmemberForm = new loginmember();

            loginmemberForm.Show();

            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            login loginForm = new login();

            loginForm.Show();

            this.Hide();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
