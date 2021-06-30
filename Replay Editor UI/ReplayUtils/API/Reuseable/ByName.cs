using Newtonsoft.Json.Linq;
using Replay_Editor_UI.Gets;
using System.Net;

namespace Replay_Editor_UI.ReplayUtils.API.Reuseable
{
    class ByName
    {
        readonly static WebClient requests = new WebClient();
        static public string Get_ID_From_Name(string name)
        {
            string backendType = "";
            switch (@Params.bt)
            {
                case 0:
                    backendType = "AthenaCharacter";
                    break;
                case 2:
                    backendType = "AthenaBackpack";
                    break;
                case 3:
                    backendType = "AthenaPickaxe";
                    break;
                case 4:
                    backendType = "AthenaDance";
                    break;
                case 5:
                    backendType = "AthenaItemWrap";
                    break;
                case 6:
                    backendType = "AthenaGlider";
                    break;

            }
            string raw_json = requests.DownloadString("https://benbot.app/api/v1/cosmetics/br/search?lang=en&searchLang=en&matchMethod=full&name=" + name + "&backendType=" + backendType);
            dynamic parsed = JObject.Parse(raw_json);
            string ID = parsed.path;
            return ID;
        }
    }
}
