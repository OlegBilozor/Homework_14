using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Homework_14
{
    class ExperienceToMultiplierConverter : IValueConverter

    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is int exp)) return (double)0;
            if (exp >= 5 && exp<=8) return (double)1.2;
            if (exp > 8 && exp <= 12) return (double)1.5;
            if (exp > 12) return 1.7;
            return (double)1.0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
