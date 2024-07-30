using System.Windows;
using System.Windows.Media;


namespace ComboBoxSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //cmb.SetBackground(Brushes.Yellow);
        }
    }
}