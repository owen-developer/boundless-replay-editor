using Replay_Editor_UI.Gets;
using Replay_Editor_UI.Functions.Message;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Replay_Editor_UI.Utils
{
    class UserSettings
    {
        public static string Path(string obj)
        {
            return AppData.appdata + obj.ToLower() + ".config";
        }

        public static void SetUserSettings(string obj, string value)
        {
            try
            {
                if (File.Exists(Path(obj)))
                {
                    File.WriteAllBytes(Path(obj), Bytes.Get(value));
                }
                else
                {
                    if (!Directory.Exists(AppData.appdata))
                    {
                        Directory.CreateDirectory(AppData.appdata);
                        File.Create(Path(obj));
                        File.WriteAllBytes(Path(obj), Bytes.Get(value));
                    }
                    else
                    {
                        File.Create(Path(obj));
                        File.WriteAllBytes(Path(obj), Bytes.Get(value));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static string Get(string obj)
        {
            return Encoding.ASCII.GetString(File.ReadAllBytes(Path(obj)));
        }

        public static int GetInt(string obj)
        {
            try
            {
                return int.Parse(Encoding.ASCII.GetString(File.ReadAllBytes(Path(obj))));
            }
            catch
            {
                return 0;
            }
        }
    }
}
