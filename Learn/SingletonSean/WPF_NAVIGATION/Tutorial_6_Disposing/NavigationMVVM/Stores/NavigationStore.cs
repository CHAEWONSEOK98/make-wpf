using NavigationMVVM.ViewModels;

namespace NavigationMVVM.Stores
{
    public class NavigationStore
    {
        public event Action CurrrentViewModelChanged;

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

        private void OnCurrentViewModelChanged()
        {
            CurrrentViewModelChanged?.Invoke();
        }
    }
}
