using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace WpfExplorer.Support.Local.Converters
{
    public class DepthConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // value 값이 숫자로 온다. -> Converter가 모델에서 만든 Depth 에서 값을 가져올 것이기 때문.

            int depth = int.Parse(value.ToString());
            int left = depth * 10;
            // margin
            Thickness thickness = new Thickness(left, 0, 0, 0);

            return thickness;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
