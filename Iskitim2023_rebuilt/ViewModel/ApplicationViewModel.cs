using Iskitim2023_rebuilt.Model;
using Iskitim2023_rebuilt.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MapControl;
using System.Security.Cryptography;
using static Iskitim2023_rebuilt.Model.MathModel;
using System.Windows.Markup;


namespace Iskitim2023_rebuilt.ViewModel
{
    public class ApplicationViewModel
    {
        ApplicationContext db = new ApplicationContext();
        RelayCommand? addCommand;
        RelayCommand? addCommand_point;
        RelayCommand? editCommand;
        RelayCommand? editCommand_point;
        RelayCommand? deleteCommand;
        RelayCommand? deleteCommand_point;
      
        public ObservableCollection<pollution> polutions { get; set; }
        public ObservableCollection<string> polutionNames { get; set; }

        public ObservableCollection<MapPoint> MapPoints { get; set; }
        public ObservableCollection<point> points { get; set; }

        

        MathModel MathModel = new MathModel();
        

        public ApplicationViewModel()
        {
            db.Database.EnsureCreated();
            db.polutions.Load();
            db.points.Load();
            polutions = db.polutions.Local.ToObservableCollection();
            polutionNames = new ObservableCollection<string>(db.polutions.Select(p => p.Polution_name).Distinct());
          

            points = db.points.Local.ToObservableCollection();
            
        }

        private bool CanAddCalculation()
        {
            var checks = points.Where(y => y.IsSelected).Count();
            return checks is 3;
        }

        private void AddCalculation()
        {
            var checks = points.Where(y => y.IsSelected);
            var count = checks.Count();

            var data = checks.Select(y => (y.Latitude, y.Longitude, y.Amount)).ToList();
            if (count == 3)
            {
            //   CountMathModel2(data);
             //   DrawPolygon(cp_Masses);
            }
        }

        // команда добавления поллютантов
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand((o) =>
                  {
                      DataBase_window DataBase_window = new DataBase_window(new pollution());
                      if (DataBase_window.ShowDialog() == true)
                      {
                          pollution polut = DataBase_window.polution;
                          db.polutions.Add(polut);
                          db.SaveChanges();
                      }
                  }));
            }
        }

        // команда добавления точек
        public RelayCommand AddCommand_point
        {
            get
            {
                return addCommand_point ??
                  (addCommand_point = new RelayCommand((o) =>
                  {
                      DataBase_window_point DataBase_window_point = new DataBase_window_point(new point());
                      if (DataBase_window_point.ShowDialog() == true)
                      {
                          point poin = DataBase_window_point.point;
                          db.points.Add(poin);
                          db.SaveChanges();
                      }
                  }));
            }
        }
        // команда редактирования поллютантов
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                  (editCommand = new RelayCommand((selectedItem) =>
                  {
                      // получаем выделенный объект
                      pollution? polut = selectedItem as pollution;
                      if (polut == null) return;

                      pollution vm = new pollution
                      {
                          polution_id = polut.polution_id,
                          Polution_name = polut.Polution_name,
                          Amount = polut.Amount,
                          Point_id = polut.Point_id,
                          Year = polut.Year
                      };
                      DataBase_window DataBase_window = new DataBase_window(vm);


                      if (DataBase_window.ShowDialog() == true)
                      {
                          polut.Polution_name = DataBase_window.polution.Polution_name;
                          polut.Amount = DataBase_window.polution.Amount;
                          polut.Point_id = DataBase_window.polution.Point_id;
                          polut.Year = DataBase_window.polution.Year;
                          db.Entry(polut).State = EntityState.Modified;
                          db.SaveChanges();
                      }
                  }));
            }
        }

        // команда редактирования точек
        public RelayCommand EditCommand_point
        {
            get
            {
                return editCommand_point ??
                  (editCommand_point = new RelayCommand((selectedItem) =>
                  {
                      // получаем выделенный объект
                      point? poin = selectedItem as point;
                      if (poin == null) return;

                      point vm = new point
                      {
                          point_id = poin.point_id,
                          Amount = poin.Amount,
                          Point_num = poin.Point_num,
                          Latitude = poin.Latitude,
                          Longitude = poin.Longitude,
                          Core_count = poin.Core_count,
                          Location = poin.Location,
                      };
                      DataBase_window_point DataBase_window_point = new DataBase_window_point(vm);


                      if (DataBase_window_point.ShowDialog() == true)
                      {
                          poin.Point_num = DataBase_window_point.point.Point_num;
                          poin.Amount = DataBase_window_point.point.Amount;
                          poin.Latitude = DataBase_window_point.point.Latitude;
                          poin.Longitude = DataBase_window_point.point.Longitude;
                          poin.Core_count = DataBase_window_point.point.Core_count;
                          db.Entry(poin).State = EntityState.Modified;
                          db.SaveChanges();
                      }
                  }));
            }
        }
        // команда удаления поллютантов
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                  (deleteCommand = new RelayCommand((selectedItem) =>
                  {
                      // получаем выделенный объект
                      pollution? polut = selectedItem as pollution;
                      if (polut == null) return;
                      db.polutions.Remove(polut);
                      db.SaveChanges();
                  }));
            }
        }

        // команда удаления точек
        public RelayCommand DeleteCommand_point
        {
            get
            {
                return deleteCommand_point ??
                  (deleteCommand_point = new RelayCommand((selectedItem) =>
                  {
                      // получаем выделенный объект
                      point? poin = selectedItem as point;
                      if (poin == null) return;
                      db.points.Remove(poin);
                      db.SaveChanges();
                  }));
            }
        }
    }
}
