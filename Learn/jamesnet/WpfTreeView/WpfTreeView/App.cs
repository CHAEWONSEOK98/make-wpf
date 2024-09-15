using Cupertino.Forms.UI.Views;
using System.Windows;

namespace WpfTreeView
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            CupertinoWindow window = new();
            window.Title = "Cupertino Window";
            window.ShowDialog();
        }
    }
}
