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
        private readonly Lazy<AnimationManager> _slideAnimationLazy;
        private readonly Lazy<AnimationManager> _leftAnimationLazy;

        private AnimationManager SlideAnimation => _slideAnimationLazy.Value;

        private AnimationManager LeftAnimation => _leftAnimationLazy.Value;

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
            SizeChanged += SlidePanel_SizeChanged;

            _slideAnimationLazy = new Lazy<AnimationManager>(() =>
            {
                var animationManager = new AnimationManager(_slider!);
                animationManager.Storyboard.Completed += Storyboard_Completed;
                return animationManager;
            });
            _leftAnimationLazy = new Lazy<AnimationManager>(() => new AnimationManager(_slider!));
        }

        private void SlidePanel_Loaded(object sender, RoutedEventArgs e)
        {
            this.SendToBack();
            ChangeSliderLeft();
        }

        private void SlidePanel_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(SliderLocation == SliderLocation.Right)
            {
                if(_sliderState == SliderState.Opened || _sliderState == SliderState.Opening)
                {
                    LeftAnimation.SetLeftProperty(from: OpenedLeft, to: OpenedLeft, milliseconds: 0);
                    LeftAnimation.Begin();
                }
            }
        }

        private double OpenedLeft => SliderLocation == SliderLocation.Left ? 0 : ParentActualWidth - SliderWidth;

        private double ClosedLeft => SliderLocation == SliderLocation.Left ? -SliderWidth : ParentActualWidth;

        private (double from, double to) GetLeftRange()
        {
            if (_sliderState == SliderState.Opening)
            {
                return (from: ClosedLeft, to: OpenedLeft);
            }
            else
            {
                return (from: OpenedLeft, to: ClosedLeft);
            }
        }

        private void BeginAnimation()
        {
            (double from, double to) leftRange = GetLeftRange();
            SlideAnimation.SetLeftProperty(from: leftRange.from, to: leftRange.to, milliseconds: AnimationSpeed);
            SlideAnimation.Begin();
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
