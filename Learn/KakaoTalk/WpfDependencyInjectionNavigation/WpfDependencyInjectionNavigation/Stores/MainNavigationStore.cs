using System.ComponentModel;
using WpfDependencyInjectionNavigation.ViewModels;

namespace WpfDependencyInjectionNavigation.Stores
{
    public class MainNavigationStore : ViewModelBase
    {
		// MainView에 속성을 변경하는 기능을 추가

		private INotifyPropertyChanged? _currentViewModel;

		public INotifyPropertyChanged? CurrentViewModel
		{
			get { return _currentViewModel; }
			set 
			{
				_currentViewModel = value;
				CurrentViewModelChanged?.Invoke();
				_currentViewModel = null;
			}
		}

		public Action? CurrentViewModelChanged { get; set; }
	}
}
