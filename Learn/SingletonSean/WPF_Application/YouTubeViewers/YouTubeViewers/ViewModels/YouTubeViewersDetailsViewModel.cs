namespace YouTubeViewers.ViewModels
{
    public class YouTubeViewersDetailsViewModel : ViewModelBase
    {
        public string Username { get; }

        public string IsSubscribedDisplay { get; }

        public string IsMemberDisplay { get; }

        public YouTubeViewersDetailsViewModel()
        {
            Username = "SingletonSean";
            IsSubscribedDisplay = "Yes";
            IsMemberDisplay = "No";
        }
    }
}
