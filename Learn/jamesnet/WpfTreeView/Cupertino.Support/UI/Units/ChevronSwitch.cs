using System.Windows;
using System.Windows.Controls.Primitives;

namespace Cupertino.Support.UI.Units
{
    public class ChevronSwitch : ToggleButton
    {
        static ChevronSwitch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChevronSwitch), new FrameworkPropertyMetadata(typeof(ChevronSwitch)));
        }
    }
}
