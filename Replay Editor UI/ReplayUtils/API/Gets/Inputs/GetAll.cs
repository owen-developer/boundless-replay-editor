using Newtonsoft.Json.Linq;
using Replay_Editor_UI.Functions.Message;
using Replay_Editor_UI.Gets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replay_Editor_UI.ReplayUtils.API.Gets.Inputs
{
    class GetAll
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
            string[] list = {};

            string jsonObj = AllCosmetics.Download();
            JArray jsonArray = JArray.Parse(jsonObj);
            dynamic parsed = JObject.Parse(jsonArray[0].ToString());
            int o = 0;
            foreach (var backendType in parsed.path)
            {
                o += 1;
            }
            for (int i = 0; o > i; i++)
            {
                if (parsed.backendType[i] == Params.bt)
                {
                    foreach (var id in parsed.path)
                    {
                        list.SetValue(id, list.Length + 1);
                        Console.WriteLine(id);
                    }
                }
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
                BoundlessMessage.Show("Done!");
            }
        }
    }
}
