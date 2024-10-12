using YouTubeViewers.Models;
using YouTubeViewers.Stores;
using YouTubeViewers.ViewModels;

namespace YouTubeViewers.Command
{
    public class AddYouTubeViewerCommand : AsyncCommandBase
    {
        private readonly AddYouTubeViewerViewModel _addYouTubeViewerViewModel;
        private readonly YouTubeViewersStore _youTubeViewersStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public AddYouTubeViewerCommand(AddYouTubeViewerViewModel addYouTubeViewerViewModel, YouTubeViewersStore youTubeViewersStore, ModalNavigationStore navigationStore)
        {
            _addYouTubeViewerViewModel = addYouTubeViewerViewModel;
            _youTubeViewersStore = youTubeViewersStore;
            _modalNavigationStore = navigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            YouTubeViewerDetailsFormViewModel formViewModel = _addYouTubeViewerViewModel.YouTubeViewerDetailsFormViewModel;

            YouTubeViewer youTubeViewer = new YouTubeViewer(Guid.NewGuid(), formViewModel.Username, formViewModel.IsSubscribed, formViewModel.IsMember);
            
            try
            {
                await _youTubeViewersStore.Add(youTubeViewer);

                _modalNavigationStore.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
