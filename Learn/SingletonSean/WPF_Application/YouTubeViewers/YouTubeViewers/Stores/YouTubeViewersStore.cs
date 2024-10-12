using YouTubeViewers.Models;

namespace YouTubeViewers.Stores
{
    public class YouTubeViewersStore
    {
        public event Action<YouTubeViewer>? YouTubeViewerAdded;
        public event Action<YouTubeViewer>? YouTubeViewerUpdated;

        public async Task Add(YouTubeViewer youTubeViewer)
        {
            YouTubeViewerAdded?.Invoke(youTubeViewer);
        }

        public async Task Update(YouTubeViewer youTubeViewer)
        {
            YouTubeViewerUpdated?.Invoke(youTubeViewer);
        }
    }
}
