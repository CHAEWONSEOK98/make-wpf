using YouTubeViewers.Stores;

namespace YouTubeViewers.Command
{
    public class CloseModalCommand : CommandBase
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public CloseModalCommand(ModalNavigationStore navigationStore)
        {
            _modalNavigationStore = navigationStore;
        }

        public override void Execute(object? parameter)
        {
            _modalNavigationStore.Close();
        }
    }
}
