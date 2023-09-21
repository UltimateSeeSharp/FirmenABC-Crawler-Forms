﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace FirmenABC_Crawler.Gui.Converter
{
    internal class DataGridFieldConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as string) == "" ? "no data" : value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
