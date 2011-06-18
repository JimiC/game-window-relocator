using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

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
            /// Ensures that only one instance is ran at once
            if (Process.GetProcessesByName("GameWindowRelocator").Length > 1)
                return;

            bool startMinimized = Environment.GetCommandLineArgs().Contains("-startMinimized");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(startMinimized));
        }
    }
}
