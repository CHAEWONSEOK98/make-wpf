using Jamesnet.Wpf.Controls;
using KakaoStudy.Forms.UI.Views;
using System.Windows;

namespace KakaoStudy
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new KakaoWindow();
        }
    }
}
