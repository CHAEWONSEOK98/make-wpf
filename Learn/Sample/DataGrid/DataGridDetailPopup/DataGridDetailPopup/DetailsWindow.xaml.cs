using System.Windows;

namespace DataGridDetailPopup
{
    public partial class DetailsWindow : Window
    {
        public DetailsWindow(object user)
        {
            InitializeComponent();

            DataContext = user;
        }
    }
}
