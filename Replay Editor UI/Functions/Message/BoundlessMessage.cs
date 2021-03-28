using System.Windows;

namespace Replay_Editor_UI.Functions.Message
{
    class BoundlessMessage
    {
        public static void Show(string msg)
        {
            BoundlessMessageBox.msg = msg;
            new BoundlessMessageBox().ShowDialog();
        }
    }
}