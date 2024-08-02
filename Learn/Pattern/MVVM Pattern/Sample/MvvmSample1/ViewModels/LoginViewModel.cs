using MvvmSample1.Commands;
using MvvmSample1.Models;
using System.Windows;
using System.Windows.Input;

namespace MvvmSample1.ViewModels
{
    internal class LoginViewModel : ViewModelBase
    {
        private User user;
        private string userName;

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            user = new User();
            LoginCommand = new RelayCommand((param) => LoggedIn(param));
        }

        public string UserName
        {
            get => user.UserName;
            set
            {
                user.UserName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        public string Password
        {
            get => user.Password;
            set
            {
                user.Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private void LoggedIn(object param)
        {
            MessageBox.Show($"Logged in Successful as {param}");
        }

    }
}
