using YouTubeViewers.Models;

namespace YouTubeViewers.Stores
{
    public class SelectedYouTubeViewerStore
    {
		private YouTubeViewer _selectedYouTubeViewer;

		public YouTubeViewer SelectedYouTubeViewer
        {
			get { return _selectedYouTubeViewer; }
			set 
			{ 
				_selectedYouTubeViewer = value;
				SelectedYouTubeViewerChanged?.Invoke();

            }
		}

		public event Action SelectedYouTubeViewerChanged;
	}
}
