using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfValueConverter.Converters
{
    public class GenderToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value.ToString() != "" && value.ToString() == "M")
            {
                return Brushes.LightBlue;
            }
            else if (value.ToString() != "" && value.ToString() == "F")
            {
                return Brushes.Pink;
            }
            else
            {
                return Binding.DoNothing;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
