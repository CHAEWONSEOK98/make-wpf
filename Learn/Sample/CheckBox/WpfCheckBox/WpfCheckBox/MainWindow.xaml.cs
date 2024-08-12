using System.Windows;

namespace WpfCheckBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CHX1_Checked(object sender, RoutedEventArgs e)
        {
            CHX2.IsEnabled = true;
            CHX2.IsChecked = true;
            CHX3.IsEnabled = true;
            CHX3.IsChecked = true;
            CHX4.IsEnabled = true;
            CHX4.IsChecked = true;
        }

        private void CHX1_Unchecked(object sender, RoutedEventArgs e)
        {
            CHX2.IsEnabled = false;
            CHX2.IsChecked = false;
            CHX3.IsEnabled = false;
            CHX3.IsChecked = false;
            CHX4.IsEnabled = false;
            CHX4.IsChecked = false;
        }

        private void CHX1_Indeterminate(object sender, RoutedEventArgs e)
        {
            CHX2.IsEnabled = true;
            CHX2.IsChecked = true;
            CHX3.IsEnabled = true;
            CHX3.IsChecked = true;
            CHX4.IsEnabled = false;
            CHX4.IsChecked = false;
        }
    }
}