using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace KakaoStudy.Properties
{
    internal class DirectModules : IModule
    {
        /// <summary>
        /// Resolve : 역할은? Prism에서 Resolve를 통해 이미 관리되고 있는 인스턴스 객체가 있다면 가져올 수 있고, 아니면 바로 생성하고 관리함.
        /// RegionManager : 내부적으로 Region들을 관리.
        /// 
        /// RegisterViewWithRegion(메소드) : View 주입을 지원해서 태어날 때 추가가 된다고 생각.
        /// regionManager.RegisterViewWithRegion("MainRegion", "LoginContent") : MainRegion이 생성되는 과정에서 LoginContent를 집어 넣어 준다.
        /// </summary>
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //IRegionManager regionManager = containerProvider.Resolve<IRegionManager>();
            //regionManager.RegisterViewWithRegion("MainRegion", "LoginContent");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
