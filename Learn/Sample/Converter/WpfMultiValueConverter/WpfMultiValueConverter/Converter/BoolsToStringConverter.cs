using System.Globalization;
using System.Windows.Data;

namespace WpfMultiValueConverter.Converter
{
    public class BoolsToStringConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string answer = "Your answer is : ";
            if ((bool)values[0] == true && (bool)values[1]==true && (bool)values[2] == true)
            {
                return answer + "CORRECT";
            }
            else if((bool)values[0] == false && (bool)values[1] == false && (bool)values[2] == false)
            {
                return answer;
            }
            else
            {
                return answer + "INCORRECT";
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
