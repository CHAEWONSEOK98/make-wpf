using System.Collections.ObjectModel;
using System.Windows;

namespace WpfDemo.Windows
{
    public partial class HighlightTextBlockDemoWindow : Window
    {
        public HighlightTextBlockDemoWindow()
        {
            InitializeComponent();

            lvItems.ItemsSource = new ObservableCollection<string>()
            {
                "Hello World",
                "Name is",
                "Chaegyul",
                "and my cat",
                "king cat",
            };
        }
    }
}
