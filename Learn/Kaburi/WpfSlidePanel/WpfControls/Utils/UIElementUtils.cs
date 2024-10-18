using System.Windows;
using System.Windows.Controls;

namespace WpfControls.Utils
{
    public static class UIElementUtils
    {
        public static void BringToFront(this UIElement uiElement)
        {
            Panel.SetZIndex(uiElement, int.MaxValue);
        }

        public static void SendToBack(this UIElement uiElement)
        {
            Panel.SetZIndex(uiElement, int.MinValue);
        }
    }
}
