using Jamesnet.Wpf.Controls;
using KakaoStudy.Core.Talking;
using KakaoStudy.Forms.UI.Views;
using Prism.Ioc;
using System.Windows;

namespace KakaoStudy
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new KakaoWindow();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterTypes(containerRegistry);

            containerRegistry.RegisterInstance<TalkWindowManager>(new TalkWindowManager());
            containerRegistry.RegisterInstance<ChatStorage>(new ChatStorage());
        }
    }
}
