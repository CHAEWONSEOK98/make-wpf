using PayloadNavigation.Core;
using PayloadNavigation.Services;

namespace PayloadNavigation.MVVM.ViewModels
{
    public class SettingViewModel : ViewModel
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

        public RelayCommand NavigateToHomeViewCommand { get; set; }

        public SettingViewModel(INavigationService navigation)
        {
            Navigation = navigation;
            NavigateToHomeViewCommand = new RelayCommand(execute => { Navigation.NavigateTo<HomeViewModel>(); }, canExecute => true);
        }
    }
}
