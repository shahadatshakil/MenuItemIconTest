using System.Globalization;

namespace MAUITestProject_MenuItem_.Converters;

public class MenuIconConverter : IValueConverter, IMarkupExtension
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return new FontImageSource
        {
            FontFamily = "IconsFont",
            Glyph = (string)value,
            Color = Colors.Green
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}
