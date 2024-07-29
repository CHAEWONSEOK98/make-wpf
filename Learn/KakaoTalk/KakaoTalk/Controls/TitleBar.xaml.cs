using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;
using System.Windows.Controls;

using WpfLib.Extensions;

namespace KakaoTalk.Controls
{
    [ObservableObject]

    public partial class TitleBar : UserControl
    {
        private Window? _parentWindow;
        private WindowState _winState;

        public WindowState Winstate
        {
            get 
            { 
                return _winState; 
            }
            set 
            { 
                SetProperty(ref _winState, value); 
            }
        }


        public Window ParentWindow
        {
            get
            {
                if(_parentWindow == null)
                {
                    _parentWindow = this.FindParent<Window>()!;
                }
                return _parentWindow;
            }
            set { _parentWindow = value; }
        }


        public TitleBar()
        {
            InitializeComponent();

            btnExit.Click += BtnExit_Click;
            btnMaximize.Click += BtnMaximize_Click;
            btnMinimize.Click += BtnMinimize_Click;
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            Winstate = WindowState.Minimized;
            ParentWindow.WindowState = Winstate;
        }

        private void BtnMaximize_Click(object sender, RoutedEventArgs e)
        {
            Winstate = ParentWindow.WindowState == WindowState.Maximized
                ? WindowState.Normal
                : WindowState.Maximized;
            ParentWindow.WindowState = Winstate;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            ParentWindow.Close();
        }
    }
}
