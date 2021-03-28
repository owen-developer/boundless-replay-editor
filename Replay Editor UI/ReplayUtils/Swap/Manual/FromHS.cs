using Replay_Editor_UI.Gets;
using Replay_Editor_UI.ReplayUtils.API.Manual;
using Replay_Editor_UI.ReplayUtils.Presets;
using System;
using System.Text;

namespace Replay_Editor_UI.ReplayUtils.Swap.Manual
{
    class FromHS
    {
        private static string GetFooter(string CP)
        {
            CP = CP.Replace("/Game/", "FortniteGame/Content/");
            CP = CP.Replace("FortniteGame/Content/Athena/Heroes/Meshes/Bodies/", "");
            CP = CP.Replace("FortniteGame/Content/Athena/Heroes/Meshes/Heads/", "");
            CP = CP.Replace("FortniteGame/Content/Characters/CharacterParts/Female/Medium/Bodies/", "");
            CP = CP.Replace("FortniteGame/Content/Characters/CharacterParts/Female/Medium/Heads/", "");
            CP = CP.Replace("FortniteGame/Content/Characters/CharacterParts/Male/Medium/Bodies/", "");
            CP = CP.Replace("FortniteGame/Content/Characters/CharacterParts/Male/Medium/Heads/", "");
            CP = CP.Replace("FortniteGame/Content/Characters/CharacterParts/Hats/", "");
            CP.Replace("FortniteGame/Content/Characters/CharacterParts/FaceAccessories/", "");
            return CP;
        }

        public static void SwapComplete(string[] args, string searchString, string replaceString, int o)
        {
            switch (o)
            {
                case 0:
                    if (SetItemData.CP1(searchString).Contains("Bodies") && SetItemData.CP1(replaceString).Contains("Bodies") || SetItemData.CP1(searchString).Contains("Heads") && SetItemData.CP1(replaceString).Contains("Heads") || SetItemData.CP1(searchString).Contains("Hat") && SetItemData.CP1(replaceString).Contains("Hat") || SetItemData.CP1(searchString).Contains("FaceAccessories") && SetItemData.CP1(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString)), Bytes.Get(SetItemData.CP1(replaceString)));
                        Writer.Write(args, Bytes.Get(GetFooter(SetItemData.CP1(searchString))), Bytes.Get(GetFooter(SetItemData.CP1(replaceString))));
                    }
                    else if (SetItemData.CP1(searchString).Contains("Bodies") && SetItemData.CP2(replaceString).Contains("Bodies") || SetItemData.CP1(searchString).Contains("Heads") && SetItemData.CP2(replaceString).Contains("Heads") || SetItemData.CP1(searchString).Contains("Hat") && SetItemData.CP2(replaceString).Contains("Hat") || SetItemData.CP1(searchString).Contains("FaceAccessories") && SetItemData.CP2(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString)), Bytes.Get(SetItemData.CP2(replaceString)));
                        Writer.Write(args, Bytes.Get(GetFooter(SetItemData.CP1(searchString))), Bytes.Get(GetFooter(SetItemData.CP2(replaceString))));
                    }
                    else if (SetItemData.CP1(searchString).Contains("Bodies") && SetItemData.CP3(replaceString).Contains("Bodies") || SetItemData.CP1(searchString).Contains("Heads") && SetItemData.CP3(replaceString).Contains("Heads") || SetItemData.CP1(searchString).Contains("Hat") && SetItemData.CP3(replaceString).Contains("Hat") || SetItemData.CP1(searchString).Contains("FaceAccessories") && SetItemData.CP3(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP1(searchString)), Bytes.Get(SetItemData.CP3(replaceString)));
                        Writer.Write(args, Bytes.Get(GetFooter(SetItemData.CP1(searchString))), Bytes.Get(GetFooter(SetItemData.CP3(replaceString))));
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
                        Writer.Write(args, Bytes.Get(GetFooter(SetItemData.CP2(searchString))), Bytes.Get(GetFooter(SetItemData.CP1(replaceString))));
                    }
                    else if (SetItemData.CP2(searchString).Contains("Bodies") && SetItemData.CP2(replaceString).Contains("Bodies") || SetItemData.CP2(searchString).Contains("Heads") && SetItemData.CP2(replaceString).Contains("Heads") || SetItemData.CP2(searchString).Contains("Hat") && SetItemData.CP2(replaceString).Contains("Hat") || SetItemData.CP2(searchString).Contains("FaceAccessories") && SetItemData.CP2(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP2(searchString)), Bytes.Get(SetItemData.CP2(replaceString)));
                        Writer.Write(args, Bytes.Get(GetFooter(SetItemData.CP2(searchString))), Bytes.Get(GetFooter(SetItemData.CP2(replaceString))));
                    }
                    else if (SetItemData.CP2(searchString).Contains("Bodies") && SetItemData.CP3(replaceString).Contains("Bodies") || SetItemData.CP2(searchString).Contains("Heads") && SetItemData.CP3(replaceString).Contains("Heads") || SetItemData.CP2(searchString).Contains("Hat") && SetItemData.CP3(replaceString).Contains("Hat") || SetItemData.CP2(searchString).Contains("FaceAccessories") && SetItemData.CP3(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP2(searchString)), Bytes.Get(SetItemData.CP3(replaceString)));
                        Writer.Write(args, Bytes.Get(GetFooter(SetItemData.CP2(searchString))), Bytes.Get(GetFooter(SetItemData.CP3(replaceString))));
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
                        Writer.Write(args, Bytes.Get(GetFooter(SetItemData.CP3(searchString))), Bytes.Get(GetFooter(SetItemData.CP1(replaceString))));
                    }
                    else if (SetItemData.CP3(searchString).Contains("Bodies") && SetItemData.CP2(replaceString).Contains("Bodies") || SetItemData.CP3(searchString).Contains("Heads") && SetItemData.CP2(replaceString).Contains("Heads") || SetItemData.CP3(searchString).Contains("Hat") && SetItemData.CP2(replaceString).Contains("Hat") || SetItemData.CP3(searchString).Contains("FaceAccessories") && SetItemData.CP2(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP3(searchString)), Bytes.Get(SetItemData.CP2(replaceString)));
                        Writer.Write(args, Bytes.Get(GetFooter(SetItemData.CP3(searchString))), Bytes.Get(GetFooter(SetItemData.CP2(replaceString))));
                    }
                    else if (SetItemData.CP3(searchString).Contains("Bodies") && SetItemData.CP3(replaceString).Contains("Bodies") || SetItemData.CP3(searchString).Contains("Heads") && SetItemData.CP3(replaceString).Contains("Heads") || SetItemData.CP3(searchString).Contains("Hat") && SetItemData.CP3(replaceString).Contains("Hat") || SetItemData.CP3(searchString).Contains("FaceAccessories") && SetItemData.CP3(replaceString).Contains("FaceAccessories"))
                    {
                        Writer.Write(args, Bytes.Get(SetItemData.CP3(searchString)), Bytes.Get(SetItemData.CP3(replaceString)));
                        Writer.Write(args, Bytes.Get(GetFooter(SetItemData.CP3(searchString))), Bytes.Get(GetFooter(SetItemData.CP3(replaceString))));
                    }
                    else
                    {
                        Console.WriteLine("Error: Mis-matching Face Assessory with Hat, Try Again With Two Characters With Face Assessory With Face Assessory or Hat With Hat...", Console.ForegroundColor = ConsoleColor.Yellow);
                    }
                    break;
            }
        }
    }
}
