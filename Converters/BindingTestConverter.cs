using System.Globalization;

namespace MAUITestProject_MenuItem_.Converters;

public class BindingTestConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var x = value as string;

        return x;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
