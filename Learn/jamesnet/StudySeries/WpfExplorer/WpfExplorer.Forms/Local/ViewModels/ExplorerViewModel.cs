using CommunityToolkit.Mvvm.ComponentModel;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;
using WpfExplorer.Support.Local.Helpers;

namespace WpfExplorer.Forms.Local.ViewModels
{
    public partial class ExplorerViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        [ObservableProperty]
        private object _content;

        /*
         * WpfExplorer.Properties 에서 IModule을 상속받아서 containerRegistry.RegisterSingleton 속성을 사용하여 싱글톤으로 타입을 등록한다.
         * 예시) containerRegistry.RegisterSingleton<IViewalbe, MainContent>("MainContent");
         * 중앙에서 쓰려고 등록해둔 싱글톤을 불러오는 과정 필요.
         * prism에서 제공하는 싱글톤을 찾아내는 객체 IContainerProvider 사용.
         * 
         * ExplorerWindow.xaml 에서 사용한 <james:JamesRegion RegionName="MainContent"/> Region이 IRegionManager에 등록이 되어 있다.
         */
        public ExplorerViewModel(DirectoryManager directoryManager, IContainerProvider containerProvider, IRegionManager regionManager)
        {
            _containerProvider = containerProvider;
            _regionManager = regionManager;
        }

        /*
         * IViewLoadable : OnLoaded 실행하는 역할을 가진 인터페이스.
         * OnLoaded : ExplorerViewModel이 어떤 View와 바인딩 되어있는지 몰라도 그 View의 로드 시점을 OnLoaded 메서드가 호출된 곳에서 콜백해주는 역할.
         * 
         * IRegionManager: IRegionManager에 등록되어 있는 Region을 IRegion mainRegion = _regionManager.Regions["MainRegion"]; 이와 같은 형식으로 찾을 수 있다.
         * <ContentControl Content="{Binding Content}"/> -> ContentControl을 사용하여 view를 추가할 수 있지만
         * region에도 view를 추가할 수 있다. -> 내부적으로 ContentControl이 있고, 그 안에 어떤 것을 추가하는 과정인데 IRegion을 쓰는 것은 객체화 시켜서 콜렉션을 가지고 있는 것
         * 탭처럼 여러가지 객체를 가지고 있다가 특정 view를 activate 시켜주는 기능이 있다.
         * 모든 view들이 Views에 담긴다.
         * 
         * ContentControl을 사용하여 view를 추가하는 과정.
         * [ObservableProperty] private object _content;
         * _containerProvider = containerProvider;
         * IViewable main = _containerProvider.Resolve<IViewable>("MainContent");
         * Content = main
         * ExplorerWindow.xaml 에서 <ContentControl Content="{Binding Content}"/> 바인딩.
         * 
         */
        public void OnLoaded(IViewable view)
        {
            IViewable main = _containerProvider.Resolve<IViewable>("MainContent");
            IRegion mainRegion = _regionManager.Regions["MainRegion"];

            // 모든 view들은 Views에 담겨 있으니, view가 담겨있지 않은 경우에만 view를 추가해준다.
            if (!mainRegion.Views.Contains(main))
            {
                mainRegion.Add(main);
            }
            mainRegion.Activate(main);
        }
    }
}
