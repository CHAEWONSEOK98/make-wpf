using System.Windows;
using System.Windows.Controls;

namespace SmartDateControl.UI.Units
{
    public class DayOfWeek : Label
    {
        static DayOfWeek()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DayOfWeek), new FrameworkPropertyMetadata(typeof(DayOfWeek)));
        }
    }
}
