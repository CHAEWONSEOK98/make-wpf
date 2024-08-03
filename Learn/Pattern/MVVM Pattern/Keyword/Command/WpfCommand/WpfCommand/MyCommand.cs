

using System.Windows.Input;

namespace WpfCommand
{
    static class MyCommand
    {
        public static RoutedUICommand Hello { get; set; }

        static MyCommand()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            KeyGesture shortkey = new KeyGesture(Key.E, ModifierKeys.Control);
            inputs.Add(shortkey);

            Hello = new RoutedUICommand("Hi", "Hello", typeof(MyCommand), inputs);
        }
    }
}
