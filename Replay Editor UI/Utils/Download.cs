using Replay_Editor_UI.Gets;
using System.IO;
using System.Net;

namespace Replay_Editor_UI.Utils
{
    class Download
    {
        readonly static WebClient down = new WebClient();

        static public void Files(string url, string name)
        {
            if (!Directory.Exists(AppData.appdata + "Replay Decompressor"))
            {
                Directory.CreateDirectory(AppData.appdata + "Replay Decompressor");
                if (!File.Exists(AppData.appdata + "Replay Decompressor\\" + name))
                {
                    down.DownloadFile(url, AppData.appdata + "Replay Decompressor\\" + name);
                }
            }
            else
            {
                if (!File.Exists(AppData.appdata + "Replay Decompressor\\" + name))
                {
                    down.DownloadFile(url, AppData.appdata + "Replay Decompressor\\" + name);
                }
            }
        }
    }
}
