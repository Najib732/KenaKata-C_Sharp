using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace KenaKata
{
    public partial class Sell : Form
    {
        public string buttonNo;
        public Sell()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sell_Load(object sender, EventArgs e)
        {

        }
        public void ButtonNo(string no)
        {
            buttonNo = no;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (buttonNo == "1")
            {
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.ShowDialog();
                this.Close();

            }
            else if (buttonNo == "2")
            {
                StaffMenu staffMenu = new StaffMenu();
                staffMenu.ShowDialog();
                this.Close();
            }
        }
    }
}
