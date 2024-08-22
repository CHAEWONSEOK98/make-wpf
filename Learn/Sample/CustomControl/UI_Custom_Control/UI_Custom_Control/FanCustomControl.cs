using System.Windows;
using System.Windows.Controls;

namespace UI_Custom_Control
{
    public class FanCustomControl : Control
    {
        static FanCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FanCustomControl), new FrameworkPropertyMetadata(typeof(FanCustomControl)));
        }

        public bool FanOn
        {
            get { return (bool)GetValue(FanOnProperty); }
            set { SetValue(FanOnProperty, value); }
        }
        public static readonly DependencyProperty FanOnProperty =
            DependencyProperty.Register("FanOn", typeof(bool), typeof(FanCustomControl), new PropertyMetadata(false));


    }
}
