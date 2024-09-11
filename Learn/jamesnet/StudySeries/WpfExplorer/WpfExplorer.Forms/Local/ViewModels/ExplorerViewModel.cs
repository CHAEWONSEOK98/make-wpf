using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using System.Windows;
using WpfExplorer.Support.Local.Helpers;

namespace WpfExplorer.Forms.Local.ViewModels
{
    public partial class ExplorerViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerProvider;

        [ObservableProperty]
        private object _content;

        /*
         * WpfExplorer.Properties 에서 IModule을 상속받아서 containerRegistry.RegisterSingleton 속성을 사용하여 싱글톤으로 타입을 등록한다.
         * 예시) containerRegistry.RegisterSingleton<IViewalbe, MainContent>("MainContent");
         * 중앙에서 쓰려고 등록해둔 싱글톤을 불러오는 과정 필요.
         * prism에서 제공하는 싱글톤을 찾아내는 객체 IContainerProvider 사용.
         */
        public ExplorerViewModel(DirectoryManager directoryManager, IContainerProvider containerProvider)
        {
            _containerProvider = containerProvider;
        }

        /*
         * IViewLoadable : OnLoaded 실행하는 역할을 가진 인터페이스.
         * OnLoaded : ExplorerViewModel이 어떤 View와 바인딩 되어있는지 몰라도 그 View의 로드 시점을 OnLoaded 메서드가 호출된 곳에서 콜백해주는 역할.
         */
        public void OnLoaded(IViewable view)
        {
            IViewable main = _containerProvider.Resolve<IViewable>("MainContent");
            Content = main;
        }
    }
}
