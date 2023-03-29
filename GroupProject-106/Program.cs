namespace GroupProject_106
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<string> list = new List<string>();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Form2 loadingscreen = new Form2();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(3);
            loadingscreen.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }

            loadingscreen.Close();
            loadingscreen.Dispose();
            Application.Run(new Form1());
            //void k(List<string> t) { }
        }
    }
}