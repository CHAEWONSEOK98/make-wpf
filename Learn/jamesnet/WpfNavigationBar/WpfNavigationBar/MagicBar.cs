using Jamesnet.Wpf.Animation;
using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace WpfNavigationBar
{
    public class MagicBar : ListBox
    {
        private ValueItem _vi;
        private Storyboard _sb;

        static MagicBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MagicBar), new FrameworkPropertyMetadata(typeof(MagicBar)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Grid circle = (Grid)GetTemplateChild("PART_Circle");

            InitStoryboard(circle);
        }

        private void InitStoryboard(Grid circle)
        {
            _vi = new();
            _sb = new();

            _vi.Mode = EasingFunctionBaseMode.QuinticEaseInOut;
            _vi.Property = new PropertyPath(Canvas.LeftProperty);
            _vi.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));

            Storyboard.SetTarget(_vi, circle);
            Storyboard.SetTargetProperty(_vi, _vi.Property);

            _sb.Children.Add(_vi);
        }

        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);

            _vi.To = SelectedIndex * 80;
            _sb.Begin();
        }
    }
}
