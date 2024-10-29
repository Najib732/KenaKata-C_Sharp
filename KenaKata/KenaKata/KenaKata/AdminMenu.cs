using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenaKata
{


    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            ProductAdd product = new ProductAdd();
            product.ButtonNo("1");
            product.ShowDialog();
            this.Close();
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.ButtonNo("1");
            sell.ShowDialog();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Hide();
        }
    }
}
