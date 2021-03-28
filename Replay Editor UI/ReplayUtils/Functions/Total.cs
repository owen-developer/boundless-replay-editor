using Replay_Editor_UI.Functions.Message;
using Replay_Editor_UI.Gets;
using Replay_Editor_UI.ReplayUtils.Presets;
using Replay_Editor_UI.ReplayUtils.Swap;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;

namespace Replay_Editor_UI.ReplayUtils.Functions
{
    class Total
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
            int bt = @Params.bt;
            string searchString = @Params.searchString;
            string replaceString = @Params.replaceString;
            int emoteType = @Params.emoteType;


            if(bt == 0)
            {
                if (SetItemData.Item1(searchString) & SetItemData.Item1(replaceString))
                {
                    if (SetItemData.Count(searchString) == SetItemData.Count(replaceString))
                    {
                        if (SetItemData.Count(searchString) == 3)
                        {
                            Console.WriteLine("Skin CPs = 3");
                            bt = 0;
                        }
                        else if (SetItemData.Count(searchString) == 2)
                        {
                            Console.WriteLine("Skin CPs = 2");
                            bt = 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Mis-matching CPs");
                        BoundlessMessage.Show("Mis-matching CPs: Means the CP that you selected for either search or replace has unequal amount of CPs (Character Parts) \nExample " + searchString + " has a hat and " + replaceString + " doesn't");
                    }
                }
                else if (SetItemData.Item1(searchString))
                {
                    if (SetItemData.Count(searchString) == SetItemData.CountFromHS(replaceString))
                    {
                        if (SetItemData.Count(searchString) == 3)
                        {
                            Console.WriteLine("Skin CPs = 3");
                            bt = 0;
                        }
                        else if (SetItemData.Count(searchString) == 2)
                        {
                            Console.WriteLine("Skin CPs = 2");
                            bt = 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Mis-matching CPs");
                        BoundlessMessage.Show("Mis-matching CPs: Means the CP that you selected for either search or replace has unequal amount of CPs (Character Parts) \nExample " + searchString + " has a hat and " + replaceString + " doesn't");
                    }
                }
                else if (SetItemData.Item1(replaceString))
                {
                    if (SetItemData.CountFromHS(searchString) == SetItemData.Count(replaceString))
                    {
                        if (SetItemData.Count(searchString) == 3)
                        {
                            Console.WriteLine("Skin CPs = 3");
                            bt = 0;
                        }
                        else if (SetItemData.Count(searchString) == 2)
                        {
                            Console.WriteLine("Skin CPs = 2");
                            bt = 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Mis-matching CPs");
                        BoundlessMessage.Show("Mis-matching CPs: Means the CP that you selected for either search or replace has unequal amount of CPs (Character Parts) \nExample " + searchString + " has a hat and " + replaceString + " doesn't");
                    }
                }
                else
                {
                    if (SetItemData.CountFromHS(searchString) == SetItemData.CountFromHS(replaceString))
                    {
                        if (SetItemData.Count(searchString) == 3)
                        {
                            Console.WriteLine("Skin CPs = 3");
                            bt = 0;
                        }
                        else if (SetItemData.Count(searchString) == 2)
                        {
                            Console.WriteLine("Skin CPs = 2");
                            bt = 1;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Mis-matching CPs");
                        BoundlessMessage.Show("Mis-matching CPs: Means the CP that you selected for either search or replace has unequal amount of CPs (Character Parts) \nExample " + searchString + " has a hat and " + replaceString + " doesn't");
                    }
                }
            }

            switch (bt)
            {
                case 0:

                    Console.WriteLine("Selected Character (3 Parts)", Console.ForegroundColor = ConsoleColor.Red);
                    try
                    {
                        if (CheckLength.Check_Length(searchString, replaceString, 0) == true)
                        {
                            LongSwitch.SwapComplete(args, searchString, replaceString, 0, 3);
                            LongSwitch.SwapComplete(args, searchString, replaceString, 1, 3);
                            LongSwitch.SwapComplete(args, searchString, replaceString, 2, 3);
                        }
                        else
                        {
                            Console.WriteLine("Could not swap due to length of asset.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case 1:

                    Console.WriteLine("Selected Character (2 Parts)", Console.ForegroundColor = ConsoleColor.Red);
                    try
                    {
                        if (CheckLength.Check_Length(searchString, replaceString, 1) == true)
                        {
                            LongSwitch.SwapComplete(args, searchString, replaceString, 0, 2);
                            LongSwitch.SwapComplete(args, searchString, replaceString, 1, 2);
                        }
                        else
                        {
                            Console.WriteLine("Could not swap due to length of asset.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case 2:

                    Console.WriteLine("Selected Backpack", Console.ForegroundColor = ConsoleColor.Red);
                    try
                    {
                        if (CheckLength.Check_Length(searchString, replaceString, 2) == true)
                        {
                            SwapBackpack.SwapComplete(args, searchString, replaceString);
                        }
                        else
                        {
                            Console.WriteLine("Could not swap due to length of asset.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case 3:

                    Console.WriteLine("Selected Pickaxe", Console.ForegroundColor = ConsoleColor.Red);
                    try
                    {
                        if (CheckLength.Check_Length(searchString, replaceString, 3) == true)
                        {
                            SwapPickaxe.SwapComplete(args, searchString, replaceString);
                        }
                        else
                        {
                            Console.WriteLine("Could not swap due to length of asset.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case 4:

                    Console.WriteLine("Selected Emote", Console.ForegroundColor = ConsoleColor.Red);
                    try
                    {
                        switch (emoteType)
                        {
                            case 0:
                                if (CheckLength.Check_Length(searchString, replaceString, 6) == true)
                                {
                                    SwapEmote.SwapComplete(args, searchString, replaceString, 0);
                                }
                                else
                                {
                                    Console.WriteLine("Could not swap due to length of asset.");
                                }
                                break;
                            case 1:
                                if (CheckLength.Check_Length(searchString, replaceString, 7) == true)
                                {
                                    SwapEmote.SwapComplete(args, searchString, replaceString, 1);
                                }
                                else
                                {
                                    Console.WriteLine("Could not swap due to length of asset.");
                                }
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case 5:

                    Console.WriteLine("Selected Wrap", Console.ForegroundColor = ConsoleColor.Red);
                    try
                    {
                        if (CheckLength.Check_Length(searchString, replaceString, 4) == true)
                        {
                            SwapWrapAndGlider.SwapComplete(args, searchString, replaceString, false);
                        }
                        else
                        {
                            Console.WriteLine("Could not swap due to length of asset.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
                case 6:

                    Console.WriteLine("Selected Glider", Console.ForegroundColor = ConsoleColor.Red);
                    try
                    {
                        if (CheckLength.Check_Length(searchString, replaceString, 5) == true)
                        {
                            SwapWrapAndGlider.SwapComplete(args, searchString, replaceString, true);
                        }
                        else
                        {
                            Console.WriteLine("Could not swap due to length of asset.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    break;
            }
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
    }
}
