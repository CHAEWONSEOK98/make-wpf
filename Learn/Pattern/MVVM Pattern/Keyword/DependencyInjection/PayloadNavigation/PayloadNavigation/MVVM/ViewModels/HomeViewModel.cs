using PayloadNavigation.Core;
using PayloadNavigation.Services;

namespace PayloadNavigation.MVVM.ViewModels
{
    public class HomeViewModel : ViewModel
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

        public RelayCommand NavigateToSettingViewCommand { get; set; }

        public HomeViewModel(INavigationService navigation)
        {
            Navigation = navigation;
            NavigateToSettingViewCommand = new RelayCommand(execute => { Navigation.NavigateTo<SettingViewModel>(); }, canExecute => true);
        }
    }
}
