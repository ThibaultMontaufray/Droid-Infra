using System;
using System.Windows.Forms;

namespace Droid.Infra.UI
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //if (args == null) { LaunchProgram.LaunchDemo(); }
            //else { LaunchProgram.LaunchProgramFile(); }
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
