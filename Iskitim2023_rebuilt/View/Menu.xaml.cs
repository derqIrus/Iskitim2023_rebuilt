using Iskitim2023_rebuilt.View;
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

namespace Iskitim2023_rebuilt
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void BDpoint_btn_Click(object sender, RoutedEventArgs e)
        {
            PointWindow PointWindow = new PointWindow();
            PointWindow.Show();
        }

        private void BDpolut_btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void calculate_btn_Click(object sender, RoutedEventArgs e)
        {
            Calculation calculation = new Calculation();
            
            calculation.Show();
        }
    }
}
