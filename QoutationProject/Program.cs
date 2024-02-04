using System.IO;

namespace QoutationProject
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
            if (!Directory.Exists(Environment.CurrentDirectory + "\\Qoutation"))
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\Qoutation");
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}