using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfDependencyInjectionNavigation.Services;
using WpfDependencyInjectionNavigation.Stores;
using WpfDependencyInjectionNavigation.ViewModels;
using WpfDependencyInjectionNavigation.Views;

namespace WpfDependencyInjectionNavigation
{
    public partial class App : Application
    {
        public new static App Current => (App)Application.Current;

        private IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Stores
            services.AddSingleton<MainNavigationStore>();

            // Services
            services.AddSingleton<INavigationService, NavigationService>();

            // ViewModels
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<SignupViewModel>();
            services.AddSingleton<TestViewModel>();

            // Views
            services.AddSingleton(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            return services.BuildServiceProvider();
        }

        public App()
        {
            Services = ConfigureServices();

            var mainView = Services.GetRequiredService<MainView>();
            mainView.Show();
        }

        public IServiceProvider Services { get; }
    }

}
