using Week1.Data.Database;
using Week1.Presentation;

namespace Week1
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
            SQLConnectionManager.Instance.IsConnectionSuccessful();
            Application.Run(PresentationManager.Instance._animalManager);
        }
    }
}