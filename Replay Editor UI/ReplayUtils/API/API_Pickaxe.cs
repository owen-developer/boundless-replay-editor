using Newtonsoft.Json.Linq;
using Replay_Editor_UI.ReplayUtils.API.Reuseable;
using System.Net;

namespace Replay_Editor_UI.ReplayUtils.API
{
    class API_Pickaxe
    {
        readonly static WebClient requests = new WebClient();

        static public string Get_CP_From_ID(string CosmeticID)
        {
            string raw_json = requests.DownloadString("https://benbotfn.tk/api/v1/assetProperties?path=" + CosmeticID + "&lang=en");
            dynamic parsed = JObject.Parse(raw_json);
            string CP = parsed.export_properties[0].WeaponDefinition;
            return CP;
        }

        static public string GetAsset(string name)
        {
            return "FortniteGame/Content/Athena/Items/Weapons/" + Get_CP_From_ID(ByName.Get_ID_From_Name(name));
        }
    }
}
