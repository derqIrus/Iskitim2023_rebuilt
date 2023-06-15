using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Iskitim2023_rebuilt.Model
{
    public class pollution : INotifyPropertyChanged
    {
       [Key] public int  polution_id  { get; set; }
        string? polution_name ;
        string? amount;
        int? point_id;
        int? year;
        

        public string? Polution_name
        {
            get { return polution_name; }
            set
            {
                polution_name = value;
                OnPropertyChanged("Polution_name");
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

        public int? Point_id
        {
            get { return point_id; }
            set
            {
                point_id = value;
                OnPropertyChanged("Point_id");
            }
        }

        public int? Year
        {
            get { return year; }
            set
            {
                year = value;
                OnPropertyChanged("Year");
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
