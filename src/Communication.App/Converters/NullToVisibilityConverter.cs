﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Communication.App.Converters
{
    public class NullToVisibilityConverter : IValueConverter
    {
        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) => value == null ? Visibility.Collapsed : Visibility.Visible;

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}