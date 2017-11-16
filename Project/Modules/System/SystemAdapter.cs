using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.IO;
using System.Security.AccessControl;

namespace Droid_Infra
{
    public static class SystemAdapter
    {
        public static bool GotAdminRight
        {
            get
            {
                bool isElevated;
                using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
                {
                    WindowsPrincipal principal = new WindowsPrincipal(identity);
                    isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
                }
                return isElevated;
            }
        }
        public static string[] Disks
        {
            get { 
                String[] drives = Environment.GetLogicalDrives();
                Console.WriteLine("GetLogicalDrives: {0}", String.Join(", ", drives));
                return drives;
            }
        }
        public static string[] GetFiles(DirectoryInfo di, string[] extention)
        {
            List<string> ret = new List<string>();
            if (HasWritePermissionOnDir(di.FullName))
            {
                try
                {
                    foreach (var file in di.GetFiles().Where(f => extention.Contains(f.Extension.ToLower())).ToList())
                    {
                        ret.Add(file.FullName);
                    }
                }
                catch { }
            }

            return ret.ToArray();
        }
        public static bool HasWritePermissionOnDir(string path)
        {
            var writeAllow = false;
            var writeDeny = false;
            try
            {
                var accessControlList = Directory.GetAccessControl(path);
                if (accessControlList == null) return false;
                var accessRules = accessControlList.GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier));
                if (accessRules == null) return false;

                foreach (FileSystemAccessRule rule in accessRules)
                {
                    if ((FileSystemRights.Write & rule.FileSystemRights) != FileSystemRights.Write) continue;
                    if (rule.AccessControlType == AccessControlType.Allow) writeAllow = true;
                    else if (rule.AccessControlType == AccessControlType.Deny) writeDeny = true;
                }
            }
            catch { }

            return writeAllow && !writeDeny;
        }
    }
}
