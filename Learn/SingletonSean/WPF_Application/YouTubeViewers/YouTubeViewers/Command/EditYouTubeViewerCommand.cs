using YouTubeViewers.Stores;

namespace YouTubeViewers.Command
{
    public class EditYouTubeViewerCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public EditYouTubeViewerCommand(ModalNavigationStore navigationStore)
        {
            _modalNavigationStore = navigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            // Edit YouTube Viewer to database

            _modalNavigationStore.Close();
        }
    }
}
