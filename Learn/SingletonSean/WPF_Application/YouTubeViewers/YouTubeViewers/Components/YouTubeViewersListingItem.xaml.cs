using System.Windows.Controls;

namespace YouTubeViewers.Components
{
    public partial class YouTubeViewersListingItem : UserControl
    {
        public YouTubeViewersListingItem()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            dropdown.IsOpen = false;
        }
    }
}
