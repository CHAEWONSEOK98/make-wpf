using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Cupertino.Support.UI.Units
{
    public class MagicStackPanel : StackPanel
    {
        private SolidColorBrush color1 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
        private SolidColorBrush color2 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EEEEEE"));

        // ItemHeight 속성 값이 변할 때 교차 배경 처리가 필요해서 Callback 메서드가 필요
        public double ItemHeight
        {
            get { return (double)GetValue(ItemHeightProperty); }
            set { SetValue(ItemHeightProperty, value); }
        }
        public static readonly DependencyProperty ItemHeightProperty =
            DependencyProperty.Register("ItemHeight", typeof(double), typeof(MagicStackPanel), new PropertyMetadata(0.0, ItemHeightPropertyChanged));

        private static void ItemHeightPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // ItemHeightPropertyChanged 메서드에서 MagicStackPanel 접근하기 위해서는 전달받은 DependencyObject 타입의 매개변수 d를 MagicStackPanel 타입으로 변환한 다음 작업.
            MagicStackPanel panel = (MagicStackPanel)d;

            // MagicStackPanel의 높이를 ItemHeight 속성 값으로 설정
            // 이렇게 하면 Panel의 높이가 ItemHeight에 따라 동적으로 조정될 수 있다.
            panel.Children.Clear();
            panel.Height = panel.ItemHeight;

            int index = (int)panel.ItemHeight / 36;

            for(int i = 0; i < index; i++)
            {
                Border border = new();
                border.Height = 36;
                border.Background = i % 2 == 0 ? panel.color1 : panel.color2;
                panel.Children.Add(border);
            }
        }
    }
}
