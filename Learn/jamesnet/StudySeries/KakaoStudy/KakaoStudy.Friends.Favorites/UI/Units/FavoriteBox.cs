using KakaoStudy.LayoutSupport.UI.Units;
using System.Windows;

namespace KakaoStudy.Friends.Favorites.UI.Units
{
    public class FavoriteBox : FriendsBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new FavoriteBoxItem();
        }
    }
}
