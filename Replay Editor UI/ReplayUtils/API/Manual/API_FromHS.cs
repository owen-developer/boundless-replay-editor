using Newtonsoft.Json.Linq;
using Replay_Editor_UI.ReplayUtils.API.Reuseable;
using System.Net;

namespace Replay_Editor_UI.ReplayUtils.API.Manual
{
    class API_FromHS
    {
        readonly static WebClient requests = new WebClient();

        static public string Get_CP1_From_SID(string name)
        {
            string raw_json = requests.DownloadString("https://benbotfn.tk/api/v1/assetProperties?path=" + name);
            dynamic parsed = JObject.Parse(raw_json);
            string CP = parsed.export_properties[0].CharacterParts[0].assetPath;
            return RemoveDBLNode.Replace(CP, true);
        }

        static public string Get_CP2_From_SID(string name)
        {
            string raw_json = requests.DownloadString("https://benbotfn.tk/api/v1/assetProperties?path=" + name);
            dynamic parsed = JObject.Parse(raw_json);
            string CP = parsed.export_properties[0].CharacterParts[1].assetPath;
            return RemoveDBLNode.Replace(CP, true);
        }

        static public string Get_CP3_From_SID(string name)
        {
            string raw_json = requests.DownloadString("https://benbotfn.tk/api/v1/assetProperties?path=" + name);
            dynamic parsed = JObject.Parse(raw_json);
            string CP = parsed.export_properties[0].CharacterParts[2].assetPath;
            return RemoveDBLNode.Replace(CP, true);
        }

        static public string Get_CP1(string name)
        {
            return Get_CP1_From_SID(name).Replace("FortniteGame/Content/", "/Game/");
        }
        static public string Get_CP2(string name)
        {
            return Get_CP2_From_SID(name).Replace("FortniteGame/Content/", "/Game/");
        }

        static public string Get_CP3(string name)
        {
            return Get_CP3_From_SID(name).Replace("FortniteGame/Content/", "/Game/");
        }
    }
}
