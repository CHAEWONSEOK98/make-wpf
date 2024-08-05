using CommandSample1.ViewModels;
using System.Windows;


namespace CommandSample1.Views
{

    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            MainViewModel mainViewModel = new MainViewModel();
            this.DataContext = mainViewModel;
        }
    }
}
