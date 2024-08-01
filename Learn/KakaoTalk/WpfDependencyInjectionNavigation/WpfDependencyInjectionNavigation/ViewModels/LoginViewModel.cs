using System;
using System.Collections.Generic;
using System.Windows.Input;
using WpfDependencyInjectionNavigation.Commands;
using WpfDependencyInjectionNavigation.Services;

namespace WpfDependencyInjectionNavigation.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private void ToSignup(object _)
        {
            _navigationService.Navigate(NaviType.SignupView);
        }

        private void ToTest(object _)
        {
            _navigationService.Navigate(NaviType.TestView);
        }

        public LoginViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ToSignupCommand = new RelayCommand<object>(ToSignup);
            ToTestCommand = new RelayCommand<object>(ToTest);
        }


        public ICommand ToSignupCommand { get; set; }

        public ICommand ToTestCommand { get; set; }
    }
}
