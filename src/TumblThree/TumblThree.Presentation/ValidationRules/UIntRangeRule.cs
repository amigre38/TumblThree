﻿using System;
using System.Globalization;
using System.Windows.Controls;
using TumblThree.Presentation.Properties;

namespace TumblThree.Presentation.ValidationRules
{
    public class UIntRangeRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            UInt32 temp = 0;
            try
            {
                if (UInt32.TryParse((string) value, out temp))
                    return new ValidationResult(true, null);
            }
            catch (Exception e)
            {
                return new ValidationResult(false, string.Format(CultureInfo.CurrentCulture, Resources.UIntRangeError));
            }
            return new ValidationResult(false, string.Format(CultureInfo.CurrentCulture, Resources.UIntTypeError));
        }
    }
}
