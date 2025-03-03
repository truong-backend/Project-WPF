using demoSQL.Models;
using demoSQL.Mymodels;
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

namespace demoSQL.UI
{
    /// <summary>
    /// Interaction logic for WindowHoadon.xaml
    /// </summary>
    public partial class WindowHoadon : Window
    {

        public static RoutedUICommand lenhChon = new RoutedUICommand();
        public static RoutedUICommand lenhLapHD = new RoutedUICommand();
        private Choadon hd = new Choadon();
        public WindowHoadon()
        {
            InitializeComponent();
        }


        private void dghoadon_LoadingRowDetails_1(object sender, DataGridRowDetailsEventArgs e)
        {
            demoSQL.Models.Hoadon hd = e.Row.Item as demoSQL.Models.Hoadon;
            hoadonContext db = new hoadonContext();
            hd.Chitiethoadons = db.Chitiethoadons.Where(t => t.Sohd == hd.Sohd).ToList();
            foreach (Chitiethoadon c in hd.Chitiethoadons)
            {
                c.MahangNavigation = db.Hanghoas.Find(c.Mahang);
            }
            Choadon x = Choadon.chuyendoi(hd);
            FrameworkElement fw = e.DetailsElement;
            StackPanel sp = fw.FindName("stackhoadon") as StackPanel;
            sp.DataContext = x;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hoadonContext db = new hoadonContext();
            dghoadon.ItemsSource = db.Hoadons.ToList();
            cmbMahang.ItemsSource = db.Hanghoas.ToList();
        }



        private void chon_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Cchitiethoadon ct = gridCTHD.DataContext as Cchitiethoadon;

            Cchitiethoadon x = new Cchitiethoadon
            {
                Mahang = ct.Mahang,
                Soluong = ct.Soluong
            };
            hoadonContext db = new hoadonContext();
            x.MahangNavigation = db.Hanghoas.Find(x.Mahang);
            x.Dongia = x.MahangNavigation.Dongia;

            hd.Chitiethoadons.Add(x);
            //dgchitiet.ItemsSource = hd.Chitiethoadons.ToList();
            stackHoaDon.DataContext = Choadon.saochep(hd);
        }

        private void chon_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void lap_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Choadon x = stackHoaDon.DataContext as Choadon;
            Hoadon y = Choadon.chuyendoi(x);
            foreach (Chitiethoadon c in y.Chitiethoadons)
            {
                c.Sohd = y.Sohd;
            }
            hoadonContext db = new hoadonContext();
            db.Hoadons.Add(y);
            db.SaveChanges();
            dghoadon.ItemsSource = db.Hoadons.ToList();
            hd = new Choadon();
            stackHoaDon.DataContext = (hd);
        }

        private void lap_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }



    }
}
