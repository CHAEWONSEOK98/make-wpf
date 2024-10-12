using System.Windows.Input;
using YouTubeViewers.Command;
using YouTubeViewers.Models;
using YouTubeViewers.Stores;

namespace YouTubeViewers.ViewModels
{
    public class YouTubeViewersListingItemViewModel : ViewModelBase
    {
        private YouTubeViewersStore youTubeViewersStore;
        private ModalNavigationStore modalNavigationStore;

        public YouTubeViewer YouTubeViewer { get; private set; }

        public string Username => YouTubeViewer.Username;

        public ICommand EditCommand { get; }

        public ICommand DeleteCommand { get; }

        public YouTubeViewersListingItemViewModel(YouTubeViewer youTubeViewer, YouTubeViewersStore youTubeViewersStore, ModalNavigationStore modalNavigationStore)
        {
            YouTubeViewer = youTubeViewer;

            EditCommand = new OpenEditYouTubeViewerCommand(this, youTubeViewersStore, modalNavigationStore);
        }

        public void Update(YouTubeViewer youTubeViewer)
        {
            YouTubeViewer = youTubeViewer;

            OnPropertyChanged(nameof(Username));
        }
    }
}
 