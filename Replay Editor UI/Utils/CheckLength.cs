using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Replay_Editor.Presets;

namespace Replay_Editor
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
                        {
                            if (SetItemData.cp2(searchString).Length >= SetItemData.cp2(replaceString).Length)
                            {
                                if (SetItemData.cp3(searchString).Length >= SetItemData.cp3(replaceString).Length)
                                {
                                    length = true;
                                }
                            }
                        }
                    }
                    else if (SetItemData.Item1(searchString) & !SetItemData.Item1(replaceString))
                    {
                        SetItemData.SetText3(replaceString, API.Get_CP1(replaceString), API.Get_CP2(replaceString), API.Get_CP3(replaceString));
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
                        {
                            if (SetItemData.cp2(searchString).Length >= SetItemData.cp2(replaceString).Length)
                            {
                                if (SetItemData.cp3(searchString).Length >= SetItemData.cp3(replaceString).Length)
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
                        SetItemData.SetText3(searchString, API.Get_CP1(searchString), API.Get_CP2(searchString), API.Get_CP3(searchString));
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
                        {
                            if (SetItemData.cp2(searchString).Length >= SetItemData.cp2(replaceString).Length)
                            {
                                if (SetItemData.cp3(searchString).Length >= SetItemData.cp3(replaceString).Length)
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
                        SetItemData.SetText3(searchString, API.Get_CP1(searchString), API.Get_CP2(searchString), API.Get_CP3(searchString));
                        SetItemData.SetText3(replaceString, API.Get_CP1(replaceString), API.Get_CP2(replaceString), API.Get_CP3(replaceString));
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
                        {
                            if (SetItemData.cp2(searchString).Length >= SetItemData.cp2(replaceString).Length)
                            {
                                if (SetItemData.cp3(searchString).Length >= SetItemData.cp3(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
                        {
                            if (SetItemData.cp2(searchString).Length >= SetItemData.cp2(replaceString).Length)
                            {
                                length = true;
                            }
                        }
                    }
                    else if (SetItemData.Item1(searchString))
                    {
                        SetItemData.SetText2(replaceString, API.Get_CP1(replaceString), API.Get_CP2(replaceString));
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
                        {
                            if (SetItemData.cp2(searchString).Length >= SetItemData.cp2(replaceString).Length)
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
                        SetItemData.SetText2(searchString, API.Get_CP1(searchString), API.Get_CP2(searchString));
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
                        {
                            if (SetItemData.cp2(searchString).Length >= SetItemData.cp2(replaceString).Length)
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
                        SetItemData.SetText2(searchString, API.Get_CP1(searchString), API.Get_CP2(searchString));
                        SetItemData.SetText2(replaceString, API.Get_CP1(replaceString), API.Get_CP2(replaceString));
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
                        {
                            if (SetItemData.cp2(searchString).Length >= SetItemData.cp2(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
                        if (SetItemData.cp1(searchString).Length >= SetItemData.cp1(replaceString).Length)
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
    }
}
