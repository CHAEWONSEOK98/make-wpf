using System.Windows;
using System.Windows.Controls;

namespace AnalogClock.CustomControls
{
    public partial class ControllableClock : UserControl
    {
        public Clock Clock
        {
            get { return (Clock)GetValue(ClockProperty); }
            set { SetValue(ClockProperty, value); }
        }

        public static readonly DependencyProperty ClockProperty =
            DependencyProperty.Register("Clock", typeof(Clock), typeof(ControllableClock), new PropertyMetadata(null));

        public ControllableClock()
        {
            InitializeComponent();
        }
    }
}
