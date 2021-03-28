using Replay_Editor_UI.Functions.Message;
using Replay_Editor_UI.Gets;
using Replay_Editor_UI.Utils;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Media;
using Ookii.Dialogs;
using Ookii.Dialogs.Wpf;
using Replay_Editor_UI.Properties;

namespace Replay_Editor_UI
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
        }

        public Brush BrushMaker(int R, int G, int B)
        {
            return new SolidColorBrush(Color.FromArgb(255, (byte)R, (byte)G, (byte)B));
        }

        public void LoadedWindow()
        {
            try
            {
                if (!Directory.Exists(AppData.appdata))
                {
                    Directory.CreateDirectory(AppData.appdata);
                    File.Create(AppData.appdata + "\\theme.config");
                }
                else
                {
                    if (!File.Exists(AppData.appdata + "\\theme.config"))
                    {
                        File.Create(AppData.appdata + "\\theme.config");
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
                    BlueTheme.IsSelected = true;
                    this.Background = BrushMaker(0, 97, 195);
                    break;
                case 1:
                    DarkTheme.IsSelected = true;
                    this.Background = BrushMaker(20, 20, 20);
                    break;
                case 2:
                    BlackTheme.IsSelected = true;
                    this.Background = BrushMaker(10, 10, 10);
                    break;
            }
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            UserSettings.SetUserSettings("Theme", "0");
            LoadedWindow();
        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            UserSettings.SetUserSettings("Theme", "1");
            LoadedWindow();
        }

        private void ComboBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            UserSettings.SetUserSettings("Theme", "2");
            LoadedWindow();
        }


        private void Settings_Loaded(object sender, RoutedEventArgs e)
        {
            LoadedWindow();
            OutputPath.Text = UserSettings.Get("Output");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        readonly VistaFolderBrowserDialog output = new VistaFolderBrowserDialog();

        private void SelectFolder_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)output.ShowDialog(this))
            {
                OutputPath.FontSize = 10;
                UserSettings.SetUserSettings("Output", output.SelectedPath);
                OutputPath.Text = output.SelectedPath;
                BoundlessMessage.Show("Selected Output Path");
            }
        }
    }
}
