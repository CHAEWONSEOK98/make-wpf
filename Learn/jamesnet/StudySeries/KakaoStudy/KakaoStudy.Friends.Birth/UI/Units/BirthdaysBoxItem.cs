using System.Windows;
using System.Windows.Controls;

namespace KakaoStudy.Friends.Birth.UI.Units
{
    public class BirthdaysBoxItem : ListBoxItem
    {
        static BirthdaysBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BirthdaysBoxItem), new FrameworkPropertyMetadata(typeof(BirthdaysBoxItem)));
        }
    }
}
