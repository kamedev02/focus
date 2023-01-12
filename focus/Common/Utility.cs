using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace focus.Common
{
    public class Utility
    {
        public static List<Lang> LstLang;

        public static string GetLanguage(string key, bool IsUpperCase)
        {
            string path = frmMain.pathresult + "languages.json";
            using (StreamReader file = File.OpenText(path))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JArray o2 = (JArray)JToken.ReadFrom(reader);
                LstLang = o2.ToObject<List<Lang>>();
            }

            string pathconfig = frmMain.pathresult + "config.ini";
            string curlang = INI.READ(pathconfig, "Setting", "Language");
            var obj = LstLang.FirstOrDefault(f => f.ID.ToLower() == key.ToLower());
            if (obj == null)
                return key;

            switch (curlang)
            {
                case "VI": return IsUpperCase ? obj.VI.ToUpper() : obj.VI;
                case "EN": return IsUpperCase ? obj.EN.ToUpper() : obj.EN;
                default:
                    return IsUpperCase ? obj.VI.ToUpper() : obj.VI;
            }
        }
    }
}