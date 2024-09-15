using System.Windows;
using System.Windows.Controls;

namespace Cupertino.Support.UI.Units
{
    public class CupertinoTreeView : TreeView
    {
        static CupertinoTreeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CupertinoTreeView), new FrameworkPropertyMetadata(typeof(CupertinoTreeView)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new CupertinoTreeItem();
        }
    }
}
