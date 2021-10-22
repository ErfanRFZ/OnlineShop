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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            #region Transparent

            onlineshopLabel.Parent = gradientPanel1;
            onlineshopLabel.BackColor = Color.Transparent;
            versioLabel.Parent = gradientPanel1;
            versioLabel.BackColor = Color.Transparent;
            loginLabel.Parent = gradientPanel1;
            loginLabel.BackColor = Color.Transparent;
            usernameLabel.Parent = gradientPanel1;
            usernameLabel.BackColor = Color.Transparent;
            passwordLabel.Parent = gradientPanel1;
            passwordLabel.BackColor = Color.Transparent;
            shopIcon.Parent = gradientPanel1;
            shopIcon.BackColor = Color.Transparent;
            clearLabel.Parent = gradientPanel1;
            clearLabel.BackColor = Color.Transparent;
            usernameTextBox.Parent = gradientPanel1;
            usernameTextBox.BackColor = Color.Transparent;
            passwordTextBox.BackColor = Color.Transparent;

            #endregion
        }

        private void shopIcon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ErfanRFZ/OnlineShop");
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = null;
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = null;
            
        }

        private void loginGradientButton_Click(object sender, EventArgs e)
        {
            ProductForm log = new ProductForm();
            this.Hide();
            log.Show();
        }
    }
}
