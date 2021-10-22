using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            //TODO set username Label to current username
            DashboardPanel.Show();
            productsPanel.Hide();

            product.Parent = productsPanel;
            dashButton.Parent = DashboardPanel;
            proButton.Parent = productsPanel;
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            DashboardPanel.Show();
            productsPanel.Hide();
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            productsPanel.Show();
            DashboardPanel.Hide();
            product.Show();
        }
    }
}
