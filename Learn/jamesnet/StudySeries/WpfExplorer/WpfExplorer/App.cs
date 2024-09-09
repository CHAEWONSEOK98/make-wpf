using System.Windows;
using WpfExplorer.Forms.UI.Views;

namespace WpfExplorer
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ExplorerWinodw win = new ExplorerWinodw();
            win.Title = "James"; ;
            win.ShowDialog();
        }
    }
}
