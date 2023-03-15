namespace GroupProject_106
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
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
        }
    }
}