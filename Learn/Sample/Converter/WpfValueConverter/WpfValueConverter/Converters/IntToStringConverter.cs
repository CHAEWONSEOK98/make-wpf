using System.Globalization;
using System.Windows.Data;

namespace WpfValueConverter.Converters
{
    public class IntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value.ToString() != "" && int.Parse(value.ToString()) % 2 == 0 )
            {
                return "EVEN";
            }
            else if(value.ToString() != "" && int.Parse(value.ToString()) % 2 != 0)
            {
                return "ODD";
            }
            else
            {
                return "Invalid entry";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
