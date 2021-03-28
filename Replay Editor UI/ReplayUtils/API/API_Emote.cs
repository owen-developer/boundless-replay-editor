using Newtonsoft.Json.Linq;
using Replay_Editor_UI.ReplayUtils.API.Reuseable;
using System.Net;

namespace Replay_Editor_UI.ReplayUtils.API
{
    class API_Emote
    {
        readonly static WebClient requests = new WebClient();

        static public string Get_ANIM_From_ID(string CosmeticID)
        {
            string raw_json = requests.DownloadString("https://benbotfn.tk/api/v1/assetProperties?path=" + CosmeticID + "&lang=en");
            dynamic parsed = JObject.Parse(raw_json);
            string Anim = parsed.export_properties[0].Animation.assetPath;
            return Anim;
        }

        static public string Get_ANIM_F_From_ID(string CosmeticID)
        {
            string raw_json = requests.DownloadString("http://benbotfn.tk/api/v1/assetProperties?path=" + CosmeticID + "&lang=en");
            dynamic parsed = JObject.Parse(raw_json);
            string Anim = parsed.export_properties[0].AnimationFemaleOverride.assetPath;
            return Anim;
        }

        static public string GetFullFooter_M(string name)
        {
            string @before = Get_ANIM_From_ID(ByName.Get_ID_From_Name(name));
            string[] @footer = @before.Split('.');
            return @footer[1];
        }

        static public string GetFullFooter_F(string name)
        {
            string @before = Get_ANIM_F_From_ID(ByName.Get_ID_From_Name(name));
            string[] @footer = @before.Split('.');
            return @footer[1];
        }

        static public string GetAsset_M(string name)
        {
            string before = Get_ANIM_From_ID(ByName.Get_ID_From_Name(name));
            string[] pathparse = before.Split('.');
            return pathparse[0].Replace("FortniteGame/Content/", "/Game/");
        }

        static public string GetAsset_F(string name)
        {
            string before = Get_ANIM_F_From_ID(ByName.Get_ID_From_Name(name));
            string[] pathparse = before.Split('.');
            return pathparse[0].Replace("FortniteGame/Content/", "/Game/");
        }
    }
}
