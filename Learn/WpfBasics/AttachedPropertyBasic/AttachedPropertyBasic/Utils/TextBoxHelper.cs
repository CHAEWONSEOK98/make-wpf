using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace AttachedPropertyBasic.Utils
{
    public class TextBoxHelper
    {
        private static void OnUseOnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var textBox = d as TextBox;
            if (textBox == null) return;

            if ((bool)e.NewValue)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }
            else
            {
                textBox.TextChanged -= TextBox_TextChanged;
            }
        }

        private static void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            BindingExpression bindingExpression = textBox.GetBindingExpression(TextBox.TextProperty);
            bindingExpression?.UpdateSource();
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UesOnPropertyChangedProperty =
            DependencyProperty.RegisterAttached("UesOnPropertyChanged", typeof(bool), typeof(TextBoxHelper), new PropertyMetadata(false, OnUseOnPropertyChanged));

        public static bool GetUseOnPropertyChanged (DependencyObject obj)
        {
            return (bool)obj.GetValue(UesOnPropertyChangedProperty);
        }

        public static void SetUseOnPropertyChanged(DependencyObject obj, bool value)
        {
            obj.SetValue(UesOnPropertyChangedProperty, value);
        }




    }
}
