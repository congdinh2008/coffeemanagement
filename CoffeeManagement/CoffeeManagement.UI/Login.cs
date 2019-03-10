using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            CoffeeManagement coffeeManagement = new CoffeeManagement();
            this.Hide();
            coffeeManagement.Show();
        }
    }
}
