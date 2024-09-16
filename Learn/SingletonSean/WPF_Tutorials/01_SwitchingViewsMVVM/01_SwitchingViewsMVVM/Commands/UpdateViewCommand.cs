using _01_SwitchingViewsMVVM.ViewModels;
using System.Windows.Input;

namespace _01_SwitchingViewsMVVM.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            Console.WriteLine("test");
            if (parameter.ToString() == "Home")
            {
                viewModel.SelectedViewModel = new HomeViewModel();
            }
            else if(parameter.ToString() == "Account")
            {
                viewModel.SelectedViewModel = new AccountViewModel();
            }
        }
    }
}
