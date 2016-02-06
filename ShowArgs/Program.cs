using System;
using System.Windows.Forms;

namespace ShowArgs {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Get start arguments
            string[] args = Environment.GetCommandLineArgs();

            //Join args array entries with double new line character
            string message = String.Join("\n\n", args);

            //Display message box
            MessageBox.Show(message, "Start Arguments");
        }
    }
}