using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Metasploit_GUI
{
    public enum LOGTYPE
    {
        INFO,
        WARNING,
        ERROR,
    }

    class Statics
    {
        /* Preferences and profiles */
        public static Dictionary<string, string> Preferences = new Dictionary<string, string>();
        public static Dictionary<string, Dictionary<string, string>> Profiles = new Dictionary<string, Dictionary<string, string>>();
        public static string ActiveProfile = "Default";
        public static bool editableConsoleOutput = false;
        public static int MaxCompletionSuggestions = 5;
        public static string lhost, lport, rhost, rport;
        public static int HistoryLength = 10;

        /* Installed booleans */
        public static bool pythonwrapper_installed, metasploit_installed, nmap_installed;

        /* Paths */
        public static string pythonwrapper_path, metasploit_path, nmap_path;
        public static string dictionary_path = "..\\..\\Dictionary.txt";

        /* Constants */
        public const string ProfileFile = "Profiles.ini";
        public static readonly bool DebugWindowEnabled = true;
        public const string DefaultScriptName = "Unnamed";

        /* Other publics */
        public static System.Drawing.Color 
            Warning_Color = System.Drawing.Color.DarkOrange, 
            Error_Color = System.Drawing.Color.Red;
        public static string[] DictionaryItems;
        public static DebugWindow dbw = null;


        public static void Print(object stdout, LOGTYPE stdtype = LOGTYPE.INFO, string LineTerminator = "")
        {
            if (LineTerminator == "")
                LineTerminator = System.Environment.NewLine;

            string Prepend = "";
            switch (stdtype)
            {
                case LOGTYPE.INFO:
                    Prepend = "[INFO] ";
                    //log.AppendLine("[INFO]" + stdout.ToString());
                    break;
                case LOGTYPE.WARNING:
                    Prepend = "[WARNING] ";
                    //log.AppendLine("[WARNING]" + stdout.ToString());
                    break;
                case LOGTYPE.ERROR:
                    Prepend = "[ERROR] ";
                    //log.AppendLine("[ERROR]" + stdout.ToString());
                    break;
            }
            DebugWindow.AppendLog(Prepend + stdout.ToString() + LineTerminator);
        }

        public static void SaveProfiles()
        {
            Print("Saving profiles");
            StringBuilder sw = new StringBuilder();

            foreach (KeyValuePair<string, Dictionary<string, string>> Profile in Profiles)
            {
                sw.AppendLine($"[{Profile.Key}]");
                sw.AppendLine($"lhost={Profiles[Profile.Key]["lhost"]}");
                sw.AppendLine($"lport={Profiles[Profile.Key]["lport"]}");
                sw.AppendLine($"rhost={Profiles[Profile.Key]["rhost"]}");
                sw.AppendLine($"rport={Profiles[Profile.Key]["rport"]}");
                sw.AppendLine();
            }

            if (File.Exists(ProfileFile))
            {
                Print($"{ProfileFile} exists, replacing with new file");
                File.Delete(ProfileFile);
            }

            File.WriteAllText(ProfileFile, sw.ToString());

            Print("Profiles saved");
        }

        public static void LoadProfiles()
        {
            Print("Loading profiles");

            if (File.Exists(ProfileFile))
                return;

            Dictionary<string, Dictionary<string, string>> profiles = new Dictionary<string, Dictionary<string, string>>();



        }

        public static void RefreshDictionary()
        {
            if (!File.Exists(dictionary_path))
            {
                Print($"Dictionary at: {dictionary_path} does not exist", LOGTYPE.ERROR);
            }

            DictionaryItems = File.ReadAllLines(dictionary_path);
        }
    }
}
