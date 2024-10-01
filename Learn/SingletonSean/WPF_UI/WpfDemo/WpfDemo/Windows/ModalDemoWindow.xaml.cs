using System.Windows;

namespace WpfDemo.Windows
{
    public partial class ModalDemoWindow : Window
    {
        public ModalDemoWindow()
        {
            InitializeComponent();
        }

        private void OnShowModalClick(object sender, RoutedEventArgs e)
        {
            modal.IsOpen = true;
        }

        private void OnCloseModalClick(object sender, RoutedEventArgs e)
        {
            modal.IsOpen = false;
        }
    }
}
