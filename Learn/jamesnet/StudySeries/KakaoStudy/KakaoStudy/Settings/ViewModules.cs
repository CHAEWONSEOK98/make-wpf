using Jamesnet.Wpf.Controls;
using KakaoStudy.Core.Names;
using KakaoStudy.Friends.UI.Views;
using KakaoStudy.Login.UI.Views;
using KakaoStudy.Main.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace KakaoStudy.Settings
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        /// <summary>
        /// Prism을 통해 UI객체들을 등록 시켜 놓은 후 Forms, Login 등등 독립적으로 참조를 걸지 않아도 다른 뷰를 가져와서 사용하는 기능.
        /// 다른 기능과 역할도 있지만 지금은 시작하는 단계이므로 위의 설명에 집중.
        /// 
        /// containerRegistry : Singleton으로 관리하고 싶은 객체를 넣음.
        /// 
        /// UI, 만들고자 하는 Class, Helper 등 IoC 주입을 해서 ViewModel이나 어디서든 쓸 수 있도록 하기 위한 인스턴스 등록
        /// containerRegistry.RegisterSingleton : RegisterSingleton의 경우 type만 등록해놓고, 사용되는 순간에 인스턴스 객체가 생성됨.
        /// containerRegistry.RegisterInstance : RegisterInstance의 경우 지금 생성한다.
        /// 
        /// containerRegistry.RegisterSingleton<LoginContent>();
        /// 위와 같이 타입을 설정해도 된다. 그러나 다른 곳에서 불러서 사용할 때, LoginContent을 상속해서 사용해야 하는 부작용이 있다.
        /// 이때 LoginContent 부분이 코어 라이브러리라서 어디서든 사용되면 문제 없지만 로그인 부분에서만 사용되는 부분이므로 모든 부분에서 상속하여 사용하기에는 문제가 있다.
        /// 그래서 LoginContent는 JamesContent를 상속받은 것이고, JamesContent은 ContentControl, IViewable 를 상속 받는다. 아래와 같이 사용한다.
        /// containerRegistry.RegisterSingleton<IViewable, LoginContent>(); IViewable은 타입이고, LoginContent은 실제 객체다.
        /// 
        /// 결과적으로 Prism Application 돌고 있는 window에서는 어디서든 "LoginContent"라는 문자열 하나만으로도 IViewable을 상속받는 LoginContent를 땡겨올 수 있다.
        /// </summary>
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, LoginContent>(ContentNameManager.Login);
            containerRegistry.RegisterSingleton<IViewable, MainContent>(ContentNameManager.Main);
            containerRegistry.RegisterSingleton<IViewable, FriendsContent>(ContentNameManager.Friends);
        }
    }
}
