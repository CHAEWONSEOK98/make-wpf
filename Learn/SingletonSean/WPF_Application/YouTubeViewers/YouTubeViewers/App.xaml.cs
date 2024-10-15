using Microsoft.EntityFrameworkCore;
using System.Windows;
using YouTubeViewers.Domain.Commands;
using YouTubeViewers.Domain.Queries;
using YouTubeViewers.EntityFramework;
using YouTubeViewers.EntityFramework.Commands;
using YouTubeViewers.EntityFramework.Queries;
using YouTubeViewers.Stores;
using YouTubeViewers.ViewModels;

namespace YouTubeViewers
{
    public partial class App : Application
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        private readonly YouTubeViewersDbContextFactory _youTubeViewersDbContextFactory;
        private readonly IGetAllYouTubeViewersQuery _getAllYouTubeViewersQuery;
        private readonly ICreateYouTubeViewerCommand _createYouTubeViewerCommand;
        private readonly IUpdateYouTubeViewerCommand _updateYouTubeViewerCommand;
        private readonly IDeleteYouTubeViewerCommand _deleteYouTubeViewerCommand;

        private readonly YouTubeViewersStore _youTubeViewersStore;
        private readonly SelectedYouTubeViewerStore _selectedYouTubeViewerStore;

        public App()
        {
            string connectionString = "Data Source=YouTubeViewers.db";

            _modalNavigationStore = new ModalNavigationStore();

            _youTubeViewersDbContextFactory = new YouTubeViewersDbContextFactory
                (
                new DbContextOptionsBuilder().UseSqlite(connectionString).Options
                );
            _getAllYouTubeViewersQuery = new GetAllYouTubeViewersQuery(_youTubeViewersDbContextFactory);
            _createYouTubeViewerCommand = new CreateYouTubeViewerCommand(_youTubeViewersDbContextFactory);
            _updateYouTubeViewerCommand = new UpdateYouTubeViewerCommand(_youTubeViewersDbContextFactory);
            _deleteYouTubeViewerCommand = new DeleteYouTubeViewerCommand(_youTubeViewersDbContextFactory);

            _youTubeViewersStore = new YouTubeViewersStore(
                _getAllYouTubeViewersQuery,
                _createYouTubeViewerCommand,
                _updateYouTubeViewerCommand,
                _deleteYouTubeViewerCommand);

            _selectedYouTubeViewerStore = new SelectedYouTubeViewerStore(_youTubeViewersStore);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            using(YouTubeViewersDbContext context = _youTubeViewersDbContextFactory.Create())
            {
                context.Database.Migrate();
            }

            YouTubeViewersViewModel youTubeViewersViewModel = new YouTubeViewersViewModel(
                _youTubeViewersStore, _selectedYouTubeViewerStore, _modalNavigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modalNavigationStore, youTubeViewersViewModel)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
