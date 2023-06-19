using MapControl;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Xml.Linq;
using Location = MapControl.Location;

namespace Iskitim2023_rebuilt.Model
{
    public class point : INotifyPropertyChanged
    {
        [Key] public int point_id { get; set; }
        string point_num;
        double latitude;
        double longitude;
        int? core_count;
        string? amount;
        string location;


        


        public string Point_num
        {
            get { return point_num; }
            set
            {
                point_num = value;
                OnPropertyChanged("Point_num");
            }
        }

        public string? Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                OnPropertyChanged("Amount");
            }
        }

        public double Latitude
        {
            get { return latitude; }
            set
            {
                latitude = value;
                OnPropertyChanged("Latitude");
            }
        }

        public double Longitude
        {
            get { return longitude; }
            set
            {
                longitude = value;
                OnPropertyChanged("Longitude");
            }
        }



        public int? Core_count
        {
            get { return core_count; }
            set
            {
                core_count = value;
                OnPropertyChanged("Core_count");
            }
        }

        public string Location
        {
            get { return location ; }
            set
            {
                location = value;
                OnPropertyChanged("Location");
            }
        }

        public bool IsSelected { get; internal set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
