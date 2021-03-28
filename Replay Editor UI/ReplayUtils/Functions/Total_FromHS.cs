using Replay_Editor_UI.Functions.Message;
using Replay_Editor_UI.Gets;
using Replay_Editor_UI.ReplayUtils.Presets;
using Replay_Editor_UI.ReplayUtils.Swap.Manual;
using System;
using System.ComponentModel;

namespace Replay_Editor_UI.ReplayUtils.Functions
{
    class Total_FromHS
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
            string searchString = @Params.searchString_FromHS.Replace("FortniteGame/Content/Athena/Heroes/Specializations/", "").Replace(".uasset", "");
            string replaceString = @Params.replaceString_FromHS.Replace("FortniteGame/Content/Athena/Heroes/Specializations/", "").Replace(".uasset", ""); ;
            int bt = 0;

            searchString = "FortniteGame/Content/Athena/Heroes/Specializations/" + searchString;
            replaceString = "FortniteGame/Content/Athena/Heroes/Specializations/" + replaceString;

            if (bt == 0)
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
                    if (SetItemData.Count(searchString) == SetItemData.CountFromHSLiterally(replaceString))
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
                    if (SetItemData.CountFromHSLiterally(searchString) == SetItemData.Count(replaceString))
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
                    if (SetItemData.CountFromHSLiterally(searchString) == SetItemData.CountFromHSLiterally(replaceString))
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
                            FromHS.SwapComplete(args, searchString, replaceString, 0);
                            FromHS.SwapComplete(args, searchString, replaceString, 1);
                            FromHS.SwapComplete(args, searchString, replaceString, 2);
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
                            FromHS.SwapComplete(args, searchString, replaceString, 0);
                            FromHS.SwapComplete(args, searchString, replaceString, 1);
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
