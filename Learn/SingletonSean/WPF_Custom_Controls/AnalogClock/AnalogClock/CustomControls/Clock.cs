using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AnalogClock.CustomControls
{
    [TemplateVisualState(Name = "Day", GroupName = "TimeStates")]
    [TemplateVisualState(Name = "Night", GroupName = "TimeStates")]
    [TemplateVisualState(Name = "Christmas", GroupName = "TimeStates")]
    public class Clock : Control
    {
        public static readonly DependencyProperty TimeProperty = DependencyProperty.Register("Time", typeof(DateTime), typeof(Clock), new PropertyMetadata(DateTime.Now));
        public static DependencyProperty ShowSecondsProperty = DependencyProperty.Register("ShowSeconds", typeof(bool), typeof(Clock), new PropertyMetadata(true));
        public static RoutedEvent TimeChangedEvent = EventManager.RegisterRoutedEvent("TimeChanged", RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<DateTime>), typeof(Clock));

        public DateTime Time
        {
            get { return (DateTime)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }

        public bool ShowSeconds
        {
            get { return (bool)GetValue(ShowSecondsProperty); }
            set { SetValue(ShowSecondsProperty, value); }
        }

        public event RoutedPropertyChangedEventHandler<DateTime> TimeChanged
        {
            add
            {
                AddHandler(TimeChangedEvent, value);
            }
            remove
            {
                RemoveHandler(TimeChangedEvent, value);
            }
        }

        public override void OnApplyTemplate()
        {
            OnTimeChanged(DateTime.Now);

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += (s, e) => OnTimeChanged(DateTime.Now);
            timer.Start();

            base.OnApplyTemplate();
        }

        protected virtual void OnTimeChanged(DateTime newTime)
        {
            UpdateTimeState(newTime);

            // 이벤트 발생
            RaiseEvent(new RoutedPropertyChangedEventArgs<DateTime>(Time, newTime, TimeChangedEvent));
            Time = newTime;
        }

        private void UpdateTimeState(DateTime time)
        {
            if (time.Day == 25 && time.Month == 12)
            {
                VisualStateManager.GoToState(this, "Christmas", false);
            }
            else
            {
                if (time.Hour > 6 && time.Hour < 18)
                {
                    VisualStateManager.GoToState(this, "Day", false);
                }
                else
                {
                    VisualStateManager.GoToState(this, "Night", false);
                }
            }
        }
    }
}
