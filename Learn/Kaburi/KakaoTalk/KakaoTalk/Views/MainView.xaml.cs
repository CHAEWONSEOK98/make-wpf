using KakaoTalk.ViewModels;
using System.Windows;


namespace KakaoTalk.Views
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = App.Current.Services.GetService(typeof(MainViewModel));
        }
    }
}
