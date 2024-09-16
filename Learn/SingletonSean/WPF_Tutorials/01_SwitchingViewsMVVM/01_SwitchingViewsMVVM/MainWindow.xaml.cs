using _01_SwitchingViewsMVVM.ViewModels;
using System.Windows;

namespace _01_SwitchingViewsMVVM
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }
    }
}