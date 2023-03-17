using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace focus
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            CreateConfigFile();
            System.Security.Principal.WindowsIdentity.GetCurrent().Impersonate();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static bool IsAdministrator()
        {
            try
            {
                WindowsIdentity id = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(id);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void CreateConfigFile()
        {
            string executeFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string user = Environment.UserDomainName + "\\" + Environment.UserName;
            FileSystemRights rights = FileSystemRights.ReadAndExecute | FileSystemRights.Write;
            InheritanceFlags inheritFlags = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
            PropagationFlags propFlags = PropagationFlags.None;
            AccessControlType controlType = AccessControlType.Allow;

            DirectorySecurity security = Directory.GetAccessControl(executeFolder);
            FileSystemAccessRule accessRule = new FileSystemAccessRule(user, rights, inheritFlags, propFlags, controlType);
            security.AddAccessRule(accessRule);
            Directory.SetAccessControl(executeFolder, security);

            string filePath = Path.Combine(executeFolder, "config.ini");
            string[] lines = {
                    "[System]",
                    "RunAsAdministrator=false",
                    "RunAtBootTime=false",
                    "ShowDialogStartup=true",
                    "NotificationSound=true",
                    "[Setting]",
                    "Language=EN",
                    "Flag=VI",
                    "StartPause=start",
                    "[Config]",
                    "Focustime=1",
                    "Breaktime=1",
                    "BreakDefault=0",
                    "Repeat=infinite",
                    "RepeatDefault=1",
                    "[Custom]",
                    "Color=#FF8080",
                    string.Format("Image={0}\\images\\trayicon.png", executeFolder)
                };

            if (!File.Exists(filePath))
            {
                File.WriteAllLines(filePath, lines);
            }
        }
    }
}