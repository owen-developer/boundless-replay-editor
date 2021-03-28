using Newtonsoft.Json.Linq;
using Replay_Editor_UI.Gets;
using Replay_Editor_UI.ReplayUtils.API;
using Replay_Editor_UI.ReplayUtils.API.Manual;
using System.IO;

namespace Replay_Editor_UI.ReplayUtils.Presets
{
    class SetItemData
    {
        readonly static string appdata = AppData.appdata;

        static public bool Item1(string item)
        {
            if (File.Exists(appdata + "\\" + item.ToLower() + ".boundless"))
            {
                return true;
            }
            else
            {
                if (!Directory.Exists(appdata))
                {
                    Directory.CreateDirectory(appdata);
                }
                return false;
            }
        }

        static public int Count(string item)
        {
            var token = JToken.Parse((File.ReadAllText(appdata + "\\" + item.Replace("FortniteGame/Content/Athena/Heroes/Specializations/", "").ToLower() + ".boundless")));
            var roles = token.Value<JArray>("finalassets");
            var Count = roles.Count;
            return Count;
        }

        static public int CountFromHS(string item)
        {
            try
            {
                SetText3(item, API_Skin.Get_CP1(item), API_Skin.Get_CP2(item), API_Skin.Get_CP3(item));
                return 3;
            }
            catch
            {
                SetText2(item, API_Skin.Get_CP1(item), API_Skin.Get_CP2(item));
                return 2;
            }
        }

        static public int CountFromHSLiterally(string item)
        {
            try
            {
                SetText3(item.Replace("FortniteGame/Content/Athena/Heroes/Specializations/", ""), API_FromHS.Get_CP1(item), API_FromHS.Get_CP2(item), API_FromHS.Get_CP3(item));
                return 3;
            }
            catch
            {
                SetText2(item.Replace("FortniteGame/Content/Athena/Heroes/Specializations/", ""), API_FromHS.Get_CP1(item), API_FromHS.Get_CP2(item));
                return 2;
            }
        }

        static public string CP1(string item)
        {
            dynamic parsed = JObject.Parse(File.ReadAllText(appdata + "\\" + item.Replace("FortniteGame/Content/Athena/Heroes/Specializations/", "").ToLower() + ".boundless"));
            return parsed.finalassets[0];
        }

        static public string CP2(string item)
        {
            dynamic parsed = JObject.Parse(File.ReadAllText(appdata + "\\" + item.Replace("FortniteGame/Content/Athena/Heroes/Specializations/", "").ToLower() + ".boundless"));
            return parsed.finalassets[1];
        }

        static public string CP3(string item)
        {
            dynamic parsed = JObject.Parse(File.ReadAllText(appdata + "\\" + item.Replace("FortniteGame/Content/Athena/Heroes/Specializations/", "").ToLower() + ".boundless"));
            return parsed.finalassets[2];
        }

        static public void SetText3(string item, string CP1, string CP2, string CP3)
        {
            using (FileStream fs = File.Create(appdata + "\\" + item.Replace("FortniteGame/Content/Athena/Heroes/Specializations/", "").ToLower() + ".boundless"))
            {
                byte[] json = Bytes.Get("{ \"finalassets\": [ \"" + CP1 + "\", \"" + CP2 + "\", \"" + CP3 + "\" ] }");
                fs.Write(json, 0, json.Length);
            }
        }

        static public void SetText2(string item, string CP1, string CP2)
        {
            using (FileStream fs = File.Create(appdata + "\\" + item.Replace("FortniteGame/Content/Athena/Heroes/Specializations/", "").ToLower() + ".boundless"))
            {
                byte[] json = Bytes.Get("{ \"finalassets\": [ \"" + CP1 + "\", \"" + CP2 + "\" ] }");
                fs.Write(json, 0, json.Length);
            }
        }

        static public void SetText1(string item, string CP1)
        {
            using (FileStream fs = File.Create(appdata + "\\" + item.ToLower() + ".boundless"))
            {
                byte[] json = Bytes.Get("{ \"finalassets\": [ \"" + CP1 + "\" ] }");
                fs.Write(json, 0, json.Length);
            }
        }

        internal static void SetText1(string searchString, object p)
        {
            throw new System.NotImplementedException();
        }
    }
}
