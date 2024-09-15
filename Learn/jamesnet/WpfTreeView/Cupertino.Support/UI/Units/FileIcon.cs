using System.Windows;
using System.Windows.Controls;

namespace Cupertino.Support.UI.Units
{
    public class FileIcon : Control
    {


        public string Extension
        {
            get { return (string)GetValue(ExtensionProperty); }
            set { SetValue(ExtensionProperty, value); }
        }
        public static readonly DependencyProperty ExtensionProperty =
            DependencyProperty.Register("Extension", typeof(string), typeof(FileIcon), new PropertyMetadata(null));



        // 아이콘들이 서로 다른 타입이라서 Type에 따라 바인딩이 필요하다 -> 그래서 의존성 속성을 만드는 것이다.
        public string Type
        {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }
        public static readonly DependencyProperty TypeProperty =
            DependencyProperty.Register("Type", typeof(string), typeof(FileIcon), new PropertyMetadata(null));



        static FileIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FileIcon), new FrameworkPropertyMetadata(typeof(FileIcon)));
        }
    }
}
