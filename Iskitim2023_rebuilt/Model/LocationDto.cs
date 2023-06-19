using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskitim2023_rebuilt.Model
{
    public class LocationDto
    {
        public double Latitude { get; set; }

        public LocationDto(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Longitude { get; set; }
    }
}
