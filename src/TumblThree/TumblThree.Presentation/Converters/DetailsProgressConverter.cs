﻿using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using TumblThree.Presentation.Properties;

namespace TumblThree.Presentation.Converters
{
    public class DetailsProgressConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] == DependencyProperty.UnsetValue) { return DependencyProperty.UnsetValue; }
            if (values[1] == DependencyProperty.UnsetValue) { return DependencyProperty.UnsetValue; }
            if (values[2] == DependencyProperty.UnsetValue) { return DependencyProperty.UnsetValue; }

            var downloaded = (uint)values[0];
            var total = (uint)values[1];
            var duplicates = System.Convert.ToUInt32(values[2]);

            //if (downloaded == 0)
            //    return "";

            return string.Format(CultureInfo.CurrentCulture, Resources.DetailsProgress, downloaded, total, duplicates);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}