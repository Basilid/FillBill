using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace Demo
{
    public class PackageStatus2StringConverter: IValueConverter
    {
        private Dictionary<PackageStatus, string> packStatus2Strings 
            = new Dictionary<PackageStatus, string>
            {
                { PackageStatus.None,       "<Не определено>" },
                { PackageStatus.Forming,    "Формируется" },
                { PackageStatus.VerifyNeed, "Требует проверки" },
                { PackageStatus.Verifying,  "Проверка" },
                { PackageStatus.Dismiss,    "Отклонен" },
            };

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return packStatus2Strings[(PackageStatus)value];
            }
            catch
            {
                return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}