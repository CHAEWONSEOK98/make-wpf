using Microsoft.Extensions.DependencyInjection;
using PayloadNavigation.Core;
using PayloadNavigation.MVVM.ViewModels;
using PayloadNavigation.MVVM.Views;
using PayloadNavigation.Services;
using System.Windows;

namespace PayloadNavigation
{
    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<MainView>(provider => new MainView
            {
                DataContext = provider.GetRequiredService<MainViewModel>()
            });
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<HomeViewModel>();
            services.AddSingleton<SettingViewModel>();
            services.AddSingleton<INavigationService, NavigationService>();

            services.AddSingleton<Func<Type, ViewModel>>(serviceProvider => viewModelType => (ViewModel)serviceProvider.GetRequiredService(viewModelType));

            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var mainView = _serviceProvider.GetRequiredService<MainView>();
            mainView.Show();

            base.OnStartup(e);
        }

    }

}
