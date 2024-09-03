using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;

namespace KakaoStudy.Login.Local.ViewModels
{
    public partial class LoginContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public LoginContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        [RelayCommand]
        private void Login()
        {
            IRegion mainRegion = _regionManager.Regions["MainRegion"];
            IViewable friendsContent = _containerProvider.Resolve<IViewable>("FriendsContent");

            if (!mainRegion.Views.Contains(friendsContent))
            {
                mainRegion.Add(friendsContent);
            }

            mainRegion.Activate(friendsContent);
        }
    }
}
