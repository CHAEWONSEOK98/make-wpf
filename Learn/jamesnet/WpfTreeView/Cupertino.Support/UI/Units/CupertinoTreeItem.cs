using Cupertino.Support.Local.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Cupertino.Support.UI.Units
{
    public class CupertinoTreeItem : TreeViewItem
    {

        // 데이터 확인 후(DataContext is FileItem item), MVVM 모델에서 사용하기 위해 TreeItem에 ICommand 타입의 Command를 만든다.
        // 그리고 SelectionCommand는 TreeItem 노드를 선택할 때 Execute 메서드를 통해 실행되게 하면 된다.
        public ICommand SelectionCommand
        {
            get { return (ICommand)GetValue(SelectionCommandProperty); }
            set { SetValue(SelectionCommandProperty, value); }
        }
        public static readonly DependencyProperty SelectionCommandProperty =
            DependencyProperty.Register("SelectionCommand", typeof(ICommand), typeof(CupertinoTreeItem), new PropertyMetadata(null));



        static CupertinoTreeItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CupertinoTreeItem), new FrameworkPropertyMetadata(typeof(CupertinoTreeItem)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new CupertinoTreeItem();
        }

        public CupertinoTreeItem()
        {
            MouseLeftButtonUp += CupertinoTreeItem_MouseLeftButtonUp;
        }

        private void CupertinoTreeItem_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // 버블링 이벤트 막기
            e.Handled = true;

            // 마우스 클릭 시, 클릭된 UI 요소의 DataContext가 FileItem 값에 바인딩되어 있다면 그것을 선택된 TreeViewItem 항목으로 간주
            if(DataContext is FileItem item)
            {
                SelectionCommand?.Execute(item);
            }
        }
    }
}
