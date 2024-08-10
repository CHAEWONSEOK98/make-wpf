using System.Globalization;
using System.Windows.Data;

namespace WpfValueConverter.Converters
{
    public class GenderToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value.ToString() != "" && value.ToString() == "M")
            {
                return "Images/male.png";
            }
            else if(value.ToString() != "" && value.ToString() == "F")
            {
                return "Images/female.png";
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
