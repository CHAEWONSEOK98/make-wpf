using System.Windows;

namespace CustomListboxLayoutViews
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var data = new[]
            {
                new {Name = "James"},
                new {Name = "Mike"},
                new {Name = "John"},
                new {Name = "Luke"},
                new {Name = "Oscar"},
                new {Name = "Charles"},
            };

            MyListbox.ItemsSource = data;
        }

        private void TileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MyListbox.layout = Layout.Tile;
        }

        private void ListMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MyListbox.layout = Layout.List;
        }
    }
}