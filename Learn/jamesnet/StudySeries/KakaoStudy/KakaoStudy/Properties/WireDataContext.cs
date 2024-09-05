using Jamesnet.Wpf.Global.Location;
using KakaoStudy.Chats.Local.ViewModels;
using KakaoStudy.Chats.UI.Views;
using KakaoStudy.Forms.Local.ViewModels;
using KakaoStudy.Forms.UI.Views;
using KakaoStudy.Friends.Local.ViewModels;
using KakaoStudy.Friends.UI.Views;
using KakaoStudy.Login.Local.ViewModels;
using KakaoStudy.Login.UI.Views;
using KakaoStudy.Main.Local.ViewModels;
using KakaoStudy.Main.UI.Views;
using KakaoStudy.More.Local.ViewModels;
using KakaoStudy.More.UI.Views;
using KakaoStudy.Talk.Local.ViewModels;
using KakaoStudy.Talk.UI.Views;

namespace KakaoStudy.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        /// <summary>
        /// View와 ViewModel을 연결하는 클래스.
        /// 
        /// LoginContent가 생성되었을 때 지금 시나리오가 있으면 ViewModel을 생성해서 DataContext에 바인딩하겠다는 시나리오로 생각.
        /// </summary>
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<KakaoWindow, KakaoViewModel>();
            items.Register<LoginContent, LoginContentViewModel>();
            items.Register<MainContent, MainContentViewModel>();
            items.Register<FriendsContent, FriendsContentViewModel>();
            items.Register<ChatsContent, ChatsContentViewModel>();
            items.Register<MoreContent, MoreContentViewModel>();
            items.Register<TalkWindow, TalkViewModel>();
        }
    }
}
