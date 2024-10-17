using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WpfSlidePanel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Panel.SetZIndex(slidePanel, int.MaxValue);
            Storyboard storyboard = (Storyboard)this.Resources["OpenStoryboard"];
            storyboard.Begin();
        }

        private void opacityGrid_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Storyboard storyboard = (Storyboard)this.Resources["CloseStoryboard"];
            storyboard.Completed += Storyboard_Completed;
            storyboard.Begin();
        }

        private void Storyboard_Completed(object? sender, EventArgs e)
        {
            Panel.SetZIndex(slidePanel, int.MinValue);
        }
    }
}