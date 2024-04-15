namespace PenduEnMieux
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static public Form1 form1;
        static public GameEngine gameEngine;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            form1 = new Form1();
            gameEngine = new GameEngine();
            Application.Run(new Form1());
        }
    }
}