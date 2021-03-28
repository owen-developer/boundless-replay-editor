using Replay_Editor_UI.Gets;
using Replay_Editor_UI.ReplayUtils.API;
using Replay_Editor_UI.ReplayUtils.Presets;
using System;
using System.Text;

namespace Replay_Editor_UI.ReplayUtils.Swap
{
    class SwapEmote
    {
        public static void Swap(string[] args, string searchString, string replaceString, int i)
        {
            try
            {
                switch (i)
                {
                    case 0:
                        string footerSearchF = API_Emote.GetFullFooter_F(searchString);
                        string footerReplaceF = API_Emote.GetFullFooter_F(replaceString);

                        Writer.Write(args, Bytes.Get(SetItemData.CP2(searchString)),
                            Bytes.Get(SetItemData.CP2(replaceString)));

                        Writer.Write(args, Bytes.Get(footerSearchF),
                            Bytes.Get(footerReplaceF));

                        break;
                    case 1:
                        string footerSearchM = API_Emote.GetFullFooter_M(searchString);
                        string footerReplaceM = API_Emote.GetFullFooter_M(replaceString);

                        Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString)),
                            Bytes.Get(SetItemData.CP1(replaceString)));

                        Writer.Write(args, Bytes.Get(footerSearchM),
                            Bytes.Get(footerReplaceM));
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void SwapComplete(string[] args, string searchString, string replaceString, int i)
        {
            if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
            {
                Swap(args, searchString, replaceString, i);
            }
            else if (SetItemData.Item1(searchString))
            {
                SetItemData.SetText2(replaceString, API_Emote.GetAsset_M(replaceString), API_Emote.GetAsset_F(replaceString));
                Swap(args, searchString, replaceString, i);
            }
            else if (SetItemData.Item1(replaceString))
            {
                SetItemData.SetText2(searchString, API_Emote.GetAsset_M(searchString), API_Emote.GetAsset_F(searchString));
                Swap(args, searchString, replaceString, i);
            }
            else
            {
                SetItemData.SetText2(searchString, API_Emote.GetAsset_M(searchString), API_Emote.GetAsset_F(searchString));
                SetItemData.SetText2(replaceString, API_Emote.GetAsset_M(replaceString), API_Emote.GetAsset_F(replaceString));
                Swap(args, searchString, replaceString, i);
            }
        }
    }
}
