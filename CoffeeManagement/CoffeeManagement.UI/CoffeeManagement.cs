using CoffeeManagement.UI.UserControls;
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
    public partial class CoffeeManagement : Form
    {
        public CoffeeManagement()
        {
            InitializeComponent();
            panelUserControl.Controls.Clear();
            HomeUserControl homeUserControl = new HomeUserControl();
            homeUserControl.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(homeUserControl);
            labelTitle.Text = "Coffee Management";
        }

        #region WindowState
        private void PictureBoxMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void PictureBoxLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void PictureBoxMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region ButtonSidebar
        private void ButtonHome_Click(object sender, EventArgs e)
        {
            panelUserControl.Controls.Clear();
            SidePanel.Height = buttonHome.Height;
            SidePanel.Top = buttonHome.Top;
            HomeUserControl homeUserControl = new HomeUserControl();
            homeUserControl.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(homeUserControl);
            labelTitle.Text = "Coffee Management";
        }

        private void ButtonFood_Click(object sender, EventArgs e)
        {
            panelUserControl.Controls.Clear();
            SidePanel.Height = buttonFood.Height;
            SidePanel.Top = buttonFood.Top;
            FoodUserControl foodUserControl = new FoodUserControl();
            foodUserControl.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(foodUserControl);
            labelTitle.Text = "Food Management";
        }

        private void ButtonCategory_Click(object sender, EventArgs e)
        {
            panelUserControl.Controls.Clear();
            SidePanel.Height = buttonCategory.Height;
            SidePanel.Top = buttonCategory.Top;
            CategoryUserControl categoryUserControl = new CategoryUserControl();
            categoryUserControl.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(categoryUserControl);
            labelTitle.Text = "Categories Management";
        }

        private void ButtonTables_Click(object sender, EventArgs e)
        {
            panelUserControl.Controls.Clear();
            SidePanel.Height = buttonTables.Height;
            SidePanel.Top = buttonTables.Top;
            TablesUserControl tablesUserControl = new TablesUserControl();
            tablesUserControl.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(tablesUserControl);
            labelTitle.Text = "Tables Management";
        }

        private void ButtonRevenue_Click(object sender, EventArgs e)
        {
            panelUserControl.Controls.Clear();
            SidePanel.Height = buttonRevenue.Height;
            SidePanel.Top = buttonRevenue.Top;
            RevenueUserControl revenueUserControl = new RevenueUserControl();
            revenueUserControl.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(revenueUserControl);
            labelTitle.Text = "Revenue Management";
        }

        private void ButtonAccounts_Click(object sender, EventArgs e)
        {
            panelUserControl.Controls.Clear();
            SidePanel.Height = buttonAccounts.Height;
            SidePanel.Top = buttonAccounts.Top;
            AccountsUserControl accountsUserControl = new AccountsUserControl();
            accountsUserControl.Dock = DockStyle.Fill;
            panelUserControl.Controls.Add(accountsUserControl);
            labelTitle.Text = "Accounts Management";
        }
        #endregion
    }
}
