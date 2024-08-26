using System.Windows;
using WpfDatePicker.UI.Views;

namespace WpfDatePicker
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow window = new();
            window.Show();
        }
    }
}
