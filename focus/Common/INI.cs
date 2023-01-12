using System.Runtime.InteropServices;
using System.Text;

namespace focus.Common
{
    public class INI
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);

        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filepath);

        public static string READ(string szFile, string szSection, string szKey)
        {
            StringBuilder tmp = new StringBuilder(255);
            long i = GetPrivateProfileString(szSection, szKey, "", tmp, 255, szFile);
            return tmp.ToString();
        }

        public static void WRITE(string szFile, string szSection, string szKey, string szData)
        {
            WritePrivateProfileString(szSection, szKey, szData, szFile);
        }
    }
}