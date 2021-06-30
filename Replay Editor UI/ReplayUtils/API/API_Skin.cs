using Newtonsoft.Json.Linq;
using Replay_Editor_UI.ReplayUtils.API.Reuseable;
using System.Net;

namespace Replay_Editor_UI.ReplayUtils.API
{
    class API_Skin
    {
        readonly static WebClient requests = new WebClient();

        static public string Get_HID_From_ID(string CosmeticID)
        {
            string raw_json = requests.DownloadString("https://benbot.app/api/v1/assetProperties?path=" + CosmeticID + "&lang=en");
            dynamic parsed = JObject.Parse(raw_json);
            string HID = parsed.export_properties[0].HeroDefinition;
            return HID;
        }

        static public string Get_SID_From_HID(string name)
        {
            string raw_json = requests.DownloadString("https://benbot.app/api/v1/assetProperties?path=FortniteGame/Content/Athena/Heroes/" + name + "&lang=en");
            dynamic parsed = JObject.Parse(raw_json);
            string SID = parsed.export_properties[0].Specializations[0].assetPath;
            SID = SID.Replace("/Game/", "FortniteGame/Content/");
            SID = SID.Replace("FortniteGame/Content/Athena/Heroes/", "").Replace(".", "");
            SID = SID.Substring(SID.Length / 2);
            SID = SID.Replace("HS", "FortniteGame/Content/Athena/Heroes/Specializations/HS");
            SID = SID.Substring(8);
            return SID;
        }

        static public string Get_CP1_From_SID(string name)
        {
            string raw_json = requests.DownloadString("https://benbot.app/api/v1/assetProperties?path=" + name);
            dynamic parsed = JObject.Parse(raw_json);
            string CP = parsed.export_properties[0].CharacterParts[0].assetPath;
            return RemoveDBLNode.Replace(CP, true);
        }

        static public string Get_CP2_From_SID(string name)
        {
            string raw_json = requests.DownloadString("https://benbot.app/api/v1/assetProperties?path=" + name);
            dynamic parsed = JObject.Parse(raw_json);
            string CP = parsed.export_properties[0].CharacterParts[1].assetPath;
            return RemoveDBLNode.Replace(CP, true);
        }

        static public string Get_CP3_From_SID(string name)
        {
            string raw_json = requests.DownloadString("https://benbot.app/api/v1/assetProperties?path=" + name);
            dynamic parsed = JObject.Parse(raw_json);
            string CP = parsed.export_properties[0].CharacterParts[2].assetPath;
            return RemoveDBLNode.Replace(CP, true);
        }

        static public string Get_CP1(string name)
        {
            return Get_CP1_From_SID(Get_SID_From_HID(Get_HID_From_ID(ByName.Get_ID_From_Name(name)))).Replace("FortniteGame/Content/", "/Game/");
        }
        static public string Get_CP2(string name)
        {
            return Get_CP2_From_SID(Get_SID_From_HID(Get_HID_From_ID(ByName.Get_ID_From_Name(name)))).Replace("FortniteGame/Content/", "/Game/");
        }

        static public string Get_CP3(string name)
        {
            return Get_CP3_From_SID(Get_SID_From_HID(Get_HID_From_ID(ByName.Get_ID_From_Name(name)))).Replace("FortniteGame/Content/", "/Game/");
        }

        static public string GetSubFooter(int i, string name)
        {
            string raw_json = requests.DownloadString("https://benbot.app/api/v1/assetProperties?path=" + name);
            dynamic parsed = JObject.Parse(raw_json);
            string CP = parsed.export_properties[0].CharacterParts[0].assetPath;
            switch (i)
            {
                case 0:
                    CP = parsed.export_properties[0].CharacterParts[0].assetPath;
                    break;
                case 1:
                    CP = parsed.export_properties[0].CharacterParts[1].assetPath;
                    break;
                case 2:
                    CP = parsed.export_properties[0].CharacterParts[2].assetPath;
                    break;
            }
            return RemoveDBLNode.Replace(CP, false);
        }
        static public string GetFullFooter1(string name)
        {
            return GetSubFooter(0, Get_SID_From_HID(Get_HID_From_ID(ByName.Get_ID_From_Name(name))));
        }

        static public string GetFullFooter2(string name)
        {
            return GetSubFooter(1, Get_SID_From_HID(Get_HID_From_ID(ByName.Get_ID_From_Name(name))));
        }

        static public string GetFullFooter3(string name)
        {
            return GetSubFooter(2, Get_SID_From_HID(Get_HID_From_ID(ByName.Get_ID_From_Name(name))));
        }
    }
}
