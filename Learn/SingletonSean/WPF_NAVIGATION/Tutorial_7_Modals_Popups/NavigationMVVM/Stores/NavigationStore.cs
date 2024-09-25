using NavigationMVVM.ViewModels;

namespace NavigationMVVM.Stores
{
    public class NavigationStore
    {
		private ViewModelBase _currentViewModel;

		public ViewModelBase CurrentViewModel
        {
			get => _currentViewModel;
            set
			{
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
		}

        public event Action CurrrentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            CurrrentViewModelChanged?.Invoke();
        }
    }
}
