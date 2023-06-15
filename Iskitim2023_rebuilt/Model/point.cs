using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Iskitim2023_rebuilt.Model
{
    public class point : INotifyPropertyChanged
    {
        [Key] public int point_id { get; set; }
        int? point_num;
        string? cord;
        int? core_count;
        

        public int? Point_num
        {
            get { return point_num; }
            set
            {
                point_num = value;
                OnPropertyChanged("Point_num");
            }
        }

        public string? Cord
        {
            get { return cord; }
            set
            {
                cord = value;
                OnPropertyChanged("Cord");
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

       

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
