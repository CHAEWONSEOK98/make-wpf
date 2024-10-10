﻿
using YouTubeViewers.Stores;

namespace YouTubeViewers.Command
{
    public class AddYouTubeViewerCommand : AsyncCommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public AddYouTubeViewerCommand(ModalNavigationStore navigationStore)
        {
            _modalNavigationStore = navigationStore;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            // Add YouTube Viewer to database

            _modalNavigationStore.Close();
        }
    }
}
