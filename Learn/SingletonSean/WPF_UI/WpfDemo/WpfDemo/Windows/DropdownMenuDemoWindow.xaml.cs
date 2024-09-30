using System.Windows;

namespace WpfDemo.Windows
{
    public partial class DropdownMenuDemoWindow : Window
    {
        public DropdownMenuDemoWindow()
        {
            InitializeComponent();

            lvNames.ItemsSource = new List<string>()
            {
                "Joe",
                "Sean",
                "Mary"
            };
        }

        private void OnEditClick(object sender, RoutedEventArgs e)
        {

        }

        private void OnDeleteClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
