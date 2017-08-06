using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

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
    }
}
