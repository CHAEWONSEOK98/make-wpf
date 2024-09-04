using KakaoStudy.LayoutSupport.UI.Units;
using System.Windows;

namespace KakaoStudy.Friends.Birth.UI.Units
{
    public class BirthdaysBox : FriendsBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new BirthdaysBoxItem();
        }
    }
}
