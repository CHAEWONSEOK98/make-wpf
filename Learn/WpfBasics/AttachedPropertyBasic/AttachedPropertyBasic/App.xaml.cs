using AttachedPropertyBasic.ViewModels;
using System.Windows;

namespace AttachedPropertyBasic
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainView = new MainWindow
            {
                DataContext = new MainViewModel()
            };
            mainView.Show();
        }
    }

}
