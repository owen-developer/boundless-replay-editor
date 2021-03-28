using Replay_Editor_UI.Gets;
using Replay_Editor_UI.ReplayUtils.API;
using Replay_Editor_UI.ReplayUtils.Presets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replay_Editor_UI.ReplayUtils.Swap
{
    class SwapWrapAndGlider
    {
        public static void Swap(string[] args, string searchString, string replaceString)
        {
            Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString).Replace("FortniteGame/Content/", "/Game/")), Bytes.Get(SetItemData.CP1(replaceString).Replace("FortniteGame/Content/", "/Game/")));
            Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString).Replace("FortniteGame/Content/Athena/Items/Cosmetics/Gliders/", "").Replace("FortniteGame/Content/Athena/Items/Cosmetics/ItemWraps/", "")), Bytes.Get(SetItemData.CP1(replaceString).Replace("FortniteGame/Content/Athena/Items/Cosmetics/Gliders/", "").Replace("FortniteGame/Content/Athena/Items/Cosmetics/ItemWraps/", "")));
        }
        public static void SwapComplete(string[] args, string searchString, string replaceString, bool glider)
        {
            if (SetItemData.Item1(searchString) && SetItemData.Item1(replaceString))
            {
                Swap(args, searchString, replaceString);
            }
            else if (SetItemData.Item1(searchString))
            {
                SetItemData.SetText1(replaceString, API_Wrap_and_Glider.Get_ID_From_Name(replaceString, glider));
                Swap(args, searchString, replaceString);
            }
            else if (SetItemData.Item1(replaceString))
            {
                SetItemData.SetText1(searchString, API_Wrap_and_Glider.Get_ID_From_Name(searchString, glider));
                Swap(args, searchString, replaceString);
            }
            else
            {
                SetItemData.SetText1(replaceString, API_Wrap_and_Glider.Get_ID_From_Name(searchString, glider));
                SetItemData.SetText1(replaceString, API_Wrap_and_Glider.Get_ID_From_Name(replaceString, glider));
                Swap(args, searchString, replaceString);
            }
        }
    }
}
