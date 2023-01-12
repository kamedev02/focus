using focus.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

            DirectoryInfo dirInfo = new DirectoryInfo(executeFolder);
            DirectorySecurity dirSecurity = dirInfo.GetAccessControl();
            AuthorizationRuleCollection rules = dirSecurity.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));
            bool hasWriteAccess = false;
            foreach (FileSystemAccessRule rule in rules)
            {
                if (rule.AccessControlType == AccessControlType.Allow &&
                    rule.FileSystemRights == FileSystemRights.WriteData)
                {
                    hasWriteAccess = true;
                    break;
                }
            }
            if (!hasWriteAccess)
            {
                FileSystemAccessRule newRule = new FileSystemAccessRule(
                    System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                    FileSystemRights.WriteData,
                    AccessControlType.Allow);
                dirSecurity.AddAccessRule(newRule);
                dirInfo.SetAccessControl(dirSecurity);
            }
            string filePath = Path.Combine(executeFolder, "config.ini");
            string[] lines = { "[System]", "RunAsAdministrator=false", "RunAtBootTime=false", "ShowDialogStartup=true", "NotificationSound=true", "[Setting]", "Language=EN", "Flag=VI", "StartPause=start", "[Config]", "Focustime=1", "Breaktime=1", "BreakDefault=0", "Repeat=infinite", "RepeatDefault=1", "[Custom]", "Color=#FF8080", string.Format("Image={0}\\images\\trayicon.png", executeFolder) };
            
            if (!File.Exists(filePath))
            {
                File.WriteAllLines(filePath, lines);
            }
        }
    }
}