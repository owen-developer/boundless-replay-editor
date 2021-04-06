using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Replay_Editor_UI.Utils;
using System.IO;
using Replay_Editor_UI.Gets;
using Microsoft.Win32;
using Replay_Editor_UI.ReplayUtils.Functions;
using System.Diagnostics;
using Replay_Editor_UI.ReplayUtils;
using System.Text;
using Replay_Editor_UI.Functions.Message;
using Replay_Editor_UI.Discord;
using Replay_Editor_UI.ReplayUtils.Swap.Manual;

namespace Replay_Editor_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Brush BrushMaker(int R, int G, int B)
        {
            return new SolidColorBrush(Color.FromArgb(255, (byte)R, (byte)G, (byte)B)); 
        }

        private bool ValuesValid()
        {
            if (Type.SelectedItem != null)
            {
                if (SearchName.Text != "Search Name")
                {
                    if (ReplaceName.Text != "Replace Name")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool ReplaySelected()
        {
            if (pickreplay.FileNames.Length != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadedWindow()
        {
            try
            {
                if (!Directory.Exists(AppData.appdata))
                {
                    Directory.CreateDirectory(AppData.appdata);
                    File.Create(AppData.appdata + "\\theme.config");
                    File.Create(AppData.appdata + "\\output.config");
                }
                else
                {
                    if (!File.Exists(AppData.appdata + "\\theme.config"))
                    {
                        File.Create(AppData.appdata + "\\theme.config");
                    }
                    if (!File.Exists(AppData.appdata + "\\output.config"))
                    {
                        File.Create(AppData.appdata + "\\output.config");
                    }
                }
            }
            catch (Exception ex)
            {
                BoundlessMessage.Show(ex.ToString());
            }
            switch (UserSettings.GetInt("Theme"))
            {
                case 0:
                    this.Background = BrushMaker(0, 107, 205);
                    this.Foreground = BrushMaker(255, 255, 255);
                    break;
                case 1:
                    this.Background = BrushMaker(30, 30, 30);
                    PickReplay.Background = BrushMaker(60, 60, 60);
                    Decompress.Background = BrushMaker(60, 60, 60);
                    Type.Background = BrushMaker(60, 60, 60);
                    SearchName.Background = BrushMaker(60, 60, 60);
                    ReplaceName.Background = BrushMaker(60, 60, 60);
                    ReplaceHS.Background = BrushMaker(60, 60, 60);
                    Test.Background = BrushMaker(60, 60, 60);
                    ConvertButton.Background = BrushMaker(60, 60, 60);
                    Move.Background = BrushMaker(60, 60, 60);
                    ConvertButtonManualHS.Background = BrushMaker(60, 60, 60);
                    ConvertButtonManual.Background = BrushMaker(60, 60, 60);
                    ApplicationSettings.Background = BrushMaker(60, 60, 60);
                    this.Foreground = BrushMaker(255, 255, 255);
                    break;
                case 2:
                    this.Background = BrushMaker(0, 0, 0);
                    PickReplay.Background = BrushMaker(10, 10, 10);
                    Decompress.Background = BrushMaker(10, 10, 10);
                    Type.Background = BrushMaker(10, 10, 10);
                    SearchName.Background = BrushMaker(10, 10, 10);
                    ReplaceName.Background = BrushMaker(10, 10, 10);
                    ReplaceHS.Background = BrushMaker(10, 10, 10);
                    Test.Background = BrushMaker(10, 10, 10);
                    ConvertButton.Background = BrushMaker(10, 10, 10);
                    Move.Background = BrushMaker(10, 10, 10);
                    ConvertButtonManualHS.Background = BrushMaker(10, 10, 10);
                    ConvertButtonManual.Background = BrushMaker(10, 10, 10);
                    ApplicationSettings.Background = BrushMaker(10, 10, 10);    
                    this.Foreground = BrushMaker(255, 255, 255);
                    break;
                case 3:
                    this.Background = BrushMaker(24, 29, 38);
                    PickReplay.Background = BrushMaker(17, 21, 26);
                    Decompress.Background = BrushMaker(17, 21, 26);
                    Type.Background = BrushMaker(17, 21, 26);
                    SearchName.Background = BrushMaker(17, 21, 26);
                    ReplaceName.Background = BrushMaker(17, 21, 26);
                    ReplaceHS.Background = BrushMaker(17, 21, 26);
                    Test.Background = BrushMaker(17, 21, 26);
                    ConvertButton.Background = BrushMaker(17, 21, 26);
                    Move.Background = BrushMaker(17, 21, 26);
                    ConvertButtonManualHS.Background = BrushMaker(17, 21, 26);
                    ConvertButtonManual.Background = BrushMaker(17, 21, 26);
                    ApplicationSettings.Background = BrushMaker(17, 21, 26);
                    this.Foreground = BrushMaker(255, 255, 255);
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Loaded");
            Init.Initialize();
            LoadedWindow();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        static int backendType;

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            if (ReplaySelected())
            {
                if (ValuesValid())
                {
                    @Params.args = pickreplay.FileNames;
                    @Params.bt = backendType;
                    @Params.searchString = SearchName.Text;
                    @Params.replaceString = ReplaceName.Text;
                    if (AthenaDance.IsSelected)
                    {
                        @Params.emoteType = 0;
                        Total.TotalFunction();
                    }
                    else
                    {
                        @Params.emoteType = 1;
                        Total.TotalFunction();
                    }
                }
                else
                {
                    BoundlessMessage.Show("Input Values are Invalid");
                }
            }
            else
            {
                BoundlessMessage.Show("You Haven't Selected a Replay!");
            }
        }

        readonly OpenFileDialog pickreplay = new OpenFileDialog();

        private void PickReplay_Click(object sender, RoutedEventArgs e)
        { 
            pickreplay.Filter = "Replay Files (*.replay)|*.replay";
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FortniteGame\\Saved\\Demos"))
            {
                pickreplay.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FortniteGame\\Saved\\Demos";
            }
            if (pickreplay.ShowDialog() == true)
            {
                Writer.decompressed = false;
                Decompress.IsEnabled = true;
                BoundlessMessage.Show("Selected Replay File");
            }
        }

        private void Decompress_Click(object sender, RoutedEventArgs e)
        {
            Download.Files(
                            "https://cdn.discordapp.com/attachments/790734495485394965/790734536337653790/FastMember.dll",
                            "FastMember.dll");
            Download.Files(
                "https://cdn.discordapp.com/attachments/790734495485394965/790734537876570132/FortniteReplayDumper.deps.json",
                "FortniteReplayDumper.deps.json");
            Download.Files(
                "https://cdn.discordapp.com/attachments/790734495485394965/790734539797823518/FortniteReplayDumper.dll",
                "FortniteReplayDumper.dll");
            Download.Files(
                "https://cdn.discordapp.com/attachments/790734495485394965/790734541476200498/FortniteReplayDumper.exe",
                "FortniteReplayDumper.exe");
            Download.Files(
                "https://cdn.discordapp.com/attachments/790734495485394965/790734542302347335/FortniteReplayDumper.runtimeconfig.json",
                "FortniteReplayDumper.runtimeconfig.json");
            Download.Files(
                "https://cdn.discordapp.com/attachments/790734495485394965/790734543724085260/FortniteReplayReader.dll",
                "FortniteReplayReader.dll");
            Download.Files(
                "https://cdn.discordapp.com/attachments/790734495485394965/790734544520478730/Microsoft.Extensions.DependencyInjection.Abstractions.dll",
                "Microsoft.Extensions.DependencyInjection.Abstractions.dll");
            Download.Files(
                "https://cdn.discordapp.com/attachments/790734495485394965/790734545838145616/Microsoft.Extensions.DependencyInjection.dll",
                "Microsoft.Extensions.DependencyInjection.dll");
            Download.Files(
                "https://cdn.discordapp.com/attachments/790734495485394965/790734546953175080/Microsoft.Extensions.Logging.Abstractions.dll",
                "Microsoft.Extensions.Logging.Abstractions.dll");
            Download.Files(
                "https://cdn.discordapp.com/attachments/790734495485394965/790734547989168138/OozSharp.dll",
                "OozSharp.dll");
            Download.Files(
                "https://cdn.discordapp.com/attachments/790734495485394965/790734581321695232/Unreal.Core.dll",
                "Unreal.Core.dll");
            Download.Files(
                "https://cdn.discordapp.com/attachments/790734495485394965/790734581799976990/Unreal.Encryption.dll",
                "Unreal.Encryption.dll");
            Process cmd = new Process();
            cmd.StartInfo.FileName = AppData.appdata + "Replay Decompressor\\" + "\\FortniteReplayDumper.exe";
            StringBuilder builder = new StringBuilder();
            foreach (string value in pickreplay.FileNames)
            {
                builder.Append(value);
                builder.Append(' ');
            }
            string result = builder.ToString().Replace("\"", "");
            cmd.StartInfo.Arguments = "\"" + result + "\"";
            cmd.Start();
            Writer.decompressed = true;
        }

        private void AthenaCharacter_Selected(object sender, RoutedEventArgs e)
        {
            backendType = 0;
        }

        private void AthenaBackpack_Selected(object sender, RoutedEventArgs e)
        {
            backendType = 2;
        }

        private void AthenaPickaxe_Selected(object sender, RoutedEventArgs e)
        {
            backendType = 3;
        }

        private void AthenaDance_Selected(object sender, RoutedEventArgs e)
        {
            backendType = 4;
        }

        private void AthenaDance2_Selected(object sender, RoutedEventArgs e)
        {
            backendType = 4;
        }

        private void AthenaItemWrap_Selected(object sender, RoutedEventArgs e)
        {
            backendType = 5;
        }

        private void AthenaGlider_Selected(object sender, RoutedEventArgs e)
        {
            backendType = 6;
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            if (ValuesValid())
            {
                @Params.args = pickreplay.FileNames;
                @Params.bt = backendType;
                @Params.searchString = SearchName.Text;
                @Params.replaceString = ReplaceName.Text;
                if (AthenaDance.IsSelected)
                {
                    @Params.emoteType = 1;
                    ReplayUtils.Functions.Test.TotalFunction();
                }
                else
                {
                    @Params.emoteType = 1;
                    ReplayUtils.Functions.Test.TotalFunction();
                }
            }
            else
            {
                BoundlessMessage.Show("You haven't selected a backendType (Ex. Backpack)!");
            }
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void SearchName_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SearchName.Clear();
        }

        private void ReplaceName_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ReplaceName.Clear();
        }

        private void ConvertButtonManualHS_Click(object sender, RoutedEventArgs e)
        {
            if (ReplaySelected())
            {
                @Params.args= pickreplay.FileNames;
                @Params.searchString_FromHS = SearchHS.Text;
                @Params.replaceString_FromHS = ReplaceHS.Text;
                Total_FromHS.TotalFunction();
            }
            else
            {
                BoundlessMessage.Show("You Haven't Selected a Replay!");
            }
        }

        private void ApplicationSettings_Click(object sender, RoutedEventArgs e)
        {
            new Options().ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ConvertButtonManual_Click(object sender, RoutedEventArgs e)
        {
            if (ReplaySelected())
            {
                @Params.args = pickreplay.FileNames;
                @Params.searchString_Manual = SearchManual.Text;
                @Params.replaceString_Manual = ReplaceManual.Text;
                ManualSwap.TotalFunction();
            }
            else
            {
                BoundlessMessage.Show("You Haven't Selected a Replay!");
            }
        }

        private void Move_Click(object sender, RoutedEventArgs e)
        {
            if (ReplaySelected())
            {
                StringBuilder builder = new StringBuilder();
                foreach (string value in pickreplay.FileNames)
                {
                    builder.Append(value);
                    builder.Append(' ');
                }
                string result = builder.ToString();
                try
                {
                    File.Move(result, UserSettings.Get("Output") + "\\" + Path.GetFileName(result));
                    BoundlessMessage.Show("Moved!");

                }
                catch
                {
                    BoundlessMessage.Show("File already at that location.");
                }
            }
            else
            {
                BoundlessMessage.Show("You Haven't Selected a Replay!");
            }
        }
    }
}
