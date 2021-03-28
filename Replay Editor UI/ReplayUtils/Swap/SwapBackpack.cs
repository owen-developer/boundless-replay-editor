using Microsoft.Win32;
using Replay_Editor_UI.Gets;
using Replay_Editor_UI.ReplayUtils.API;
using Replay_Editor_UI.ReplayUtils.Presets;
using System.Text;

namespace Replay_Editor_UI.ReplayUtils.Swap
{
    class SwapBackpack
    {
        public static void Swap(string[] args, string searchString, string replaceString)
        {
            Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString).Replace("FortniteGame/Content/", "/Game/")), Bytes.Get(SetItemData.CP1(replaceString).Replace("FortniteGame/Content/", "/Game/")));
            Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString).Replace("FortniteGame/Content/Characters/CharacterParts/Backpacks/", "")), Bytes.Get(SetItemData.CP1(replaceString).Replace("FortniteGame/Content/Characters/CharacterParts/Backpacks/", "")));
        }
        public static void SwapComplete(string[] args, string searchString, string replaceString)
        {
            if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
            {
                Swap(args, searchString, replaceString);
            }
            else if (SetItemData.Item1(searchString))
            {
                SetItemData.SetText1(replaceString, API_Backpack.GetAsset(replaceString));
                Swap(args, searchString, replaceString);
            }
            else if (SetItemData.Item1(replaceString))
            {
                SetItemData.SetText1(searchString, API_Backpack.GetAsset(searchString));
                Swap(args, searchString, replaceString);
            }
            else
            {
                SetItemData.SetText1(searchString, API_Backpack.GetAsset(searchString));
                SetItemData.SetText1(replaceString, API_Backpack.GetAsset(replaceString));
                Swap(args, searchString, replaceString);
            }
        }
    }
}
