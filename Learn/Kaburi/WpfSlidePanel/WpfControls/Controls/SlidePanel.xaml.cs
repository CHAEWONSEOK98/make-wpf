using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using WpfControls.Utils;

namespace WpfControls.Controls
{
    public partial class SlidePanel : UserControl
    {
        private Border? _slider;
        private SliderState _sliderState = SliderState.Closed;

        public static readonly DependencyProperty SliderLocationProperty =
            DependencyProperty.Register("SliderLocation", typeof(SliderLocation), typeof(SlidePanel), new PropertyMetadata(SliderLocation.Left, OnSliderChanged));

        private static void OnSliderChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is SlidePanel sliderPanel)
            {
                sliderPanel.ChangeSliderLeft();
            }
        }

        public SliderLocation SliderLocation
        {
            get { return (SliderLocation)GetValue(SliderLocationProperty); }
            set { SetValue(SliderLocationProperty, value); }
        }

        public static readonly DependencyProperty SliderWidthProperty = 
            DependencyProperty.Register("SliderWidth", typeof(double), typeof(SlidePanel), new PropertyMetadata(300d, OnSliderChanged));

        public double SliderWidth
        {
            get { return (double)GetValue(SliderWidthProperty); }
            set { SetValue(SliderWidthProperty, value); }
        }

        public double AnimationSpeed { get; set; } = 300d;

        //새로운 템플릿이 컨트롤에 적용될 때 마다 호출되는 메소드
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _slider = (Border)GetTemplateChild("slider");
        }

        public double ParentActualWidth
        {
            get
            {
                var parent = Parent as FrameworkElement;
                return parent != null ? parent.ActualWidth : 0;
            }
        }

        private void ChangeSliderLeft()
        {
            if(_slider != null)
            {
                double left = SliderLocation == SliderLocation.Left ? -SliderWidth : ParentActualWidth;
                Canvas.SetLeft(_slider, left);
            }
        }

        public SlidePanel()
        {
            InitializeComponent();
            Loaded += SlidePanel_Loaded;
        }

        private void SlidePanel_Loaded(object sender, RoutedEventArgs e)
        {
            this.SendToBack();
            ChangeSliderLeft();
        }

        private (double from, double to) GetLeftRange()
        {
            if(SliderLocation == SliderLocation.Left)
            {
                if (_sliderState == SliderState.Opening)
                {
                    return (from: -SliderWidth, to: 0);
                }
                else
                {
                    return (from: 0, to: -SliderWidth);
                }
            }
            else
            {
                if (_sliderState == SliderState.Opening)
                {
                    return (from: ParentActualWidth, to: ParentActualWidth - SliderWidth);
                }
                else
                {
                    return (from: ParentActualWidth - SliderWidth, to: ParentActualWidth);
                }
            }
        }

        private void BeginAnimation()
        {
            var leftRange = GetLeftRange();
            Storyboard storyboard = _slider!.CreateLeftPropertyStoryboard(from: leftRange.from, to: leftRange.to, milliseconds: AnimationSpeed);
            storyboard.Completed += Storyboard_Completed;
            storyboard.Begin();
        }

        public void Open()
        {
            if (_sliderState != SliderState.Closed) return;

            _sliderState = SliderState.Opening;
            BeginAnimation();
            this.BringToFront();
        }

        public void Close()
        {
            if (_sliderState != SliderState.Opened) return;

            _sliderState = SliderState.Closing;
            BeginAnimation();
        }

        private void Storyboard_Completed(object? sender, EventArgs e)
        {
            if(_sliderState == SliderState.Opening)
            {
                _sliderState = SliderState.Opened;
            }
            else
            {
                _sliderState = SliderState.Closed;
                this.SendToBack();
            }
        }

        private void opacityGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
