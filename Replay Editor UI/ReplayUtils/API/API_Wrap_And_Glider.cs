using Newtonsoft.Json.Linq;
using System.Net;

namespace Replay_Editor_UI.ReplayUtils.API
{
    class API_Wrap_and_Glider
    {
        readonly static WebClient requests = new WebClient();

        static public string Get_ID_From_Name(string name, bool glider)
        {
            string raw_json;
            if (glider)
            {
                raw_json = requests.DownloadString(
                    "https://benbotfn.tk/api/v1/cosmetics/br/search?lang=en&searchLang=en&matchMethod=full&name=" + name + "&backendType=AthenaGlider");
            }
            else
            {
                raw_json = requests.DownloadString("https://benbotfn.tk/api/v1/cosmetics/br/search?lang=en&searchLang=en&matchMethod=full&name=" + name + "&backendType=AthenaItemWrap");
            }
            dynamic parsed = JObject.Parse(raw_json);
            string ID = parsed.path;
            return ID;
        }
    }
}
