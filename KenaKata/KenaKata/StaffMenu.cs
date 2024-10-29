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
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.ButtonNo("2");
            sell.ShowDialog();
            this.Hide();
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            ProductAdd productAdd = new ProductAdd();
            productAdd.ButtonNo("2");
            productAdd.ShowDialog();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.ShowDialog();
            this.Hide();
        }

        private void StaffMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
