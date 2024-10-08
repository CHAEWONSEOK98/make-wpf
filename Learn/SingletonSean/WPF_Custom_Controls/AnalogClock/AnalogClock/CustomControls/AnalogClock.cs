﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AnalogClock.CustomControls
{
    public delegate void TimeChangedEventHandler(object sender, TimeChangedEventArgs args);

    [TemplatePart(Name = "PART_HourHand", Type = typeof(Line))]
    [TemplatePart(Name = "PART_MinuteHand", Type = typeof(Line))]
    [TemplatePart(Name = "PART_SecondHand", Type = typeof(Line))]
    public class AnalogClock : Clock
    {
        private Line hourHand;
        private Line minuteHand;
        private Line secondHand;

        static AnalogClock()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(AnalogClock), new FrameworkPropertyMetadata(typeof(AnalogClock)));
        }

        public override void OnApplyTemplate()
        {
            hourHand = Template.FindName("PART_HourHand", this) as Line;
            minuteHand = Template.FindName("PART_MinuteHand", this) as Line;
            secondHand = Template.FindName("PART_SecondHand", this) as Line;

            #region 바인딩 제공
            //Binding showSecondHandBinding = new Binding
            //{
            //    Path = new PropertyPath(nameof(ShowSeconds)),
            //    Source = this,
            //    Converter = new BooleanToVisibilityConverter()
            //};

            //secondHand.SetBinding(VisibilityProperty, showSecondHandBinding); 
            #endregion

            base.OnApplyTemplate();
        }

        protected override void OnTimeChanged(DateTime time)
        {
            UpdateHandAngles(time);
            base.OnTimeChanged(time);
        }

        private void UpdateHandAngles(DateTime time)
        {
            hourHand.RenderTransform = new RotateTransform((time.Hour / 12.0) * 360, 0.5, 0.5);
            minuteHand.RenderTransform = new RotateTransform((time.Minute / 60.0) * 360, 0.5, 0.5);
            secondHand.RenderTransform = new RotateTransform((time.Second / 60.0) * 360, 0.5, 0.5);
        }
    }
}
