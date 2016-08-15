using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTeste.Converters
{
    /// <summary>
    /// Retorna TRUE se a lista tiver items
    /// </summary>
    public class CollectionToBooleanConverter : IValueConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            IEnumerable list = value as IEnumerable;
            bool invert = false;

            if (parameter != null)
                invert = (string)parameter == "true";

            if (list == null)
                return false;

            bool hasItems = list.Cast<object>().Count() > 0;

            return invert ? !hasItems : hasItems;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value?.ToString() ?? string.Empty;
        }
    }
}
