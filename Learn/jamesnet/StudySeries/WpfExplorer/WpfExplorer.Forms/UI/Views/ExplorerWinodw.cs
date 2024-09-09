using System.Windows;
using WpfExplorer.Forms.Local.ViewModels;
using WpfExplorer.Support.UI.Units;

namespace WpfExplorer.Forms.UI.Views
{
    public class ExplorerWinodw : DarkWindow
    {
        static ExplorerWinodw()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExplorerWinodw), new FrameworkPropertyMetadata(typeof(ExplorerWinodw)));
        }
    }
}
