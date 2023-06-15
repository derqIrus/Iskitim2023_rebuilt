using Iskitim2023_rebuilt.ViewModel;
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

namespace Iskitim2023_rebuilt.View
{
    /// <summary>
    /// Логика взаимодействия для PointWindow.xaml
    /// </summary>
    public partial class PointWindow : Window
    {
        public PointWindow()
        {
            InitializeComponent();
            DataContext = new ApplicationViewModel();
        }
    }
}
