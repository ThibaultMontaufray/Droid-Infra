namespace Droid.Infra
{
    using System.Diagnostics;
    using System.IO;
    using System.Text.RegularExpressions;

    public class Command
    {
        #region Enum
        public enum STATUS
        {
            UNKNOWN,
            RUNNING,
            POWEROFF,
            ABORTED
        }
        #endregion

        #region Regex
        protected Regex _regexIp = new Regex(".*");
        #endregion

        #region Methods pr-otected
        public static string ExecuteCommand(string cmd)
        {
            string result = string.Empty;
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            psi.UseShellExecute = false;
            psi.Verb = "runas";
            psi.Arguments = "/c " + cmd;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;

            using (Process process = new Process())
            { 
                process.StartInfo = psi;
                process.OutputDataReceived += process_OutputDataReceived;
                process.ErrorDataReceived += process_ErrorDataReceived;
                process.Start();

                process.WaitForExit(300000); // max 5 min to execute

                using (StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                }
            }
            return result;
        }
        protected static void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {

        }
        protected static void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

        }
        #endregion
    }
}
