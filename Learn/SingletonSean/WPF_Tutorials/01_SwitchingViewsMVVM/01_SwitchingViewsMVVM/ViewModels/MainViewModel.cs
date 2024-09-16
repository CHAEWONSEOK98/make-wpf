using _01_SwitchingViewsMVVM.Commands;
using System.Windows.Input;

namespace _01_SwitchingViewsMVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;

		public BaseViewModel SelectedViewModel
        {
			get { return _selectedViewModel; }
			set 
            { 
                _selectedViewModel = value;
                OnPrepertyChanged(nameof(SelectedViewModel));
            }
		}

		public ICommand UpdateViewCommand { get; set; }

        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
    }
}
