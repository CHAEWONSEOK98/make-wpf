using System.Windows;
using System.Windows.Controls;

namespace KakaoStudy.Main.UI.Units
{
    public class VerticalMenuList : ListBox
    {
        static VerticalMenuList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VerticalMenuList), new FrameworkPropertyMetadata(typeof(VerticalMenuList)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new VerticalMenuListItem();
        }
    }
}
