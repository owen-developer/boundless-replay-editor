using Replay_Editor_UI.Gets;
using System.IO;
using System.Net;
using System.Text;

namespace Replay_Editor_UI.ReplayUtils.API.Gets
{
    class AllCosmetics
    {
        readonly static WebClient requests = new WebClient();

        static public string Download()
        {
            return requests.DownloadString("https://benbotfn.tk/api/v1/cosmetics/br?lang=en");
        }
    }
}
