namespace KenaKata
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           
            ProductAdd form1 = new ProductAdd();
            form1.ShowDialog();
            //Application.Run(Form1());
        }
    }
}