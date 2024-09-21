using _05_PasswordBoxMVVM.ViewModels;
using System.Windows;

namespace _05_PasswordBoxMVVM
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
