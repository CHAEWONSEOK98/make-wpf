using System.Windows.Input;
using YouTubeViewers.Command;
using YouTubeViewers.Models;
using YouTubeViewers.Stores;

namespace YouTubeViewers.ViewModels
{
    public class EditYouTubeViewerViewModel : ViewModelBase
    {
        public YouTubeViewerDetailsFormViewModel YouTubeViewerDetailsFormViewModel { get; }

        public EditYouTubeViewerViewModel(YouTubeViewer youTubeViewer, ModalNavigationStore modalNavigationStore)
        {
            ICommand submitCommand = new AddYouTubeViewerCommand(modalNavigationStore);
            ICommand cancelCommand = new CloseModalCommand(modalNavigationStore);
            YouTubeViewerDetailsFormViewModel = new YouTubeViewerDetailsFormViewModel(submitCommand, cancelCommand)
            {
                Username = youTubeViewer.Username,
                IsSubscribed = youTubeViewer.IsSubscribed,
                IsMember = youTubeViewer.IsMember,
            };
        }
    }
}
