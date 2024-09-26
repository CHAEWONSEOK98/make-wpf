using AnalogClock.CustomControls;
using System.Windows;

namespace AnalogClock
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AnalogClock_TimeChanged(object sender, RoutedPropertyChangedEventArgs<DateTime> e)
        {
            tbTime.Text = e.NewValue.ToString("hh:mm:ss");
        }
    }
}