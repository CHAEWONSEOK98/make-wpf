using _02_EventCommands.ViewModels;
using System.Windows;

namespace _02_EventCommands
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