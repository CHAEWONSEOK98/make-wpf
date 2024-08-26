using System.Windows;
using System.Windows.Controls;

namespace SmartDateControl.UI.Units
{
    public class CalendarBox : ListBox
    {
        static CalendarBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CalendarBox), new FrameworkPropertyMetadata(typeof(CalendarBox)));
        }
    }
}
