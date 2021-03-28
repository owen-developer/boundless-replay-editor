using Replay_Editor_UI.Functions.Message;
using Replay_Editor_UI.Gets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replay_Editor_UI.ReplayUtils.Swap.Manual
{
    class ManualSwap
    {

        private static BackgroundWorker backgroundWorker;

        static public void TotalFunction()
        {
            backgroundWorker = new BackgroundWorker
            {
                WorkerSupportsCancellation = true
            };

            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync();

            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.CancelAsync();
            }
        }

        static void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] args = @Params.args;
            string searchString = @Params.searchString_Manual;
            string replaceString = @Params.replaceString_Manual;

            Writer.Write(args, Bytes.Get(GetAsset(searchString)), Bytes.Get(GetAsset(replaceString)));
            Writer.Write(args, Bytes.Get(GetFooter(searchString)), Bytes.Get(GetFooter(replaceString)));
        }

        static void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Cancelled)
            {
                Console.WriteLine("Operation Cancelled");
            }
            else if (e.Error != null)
            {
                Console.WriteLine("Error in Process :" + e.Error);
            }
            else
            {
                Console.WriteLine("Operation Completed :" + e.Result);
                BoundlessMessage.Show("Successfully Converted!");
            }
        }

        static public string GetAsset(string name)
        {
            return name.Replace("FortniteGame/Content/", "/Game/").Replace(".uasset", "");
        }

        static public string GetFooter(string name)
        {
            name = name.Replace("FortniteGame/Content/Athena/Heroes/Meshes/Bodies/", "").Replace("FortniteGame/Content/Athena/Heroes/Meshes/Heads/", "").Replace("FortniteGame/Content/Characters/CharacterParts/Female/Medium/Bodies/", "").Replace("FortniteGame/Content/Characters/CharacterParts/Female/Medium/Heads/", "").Replace("FortniteGame/Content/Characters/CharacterParts/Male/Medium/Bodies/", "").Replace("FortniteGame/Content/Characters/CharacterParts/Male/Medium/Heads/", "").Replace("FortniteGame/Content/Characters/CharacterParts/Hats/", "").Replace("FortniteGame/Content/Characters/CharacterParts/FaceAccessories/", "").Replace("FortniteGame/Content/Athena/Items/Weapons/", "").Replace("FortniteGame/Content/Characters/CharacterParts/Backpacks/", "").Replace("FortniteGame/Content/Athena/Items/Cosmetics/Gliders/", "").Replace("FortniteGame/Content/Athena/Items/Cosmetics/ItemWraps/", "").Replace("FortniteGame/Content/Animation/Game/MainPlayer/", "");
            if (name.Contains("Emotes"))
            {
                Console.WriteLine("Contains Emote");
                string[] @footer = name.Split('/');
                return @footer[1];
            }
            else
            {
                Console.WriteLine(name);
                return name;
            }
        }
    }
}
