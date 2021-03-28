using Replay_Editor_UI.Gets;
using Replay_Editor_UI.ReplayUtils.API;
using Replay_Editor_UI.ReplayUtils.Presets;
using System.Text;

namespace Replay_Editor_UI.ReplayUtils.Swap
{
    class SwapPickaxe
    {
        public static void Swap(string[] args, string searchString, string replaceString)
        {
            Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString.Replace("/", "")).Replace("FortniteGame/Content/", "/Game/")), Bytes.Get(SetItemData.CP1(replaceString.Replace("/", "")).Replace("FortniteGame/Content/", "/Game/")));
            Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString.Replace("/", "")).Replace("FortniteGame/Content/Athena/Items/Weapons/", "")), Bytes.Get(SetItemData.CP1(replaceString.Replace("/", "")).Replace("FortniteGame/Content/Athena/Items/Weapons/", "")));
        }
        public static void SwapComplete(string[] args, string searchString, string replaceString)
        {
            if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
            {
                Swap(args, searchString, replaceString);
            }
            else if (SetItemData.Item1(searchString))
            {
                SetItemData.SetText1(replaceString.Replace("/", ""), API_Pickaxe.GetAsset(replaceString));
                Swap(args, searchString, replaceString);
            }
            else if (SetItemData.Item1(replaceString))
            {
                SetItemData.SetText1(searchString.Replace("/", ""), API_Pickaxe.GetAsset(searchString));
                Swap(args, searchString, replaceString);
            }
            else
            {
                SetItemData.SetText1(searchString.Replace("/", ""), API_Pickaxe.GetAsset(searchString));
                SetItemData.SetText1(replaceString.Replace("/", ""), API_Pickaxe.GetAsset(replaceString));
                Swap(args, searchString, replaceString);
            }
        }
    }
}
