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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.ShowDialog();
            this.Close();
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            StaffMenu staffMenu = new StaffMenu();
            staffMenu.ShowDialog();
            this.Close();
        }

     
        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
