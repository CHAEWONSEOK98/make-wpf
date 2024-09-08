using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Forms.UI.Views
{
    public class ExplorerWinodw : Window
    {
        static ExplorerWinodw()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExplorerWinodw), new FrameworkPropertyMetadata(typeof(ExplorerWinodw)));
        }
    }
}
