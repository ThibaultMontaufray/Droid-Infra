using System.IO;
using System.Diagnostics;
using Tools.Utilities;

namespace Droid.Infra
{
    public static class ConsoleLauncher
    {
        #region Constructor
        #endregion

        #region Methods public
        public static string ExecuteCommand(string cmd)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.UseShellExecute = false;
            psi.Verb = "runas";
            psi.Arguments = "/c " + cmd;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = psi;
            process.OutputDataReceived += process_OutputDataReceived;
            process.ErrorDataReceived += process_ErrorDataReceived;
            process.Start();

            process.WaitForExit(300000); // max 5 min to execute

            string result = string.Empty;
            using (StreamReader reader = process.StandardOutput)
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
        public static string ExecuteCommand(string[] cmd)
        {
            string commandArg = string.Empty;
            foreach (string cmdArg in cmd)
            {
                if (!string.IsNullOrEmpty(commandArg)) { commandArg += " && "; }
                commandArg += cmdArg;
            }

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.UseShellExecute = false;
            psi.Verb = "runas";
            psi.Arguments = "/c " + commandArg;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;

            Process process = new Process();
            process.StartInfo = psi;
            process.OutputDataReceived += process_OutputDataReceived;
            process.ErrorDataReceived += process_ErrorDataReceived;
            process.Start();

            process.WaitForExit();

            string result = string.Empty;
            using (StreamReader reader = process.StandardOutput)
            {
                result = reader.ReadToEnd();
            }
            return result;
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        private static void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Log.Write("[ ERR 0000 ] Error data received : " + e.Data);
        }
        private static void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Log.Write("[ ERR 0001 ] Out data received : " + e.Data);
        }
        #endregion
    }
}
