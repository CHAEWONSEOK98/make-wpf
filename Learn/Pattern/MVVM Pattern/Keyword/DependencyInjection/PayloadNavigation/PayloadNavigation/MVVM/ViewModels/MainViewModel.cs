using PayloadNavigation.Core;
using PayloadNavigation.Services;

namespace PayloadNavigation.MVVM.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private INavigationService _navigation;

        public INavigationService Navigation
        {
            get => _navigation;
            set
            {
                _navigation = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand NavigateToHomeCommand { get; set; }
        public RelayCommand NavigateToSettingCommand { get; set; }


        public MainViewModel(INavigationService navigation)
        {
            Navigation = navigation;
            NavigateToHomeCommand = new RelayCommand(execute => { Navigation.NavigateTo<HomeViewModel>(); }, canExecute => true);
            NavigateToSettingCommand = new RelayCommand(execute => { Navigation.NavigateTo<SettingViewModel>(); }, canExecute => true);
        }
    }
}
