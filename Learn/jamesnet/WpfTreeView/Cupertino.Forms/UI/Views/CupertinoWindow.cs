using Cupertino.Forms.Local.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace Cupertino.Forms.UI.Views
{
    public class CupertinoWindow : Window
    {
        static CupertinoWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CupertinoWindow), new FrameworkPropertyMetadata(typeof(CupertinoWindow)));
        }

        public CupertinoWindow()
        {
            DataContext = new CupertinoWindowViewModel();
        }
    }
}
