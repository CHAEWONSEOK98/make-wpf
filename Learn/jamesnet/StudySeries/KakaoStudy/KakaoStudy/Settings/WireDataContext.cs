using Jamesnet.Wpf.Global.Location;
using KakaoStudy.Login.Local.ViewModels;
using KakaoStudy.Login.UI.Views;

namespace KakaoStudy.Settings
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
            items.Register<LoginContent, LoginContentViewModel>();
        }
    }
}
