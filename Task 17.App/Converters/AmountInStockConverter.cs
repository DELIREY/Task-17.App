using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Task_17.App.Converters
{
    public class AmountInStockConverter : IValueConverter
    {
        int amount = (int)value;
        if (amount == 0)
            return new SolidColorBrush(Colors.Red);

        return new SolidColorBrush(Colors.Transparent);
    }
    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
    
}
