using _05_PasswordBoxMVVM.ViewModels;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace _05_PasswordBoxMVVM.Commands
{
    public class LoginCommand : ICommand
    {
        private readonly LoginViewModel _viewModel;

        public LoginCommand(LoginViewModel viewModel)
        {
            _viewModel = viewModel;

            _viewModel.PropertyChanged += ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            CanExecuteChanged?.Invoke(this, new EventArgs());
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_viewModel.Username) &&
                !string.IsNullOrEmpty(_viewModel.Password);
        }

        public void Execute(object? parameter)
        {
            MessageBox.Show($"Username: {_viewModel.Username}\nPassword: {_viewModel.Password}", "Info",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
