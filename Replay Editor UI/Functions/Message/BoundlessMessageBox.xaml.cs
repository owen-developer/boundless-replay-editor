using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Replay_Editor_UI.Functions.Message
{
    /// <summary>
    /// Interaction logic for BoundlessMessageBox.xaml
    /// </summary>
    public partial class BoundlessMessageBox : Window
    {
        public BoundlessMessageBox()
        {
            InitializeComponent();
        }

        public static string msg;

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            text.Text = msg;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
