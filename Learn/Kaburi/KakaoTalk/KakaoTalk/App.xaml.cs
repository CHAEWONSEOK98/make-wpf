using KakaoTalk.ViewModels;
using KakaoTalk.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace KakaoTalk
{
    public partial class App : Application
    {
        public App()
        {
            Services = ConfigureServices();
            Startup += App_Startup;
        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            var mainView = App.Current.Services.GetService<MainView>()!;
            mainView.Show();
        }

        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // ViewModels
            services.AddTransient<MainViewModel>();
            services.AddTransient<LoginControlViewModel>();
            services.AddTransient<SignupControlViewModel>();
            services.AddTransient<ChangePwdControlViewModel>();

            // Service
            // services.AddSingleton<ITestService, TestService>();

            // Views
            services.AddSingleton<MainView>();

            //services.AddSingleton<IFilesService, FilesService>();
            //services.AddSingleton<ISettingsService, SettingsService>();
            //services.AddSingleton<IClipboardService, ClipboardService>();
            //services.AddSingleton<IShareService, ShareService>();
            //services.AddSingleton<IEmailService, EmailService>();

            return services.BuildServiceProvider();
        }
    }

}
