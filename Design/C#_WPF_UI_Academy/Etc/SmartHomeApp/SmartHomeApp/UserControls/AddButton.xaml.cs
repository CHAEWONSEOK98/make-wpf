using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SmartHomeApp.UserControls
{
    public partial class AddButton : UserControl
    {
        public AddButton()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(AddButton));


    }
}
