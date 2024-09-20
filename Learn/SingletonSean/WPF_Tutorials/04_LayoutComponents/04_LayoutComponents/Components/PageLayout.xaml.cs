using System.Windows;
using System.Windows.Controls;

namespace _04_LayoutComponents.Components
{
    public partial class PageLayout : UserControl
    {
        public static readonly DependencyProperty HeaderProperty =
    DependencyProperty.Register("Header", typeof(string), typeof(PageLayout), new PropertyMetadata(string.Empty));

        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public PageLayout()
        {
            InitializeComponent();
        }
    }
}
