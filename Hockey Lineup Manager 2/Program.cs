namespace Hockey_Lineup_Manager_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Uncomment and get rid of run argument to enable ability to close main menu without quiting the app.
            new MainMenu().Show();

            Application.Run();
        }
    }
}