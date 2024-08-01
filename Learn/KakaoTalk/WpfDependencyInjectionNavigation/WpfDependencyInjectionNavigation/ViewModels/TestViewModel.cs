using System.Windows.Input;
using WpfDependencyInjectionNavigation.Commands;
using WpfDependencyInjectionNavigation.Services;

namespace WpfDependencyInjectionNavigation.ViewModels
{
    class TestViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private void ToLogin(object _)
        {
            _navigationService.Navigate(NaviType.LoginView);
        }

        private void ToSignup(object _)
        {
            _navigationService.Navigate(NaviType.SignupView);
        }

        public TestViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ToLoginCommand = new RelayCommand<object>(ToLogin);
            ToSignupCommand = new RelayCommand<object>(ToSignup);
        }


        public ICommand ToLoginCommand { get; set; }

        public ICommand ToSignupCommand { get; set; }
    }
}
