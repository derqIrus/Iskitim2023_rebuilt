using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Iskitim2023_rebuilt.Model;
using Iskitim2023_rebuilt.ViewModel;

namespace Iskitim2023_rebuilt.View
{
    /// <summary>
    /// Логика взаимодействия для Calculation.xaml
    /// </summary>
    public partial class Calculation : Window
    {
        
        public Calculation()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel();
            
        }

    }
}
