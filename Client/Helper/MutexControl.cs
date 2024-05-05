using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace Client.Helper
{
    public static class MutexControl
    {
        public static Mutex currentApp;

        // Modified CreateMutex method that checks user privilege level
        public static bool CreateMutexWithAdminCheck()
        {
            string mutexId = Settings.MTX;
            if (IsAdmin())
            {
                mutexId += "_Admin";
            }
            else
            {
                mutexId += "_User";
            }

            bool createdNew;
            currentApp = new Mutex(false, mutexId, out createdNew);
            return createdNew;
        }

        // Method to determine if the current user is an administrator
        private static bool IsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void CloseMutex()
        {
            if (currentApp != null)
            {
                currentApp.Close();
                currentApp = null;
            }
        }
    }
}
