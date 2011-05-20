using System;
using System.Windows.Forms;
using System.Linq;

namespace GameWindowRelocator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool startMinimized = Environment.GetCommandLineArgs().Contains("-startMinimized");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(startMinimized));
        }
    }
}
