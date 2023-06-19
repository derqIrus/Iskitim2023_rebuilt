using MapControl;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iskitim2023_rebuilt.Model
{
    
    public class MapPoint
    {
        
        public string? Name { get; set; }
        [Key] public Location Location { get; set; } = null!;

        public static MapPoint GetPoint(point point)
        {
            MapPoint item = new MapPoint()
            {
                Name = point.Point_num,
                Location = new Location()
                {
                    Latitude = point.Latitude,
                    Longitude = point.Longitude
                }
            };
            return item;
        }
    }
}
