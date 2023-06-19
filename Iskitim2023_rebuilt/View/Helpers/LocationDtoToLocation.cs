using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Iskitim2023_rebuilt.Model;
using MapControl;

namespace Iskitim2023_rebuilt.View.Helpers
{
    internal class LocationDtoToLocation : IValueConverter, IMultiValueConverter
    {
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            LocationDto lValue = null;
            if (value is LocationDto dto) lValue = dto;
            return lValue == null ? null : new Location() { Latitude = lValue.Latitude, Longitude = lValue.Longitude }; 
        }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
