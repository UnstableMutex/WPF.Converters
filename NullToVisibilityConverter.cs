  class NullToVisibilityConverter:IValueConverter
    {
        public NullToVisibilityConverter()
        {
            ForNullValue = Visibility.Collapsed;
            ForNotNullValue = Visibility.Visible;
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? ForNullValue : ForNotNullValue;
        }

        public Visibility ForNullValue { get; set; }
        public Visibility ForNotNullValue { get; set; }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
