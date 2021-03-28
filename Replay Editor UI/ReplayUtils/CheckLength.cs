using Replay_Editor_UI.ReplayUtils.Presets;
using Replay_Editor_UI.ReplayUtils.API;
using Replay_Editor_UI.ReplayUtils.API.Manual;

namespace Replay_Editor_UI.ReplayUtils
{
    class CheckLength
    {
        static public bool Check_Length(string searchString, string replaceString, int i)
        {
            bool length = false;
            switch (i)
            {
                case 0:
                    if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
                    {
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                if (SetItemData.CP3(searchString).Length >= SetItemData.CP3(replaceString).Length)
                                {
                                    length = true;
                                }
                            }
                        }
                    }
                    else if (SetItemData.Item1(searchString) & !SetItemData.Item1(replaceString))
                    {
                        SetItemData.SetText3(replaceString, API_FromHS.Get_CP1(replaceString), API_FromHS.Get_CP2(replaceString), API_FromHS.Get_CP3(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                if (SetItemData.CP3(searchString).Length >= SetItemData.CP3(replaceString).Length)
                                {
                                    length = true;
                                }
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(replaceString) & !SetItemData.Item1(searchString))
                    {
                        SetItemData.SetText3(searchString, API_FromHS.Get_CP1(searchString), API_FromHS.Get_CP2(searchString), API_FromHS.Get_CP3(searchString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                if (SetItemData.CP3(searchString).Length >= SetItemData.CP3(replaceString).Length)
                                {
                                    length = true;
                                }
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else
                    {
                        SetItemData.SetText3(searchString, API_FromHS.Get_CP1(searchString), API_FromHS.Get_CP2(searchString), API_FromHS.Get_CP3(searchString));
                        SetItemData.SetText3(replaceString, API_FromHS.Get_CP1(replaceString), API_FromHS.Get_CP2(replaceString), API_FromHS.Get_CP3(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                if (SetItemData.CP3(searchString).Length >= SetItemData.CP3(replaceString).Length)
                                {
                                    length = true;
                                }
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    break;
                case 1:
                    if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
                    {
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                length = true;
                            }
                        }
                    }
                    else if (SetItemData.Item1(searchString))
                    {
                        SetItemData.SetText2(replaceString, API_FromHS.Get_CP1(replaceString), API_FromHS.Get_CP2(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                length = true;
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(replaceString))
                    {
                        SetItemData.SetText2(searchString, API_FromHS.Get_CP1(searchString), API_FromHS.Get_CP2(searchString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                length = true;
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else
                    {
                        SetItemData.SetText2(searchString, API_FromHS.Get_CP1(searchString), API_FromHS.Get_CP2(searchString));
                        SetItemData.SetText2(replaceString, API_FromHS.Get_CP1(replaceString), API_FromHS.Get_CP2(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                length = true;
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    break;
                case 2:
                    if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
                    {
                        if (API_Backpack.GetAsset(searchString).Length >= API_Backpack.GetAsset(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(searchString))
                    {
                        SetItemData.SetText1(replaceString, API_Backpack.GetAsset(replaceString));
                        if (API_Backpack.GetAsset(searchString).Length >= API_Backpack.GetAsset(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(replaceString))
                    {
                        SetItemData.SetText1(searchString, API_Backpack.GetAsset(searchString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                            if (API_Backpack.GetAsset(searchString).Length >= API_Backpack.GetAsset(replaceString).Length)
                            {
                                length = true;
                            }
                            else
                            {
                                length = false;
                            }
                    }
                    else
                    {
                        SetItemData.SetText1(searchString, API_Backpack.GetAsset(searchString));
                        SetItemData.SetText1(replaceString, API_Backpack.GetAsset(replaceString));
                        if (API_Backpack.GetAsset(searchString).Length >= API_Backpack.GetAsset(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    break;
                case 3:
                    if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
                    {
                        if (API_Pickaxe.GetAsset(searchString).Length >= API_Pickaxe.GetAsset(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(searchString))
                    {
                        SetItemData.SetText1(replaceString, API_Pickaxe.GetAsset(replaceString));
                        if (API_Pickaxe.GetAsset(searchString).Length >= API_Pickaxe.GetAsset(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(replaceString))
                    {
                        SetItemData.SetText1(searchString, API_Pickaxe.GetAsset(searchString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                            if (API_Pickaxe.GetAsset(searchString).Length >= API_Pickaxe.GetAsset(replaceString).Length)
                            {
                                length = true;
                            }
                            else
                            {
                                length = false;
                            }
                    }
                    else
                    {
                        SetItemData.SetText1(searchString, API_Pickaxe.GetAsset(searchString));
                        SetItemData.SetText1(replaceString, API_Pickaxe.GetAsset(replaceString));
                        if (API_Pickaxe.GetAsset(searchString).Length >= API_Pickaxe.GetAsset(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    break;
                case 4:
                    if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
                    {
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(searchString))
                    {
                        SetItemData.SetText1(replaceString, API_Wrap_and_Glider.Get_ID_From_Name(replaceString, false));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(replaceString))
                    {
                        SetItemData.SetText1(searchString, API_Wrap_and_Glider.Get_ID_From_Name(searchString, false));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else
                    {
                        SetItemData.SetText1(searchString, API_Wrap_and_Glider.Get_ID_From_Name(searchString, false));
                        SetItemData.SetText1(replaceString, API_Wrap_and_Glider.Get_ID_From_Name(replaceString, false));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    break;
                case 5:
                    if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
                    {
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(searchString))
                    {
                        SetItemData.SetText1(replaceString, API_Wrap_and_Glider.Get_ID_From_Name(replaceString, true));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(replaceString))
                    {
                        SetItemData.SetText1(searchString, API_Wrap_and_Glider.Get_ID_From_Name(searchString, true));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else
                    {
                        SetItemData.SetText1(searchString, API_Wrap_and_Glider.Get_ID_From_Name(searchString, true));
                        SetItemData.SetText1(replaceString, API_Wrap_and_Glider.Get_ID_From_Name(replaceString, true));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    break;
                case 6:
                    if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
                    {
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(searchString))
                    {
                        SetItemData.SetText2(replaceString, API_Emote.GetAsset_F(replaceString), API_Emote.GetAsset_F(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(replaceString))
                    {
                        SetItemData.SetText2(searchString, API_Emote.GetAsset_F(searchString), API_Emote.GetAsset_F(searchString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else
                    {
                        SetItemData.SetText2(searchString, API_Emote.GetAsset_F(searchString), API_Emote.GetAsset_F(searchString));
                        SetItemData.SetText2(replaceString, API_Emote.GetAsset_F(replaceString), API_Emote.GetAsset_F(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    break;
                case 7:
                    if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
                    {
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(searchString))
                    {
                        SetItemData.SetText2(replaceString, API_Emote.GetAsset_M(replaceString), API_Emote.GetAsset_M(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(replaceString))
                    {
                        SetItemData.SetText2(searchString, API_Emote.GetAsset_M(searchString), API_Emote.GetAsset_M(searchString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else
                    {
                        SetItemData.SetText2(searchString, API_Emote.GetAsset_M(searchString), API_Emote.GetAsset_M(searchString));
                        SetItemData.SetText2(replaceString, API_Emote.GetAsset_M(replaceString), API_Emote.GetAsset_M(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            length = true;
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    break;
            }
            return length;
        }

        static public bool Check_Length_FromHS(string searchString, string replaceString, int i)
        {
            bool length = false;
            switch (i)
            {
                case 0:
                    if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
                    {
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                if (SetItemData.CP3(searchString).Length >= SetItemData.CP3(replaceString).Length)
                                {
                                    length = true;
                                }
                            }
                        }
                    }
                    else if (SetItemData.Item1(searchString) & !SetItemData.Item1(replaceString))
                    {
                        SetItemData.SetText3(replaceString, API_FromHS.Get_CP1(replaceString), API_FromHS.Get_CP2(replaceString), API_FromHS.Get_CP3(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                if (SetItemData.CP3(searchString).Length >= SetItemData.CP3(replaceString).Length)
                                {
                                    length = true;
                                }
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(replaceString) & !SetItemData.Item1(searchString))
                    {
                        SetItemData.SetText3(searchString, API_FromHS.Get_CP1(searchString), API_FromHS.Get_CP2(searchString), API_FromHS.Get_CP3(searchString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                if (SetItemData.CP3(searchString).Length >= SetItemData.CP3(replaceString).Length)
                                {
                                    length = true;
                                }
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else
                    {
                        SetItemData.SetText3(searchString, API_FromHS.Get_CP1(searchString), API_FromHS.Get_CP2(searchString), API_FromHS.Get_CP3(searchString));
                        SetItemData.SetText3(replaceString, API_FromHS.Get_CP1(replaceString), API_FromHS.Get_CP2(replaceString), API_FromHS.Get_CP3(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                if (SetItemData.CP3(searchString).Length >= SetItemData.CP3(replaceString).Length)
                                {
                                    length = true;
                                }
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    break;
                case 1:
                    if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
                    {
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                length = true;
                            }
                        }
                    }
                    else if (SetItemData.Item1(searchString))
                    {
                        SetItemData.SetText2(replaceString, API_FromHS.Get_CP1(replaceString), API_FromHS.Get_CP2(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                length = true;
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else if (SetItemData.Item1(replaceString))
                    {
                        SetItemData.SetText2(searchString, API_FromHS.Get_CP1(searchString), API_FromHS.Get_CP2(searchString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                length = true;
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    else
                    {
                        SetItemData.SetText2(searchString, API_FromHS.Get_CP1(searchString), API_FromHS.Get_CP2(searchString));
                        SetItemData.SetText2(replaceString, API_FromHS.Get_CP1(replaceString), API_FromHS.Get_CP2(replaceString));
                        if (SetItemData.CP1(searchString).Length >= SetItemData.CP1(replaceString).Length)
                        {
                            if (SetItemData.CP2(searchString).Length >= SetItemData.CP2(replaceString).Length)
                            {
                                length = true;
                            }
                        }
                        else
                        {
                            length = false;
                        }
                    }
                    break;
            }
            return length;
        }
    }
}
