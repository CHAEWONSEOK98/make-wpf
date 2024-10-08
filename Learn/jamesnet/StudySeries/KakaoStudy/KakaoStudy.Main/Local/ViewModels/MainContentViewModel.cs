﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using KakaoStudy.Core.Models;
using KakaoStudy.Core.Names;
using Prism.Ioc;
using Prism.Regions;

namespace KakaoStudy.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase, IViewLoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        [ObservableProperty]
        private List<MenuModel> _menus;

        [ObservableProperty]
        private MenuModel _menu;

        public MainContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;

            Menus = GetMenus();
        }

        public void OnLoaded(IViewable smartWindow)
        {
            Menu = Menus[0];
        }

        private List<MenuModel> GetMenus()
        {
            List<MenuModel> source = new();
            source.Add(new MenuModel().DataGetn(ContentNameManager.Chats));
            source.Add(new MenuModel().DataGetn(ContentNameManager.Friends));
            source.Add(new MenuModel().DataGetn(ContentNameManager.More));

            return source;
        }

        partial void OnMenuChanged(MenuModel value)
        {
            IRegion contentRegion = _regionManager.Regions[RegionNameManager.ContentRegion];
            IViewable content = _containerProvider.Resolve<IViewable>(value.Id);

            if (!contentRegion.Views.Contains(content))
            {
                contentRegion.Add(content);
            }
            contentRegion.Activate(content);
        }

        //[RelayCommand]
        //private void Chats()
        //{
        //    IRegion contentRegion = _regionManager.Regions[RegionNameManager.ContentRegion];
        //    IViewable ChatsContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Chats);

        //    if (!contentRegion.Views.Contains(ChatsContent))
        //    {
        //        contentRegion.Add(ChatsContent);
        //    }
        //    contentRegion.Activate(ChatsContent);
        //}

        //[RelayCommand]
        //private void Friends()
        //{
        //    IRegion contentRegion = _regionManager.Regions[RegionNameManager.ContentRegion];
        //    IViewable friendsContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Friends);

        //    if (!contentRegion.Views.Contains(friendsContent))
        //    {
        //        contentRegion.Add(friendsContent);
        //    }
        //    contentRegion.Activate(friendsContent);
        //}

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
