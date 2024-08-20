using System.Windows;
using System.Windows.Controls;

namespace CustomListboxLayoutViews
{
    public class LayoutListbox : ListBox
    {

        public Layout layout
        {
            get { return (Layout)GetValue(layoutProperty); }
            set { SetValue(layoutProperty, value); }
        }
        public static readonly DependencyProperty layoutProperty =
            DependencyProperty.Register("layout", typeof(Layout), typeof(LayoutListbox), new PropertyMetadata(Layout.List));

    }

    public enum Layout
    {
        Tile,
        List
    }
}
