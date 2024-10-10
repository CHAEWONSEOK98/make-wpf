using System.Windows.Input;
using YouTubeViewers.Command;
using YouTubeViewers.Stores;

namespace YouTubeViewers.ViewModels
{
    public class AddYouTubeViewerViewModel : ViewModelBase
    {
        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }

        public AddYouTubeViewerViewModel(ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = null;
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel(submitCommand, cancelCommand);
        }
    }
}
