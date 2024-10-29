using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KenaKata
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new BuyingProduct());
          // Application.Run(new ProductAdd());
            ProductAdd productAdd = new ProductAdd();
            productAdd.Show();
            Application.Run();

        }
    }
}
