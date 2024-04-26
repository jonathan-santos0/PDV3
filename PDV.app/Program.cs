namespace PDV.app
{
    internal static class Program

    { 
        public static bool IsLoged = false;
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
            if (IsLoged )
            {
                Application.Run(new Main());
            }
          
        }
    }
}