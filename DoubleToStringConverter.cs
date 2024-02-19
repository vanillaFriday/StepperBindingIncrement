using System.Globalization;

namespace StepperBindingIncrement
{
    public class DoubleToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType != typeof(string))
                throw new InvalidOperationException("The target must be a string");

            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (double.TryParse((string)value, out double toReturn))
            {
                return toReturn;
            }
            else
            {
                throw new InvalidOperationException("Could not parse string as double");
            }
        }
    }
}