using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Task_17.App.Converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (targetType == typeof(ImageSource))
                throw new InvalidOperationException("Target type must be System.Windows.Media.ImageSource.");

            try
            {
                BitmapImage img = new BitmagImage();
                img.BeginInit();
                img.UriSource = new Uri("/Task17.App;component/Images/coffee" + value + ".png", UriKind.Relative);
                img.EndInit();
                return img;
            }
            catch
            {
                return DependencyProperty.UnsetValue;

            }



        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}

