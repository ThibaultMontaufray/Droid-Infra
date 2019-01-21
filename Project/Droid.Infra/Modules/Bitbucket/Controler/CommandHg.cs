using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra
{
    public static class CommandHg
    {
        #region Attributes
        #endregion

        #region Properties
        public static string HgVersion
        {
            get
            {
                try
                {
                    string s = ExecuteCommand("hg version");
                    return s.Split(')')[0].Split('(')[1];
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }
        #endregion

        #region Constructor
        #endregion

        #region Methods public
        public static string Pull(string path)
        {
            //var v0 = ExecuteCommand("hg path", path);
            //var v1 = ExecuteCommand(string.Format("cd {0} & hg path", path));
            //var v2 = ExecuteCommand(string.Format("hg update", path));
            //var v3 = ExecuteCommand(string.Format("hg push", path));
            //var v4 = ExecuteCommand(string.Format("hg branch", path));
            //var v5 = ExecuteCommand(string.Format("hg branches", path));
            //return ExecuteCommand(string.Format("hg update", path));
            return string.Empty;
        }
        #endregion

        #region Methods private
        private static string ExecuteCommand(string cmd, string path = "")
        {
            string result = string.Empty;
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"C:\Windows\System32\cmd.exe";
            if (!string.IsNullOrEmpty(path)) { psi.WorkingDirectory = path; }
            psi.UseShellExecute = false;
            //psi.Verb = "runas";
            //psi.Arguments = "/c " + cmd;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.CreateNoWindow = true;
            psi.RedirectStandardInput = true;
            psi.UseShellExecute = false;


            using (Process process = new Process())
            {
                process.StartInfo = psi;
                process.OutputDataReceived += process_OutputDataReceived;
                process.ErrorDataReceived += process_ErrorDataReceived;
                process.Start();

                //process.WaitForExit(300000); // max 5 min to execute
                process.StandardInput.WriteLine("cd ..");
                process.StandardInput.WriteLine("dir");
                process.StandardInput.WriteLine("cd Do*");
                process.StandardInput.WriteLine("dir");
                using (StreamReader reader = process.StandardOutput)
                {
                    result += reader.ReadToEnd();
                }
            }
            return result;
        }
        #endregion

        #region Event
        private static void process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {

        }
        private static void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {

        }
        #endregion
    }
}
