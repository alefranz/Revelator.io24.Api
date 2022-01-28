﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Revelator.io24.Wpf.Converters
{
    public class RoutingStateColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool routingState)
            {
                return routingState
                    ? Brushes.Green
                    : Brushes.Red;
            }
            return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
