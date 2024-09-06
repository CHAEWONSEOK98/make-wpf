using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using KakaoStudy.Core.Models;
using KakaoStudy.Core.Names;
using KakaoStudy.Core.Talking;
using KakaoStudy.Talk.UI.Views;
using Prism.Ioc;
using Prism.Regions;

namespace KakaoStudy.Friends.Local.ViewModels
{
    public partial class FriendsContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        private readonly TalkWindowManager _talkWindowManager;

        [ObservableProperty]
        private List<FriendsModel> _favorites;

        public FriendsContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider, TalkWindowManager talkWindowManager)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
            _talkWindowManager = talkWindowManager;

            Favorites = GetFavorites();
        }

        private List<FriendsModel> GetFavorites()
        {
            List<FriendsModel> source = new();
            source.Add(new FriendsModel().DataGen(1, "James"));
            source.Add(new FriendsModel().DataGen(2, "Vicky"));
            source.Add(new FriendsModel().DataGen(3, "Harry"));

            return source;
        }

        [RelayCommand]
        private void DoubleClick(FriendsModel data)
        {
            TalkWindow talkWindow = _talkWindowManager.ResolveWindow<TalkWindow>(data.Id);
            talkWindow.Title = data.Name;
            talkWindow.Width = 360;
            talkWindow.Height = 500;

            talkWindow.Show();
        }

        [RelayCommand]
        private void Logout()
        {
            IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
            IViewable loginContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Login);

            if (!mainRegion.Views.Contains(loginContent))
            {
                mainRegion.Add(loginContent);
            }
            mainRegion.Activate(loginContent);
        }
    }
}
