using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replay_Editor_UI.Discord
{
    class Init
    {
		static public DiscordRpcClient client;
		static public void Initialize()
		{
			client = new DiscordRpcClient("808467908333928448");
			client.Initialize();
			client.SetPresence(new RichPresence()
			{
				Details = "Replay Editor (Manual)",
				State = "Made by owen#1234",
				Assets = new Assets()
				{
					LargeImageKey = "serverlogoturqiose",
					LargeImageText = "Boundless Replay Editor",
					SmallImageKey = "cyuxvd6z"
				}
			});
		}
	}
}
