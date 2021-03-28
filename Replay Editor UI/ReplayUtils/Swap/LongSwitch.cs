using Replay_Editor_UI.ReplayUtils.Presets;
using System;
using Replay_Editor_UI.ReplayUtils.API;
using System.Text;
using Replay_Editor_UI.Gets;

namespace Replay_Editor_UI.ReplayUtils.Swap
{
    class LongSwitch
    {

        public static void SwitchStatement(string[] args, string searchString, string replaceString, int o)
        {
            switch (o)
            {
                case 0:
                    if (SetItemData.CP1(searchString).Contains("Bodies") && SetItemData.CP1(replaceString).Contains("Bodies") || SetItemData.CP1(searchString).Contains("Heads") && SetItemData.CP1(replaceString).Contains("Heads") || SetItemData.CP1(searchString).Contains("Hat") && SetItemData.CP1(replaceString).Contains("Hat") || SetItemData.CP1(searchString).Contains("FaceAccessories") && SetItemData.CP1(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString)), Bytes.Get(SetItemData.CP1(replaceString)));
                        Writer.Write(args, Bytes.Get(API_Skin.GetFullFooter1(searchString)), Bytes.Get(API_Skin.GetFullFooter1(replaceString)));
                    }
                    else if (SetItemData.CP1(searchString).Contains("Bodies") && SetItemData.CP2(replaceString).Contains("Bodies") || SetItemData.CP1(searchString).Contains("Heads") && SetItemData.CP2(replaceString).Contains("Heads") || SetItemData.CP1(searchString).Contains("Hat") && SetItemData.CP2(replaceString).Contains("Hat") || SetItemData.CP1(searchString).Contains("FaceAccessories") && SetItemData.CP2(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString)), Bytes.Get(SetItemData.CP2(replaceString)));
                        Writer.Write(args, Bytes.Get(API_Skin.GetFullFooter1(searchString)), Bytes.Get(API_Skin.GetFullFooter2(replaceString)));
                    }
                    else if (SetItemData.CP1(searchString).Contains("Bodies") && SetItemData.CP3(replaceString).Contains("Bodies") || SetItemData.CP1(searchString).Contains("Heads") && SetItemData.CP3(replaceString).Contains("Heads") || SetItemData.CP1(searchString).Contains("Hat") && SetItemData.CP3(replaceString).Contains("Hat") || SetItemData.CP1(searchString).Contains("FaceAccessories") && SetItemData.CP3(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString)), Bytes.Get(SetItemData.CP3(replaceString)));
                        Writer.Write(args, Bytes.Get(API_Skin.GetFullFooter1(searchString)), Bytes.Get(API_Skin.GetFullFooter3(replaceString)));
                    }
                    else
                    {
                        Console.WriteLine("Error: Mis-matching Face Assessory with Hat, Try Again With Two Characters With Face Assessory With Face Assessory or Hat With Hat...", Console.ForegroundColor = ConsoleColor.Yellow);
                    }
                    break;
                case 1:
                    if (SetItemData.CP2(searchString).Contains("Bodies") && SetItemData.CP1(replaceString).Contains("Bodies") || SetItemData.CP2(searchString).Contains("Heads") && SetItemData.CP1(replaceString).Contains("Heads") || SetItemData.CP2(searchString).Contains("Hat") && SetItemData.CP1(replaceString).Contains("Hat") || SetItemData.CP2(searchString).Contains("FaceAccessories") && SetItemData.CP1(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP2(searchString)), Bytes.Get(SetItemData.CP1(replaceString)));
                        Writer.Write(args, Bytes.Get(API_Skin.GetFullFooter2(searchString)), Bytes.Get(API_Skin.GetFullFooter1(replaceString)));
                    }
                    else if (SetItemData.CP2(searchString).Contains("Bodies") && SetItemData.CP2(replaceString).Contains("Bodies") || SetItemData.CP2(searchString).Contains("Heads") && SetItemData.CP2(replaceString).Contains("Heads") || SetItemData.CP2(searchString).Contains("Hat") && SetItemData.CP2(replaceString).Contains("Hat") || SetItemData.CP2(searchString).Contains("FaceAccessories") && SetItemData.CP2(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP2(searchString)), Bytes.Get(SetItemData.CP2(replaceString)));
                        Writer.Write(args, Bytes.Get(API_Skin.GetFullFooter2(searchString)), Bytes.Get(API_Skin.GetFullFooter2(replaceString)));
                    }
                    else if (SetItemData.CP2(searchString).Contains("Bodies") && SetItemData.CP3(replaceString).Contains("Bodies") || SetItemData.CP2(searchString).Contains("Heads") && SetItemData.CP3(replaceString).Contains("Heads") || SetItemData.CP2(searchString).Contains("Hat") && SetItemData.CP3(replaceString).Contains("Hat") || SetItemData.CP2(searchString).Contains("FaceAccessories") && SetItemData.CP3(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP2(searchString)), Bytes.Get(SetItemData.CP3(replaceString)));
                        Writer.Write(args, Bytes.Get(API_Skin.GetFullFooter2(searchString)), Bytes.Get(API_Skin.GetFullFooter3(replaceString)));
                    }
                    else
                    {
                        Console.WriteLine("Error: Mis-matching Face Assessory with Hat, Try Again With Two Characters With Face Assessory With Face Assessory or Hat With Hat...", Console.ForegroundColor = ConsoleColor.Yellow);
                    }
                    break;
                case 2:
                    if (SetItemData.CP3(searchString).Contains("Bodies") && SetItemData.CP1(replaceString).Contains("Bodies") || SetItemData.CP3(searchString).Contains("Heads") && SetItemData.CP1(replaceString).Contains("Heads") || SetItemData.CP3(searchString).Contains("Hat") && SetItemData.CP1(replaceString).Contains("Hat") || SetItemData.CP3(searchString).Contains("FaceAccessories") && SetItemData.CP1(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP3(searchString)), Bytes.Get(SetItemData.CP1(replaceString)));
                        Writer.Write(args, Bytes.Get(API_Skin.GetFullFooter3(searchString)), Bytes.Get(API_Skin.GetFullFooter1(replaceString)));
                    }
                    else if (SetItemData.CP3(searchString).Contains("Bodies") && SetItemData.CP2(replaceString).Contains("Bodies") || SetItemData.CP3(searchString).Contains("Heads") && SetItemData.CP2(replaceString).Contains("Heads") || SetItemData.CP3(searchString).Contains("Hat") && SetItemData.CP2(replaceString).Contains("Hat") || SetItemData.CP3(searchString).Contains("FaceAccessories") && SetItemData.CP2(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP3(searchString)), Bytes.Get(SetItemData.CP2(replaceString)));
                        Writer.Write(args, Bytes.Get(API_Skin.GetFullFooter3(searchString)), Bytes.Get(API_Skin.GetFullFooter2(replaceString)));
                    }
                    else if (SetItemData.CP3(searchString).Contains("Bodies") && SetItemData.CP3(replaceString).Contains("Bodies") || SetItemData.CP3(searchString).Contains("Heads") && SetItemData.CP3(replaceString).Contains("Heads") || SetItemData.CP3(searchString).Contains("Hat") && SetItemData.CP3(replaceString).Contains("Hat") || SetItemData.CP3(searchString).Contains("FaceAccessories") && SetItemData.CP3(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP3(searchString)), Bytes.Get(SetItemData.CP3(replaceString)));
                        Writer.Write(args, Bytes.Get(API_Skin.GetFullFooter3(searchString)), Bytes.Get(API_Skin.GetFullFooter3(replaceString)));
                    }
                    else
                    {
                        Console.WriteLine("Error: Mis-matching Face Assessory with Hat, Try Again With Two Characters With Face Assessory With Face Assessory or Hat With Hat...", Console.ForegroundColor = ConsoleColor.Yellow);
                    }
                    break;
            }
        }

   

        public static void SwapComplete(string[] args, string searchString, string replaceString, int o, int n)
        {

            if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
            {
                Console.WriteLine("\nWriting from saved Files...");
                SwitchStatement(args, searchString, replaceString, o);
            }
            else if (SetItemData.Item1(searchString))
            {
                switch (n)
                {
                    case 3:
                        SetItemData.SetText3(replaceString, API_Skin.Get_CP1(replaceString), API_Skin.Get_CP2(replaceString), API_Skin.Get_CP3(replaceString));
                        break;
                    case 2:
                        SetItemData.SetText2(replaceString, API_Skin.Get_CP1(replaceString), API_Skin.Get_CP2(replaceString));
                        break;
                }
                SwitchStatement(args, searchString, replaceString, o);
            }
            else if (SetItemData.Item1(replaceString))
            {
                switch (n)
                {
                    case 3:
                        SetItemData.SetText3(searchString, API_Skin.Get_CP1(searchString), API_Skin.Get_CP2(searchString), API_Skin.Get_CP3(searchString));
                        break;
                    case 2:
                        SetItemData.SetText2(searchString, API_Skin.Get_CP1(searchString), API_Skin.Get_CP2(searchString));
                        break;
                }
                SwitchStatement(args, searchString, replaceString, o);
            }
            else
            {
                switch (n)
                {
                    case 3:
                        SetItemData.SetText3(searchString, API_Skin.Get_CP1(searchString), API_Skin.Get_CP2(searchString), API_Skin.Get_CP3(searchString));
                        SetItemData.SetText3(replaceString, API_Skin.Get_CP1(replaceString), API_Skin.Get_CP2(replaceString), API_Skin.Get_CP3(replaceString));
                        break;
                    case 2:
                        SetItemData.SetText2(searchString, API_Skin.Get_CP1(searchString), API_Skin.Get_CP2(searchString));
                        SetItemData.SetText2(replaceString, API_Skin.Get_CP1(replaceString), API_Skin.Get_CP2(replaceString));
                        break;
                }
                SwitchStatement(args, searchString, replaceString, o);
            }
        }
    }
}
