  class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string c = value.ToString();
            Color res = (Color)System.Windows.Media.ColorConverter.ConvertFromString("#"+c);
            if (targetType == typeof(Brush))
            {
                return new SolidColorBrush(res);
            }
            else
            {
                return res;
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
