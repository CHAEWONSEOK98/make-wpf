using _03_AsyncCommands.ViewModels;
using System.Windows;

namespace _03_AsyncCommands
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new LoginViewModel()
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
