using Iskitim2023_rebuilt.Model;
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
    public partial class DataBase_window : Window
    {
        public pollution polution { get; private set; }
        public DataBase_window(pollution polut)
        {
            InitializeComponent();
            polution = polut;
            DataContext = polution;
        }

        void Accept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
