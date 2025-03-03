using buoi2.Migrations;
using buoi2.Models;
using buoi2.MyModels;
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

namespace buoi2.UI
{
    /// <summary>
    /// Interaction logic for WindowHoaDon.xaml
    /// </summary>
    public partial class WindowHoaDon : Window
    {
        public static RoutedUICommand lenhChon = new RoutedUICommand();
        public static RoutedUICommand lenhLapHD = new RoutedUICommand();
        private CHoaDon hd = new CHoaDon();
        public WindowHoaDon()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hoadonContext db = new hoadonContext();
            dgHoaDon.ItemsSource = db.Hoadons.ToList();
            cmbMahang.ItemsSource = db.Hanghoas.ToList();
        }

        private void dgHoaDon_LoadingRowDetails(object sender, DataGridRowDetailsEventArgs e)
        {
            Hoadon hd=e.Row.Item as Hoadon;
            hoadonContext db = new hoadonContext();
            hd.Chitiethoadons = db.Chitiethoadons.Where(t => t.Sohd == hd.Sohd).ToList();
            foreach(Chitiethoadon ct in hd.Chitiethoadons)
            {
                ct.MahangNavigation = db.Hanghoas.Find(ct.Mahang);
            }
            FrameworkElement fw = e.DetailsElement;
            StackPanel sp = fw.FindName("stackHoaDon") as StackPanel;
            sp.DataContext = CHoaDon.chuyendoi(hd);

        }

        private void chon_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CChiTietHoaDon ct = gridCTHD.DataContext as CChiTietHoaDon;

            CChiTietHoaDon x=new CChiTietHoaDon
            {
                Mahang=ct.Mahang,
                Soluong=ct.Soluong
            };
            hoadonContext db = new hoadonContext();
            x.MahangNavigation = db.Hanghoas.Find(x.Mahang);
            x.Dongia = x.MahangNavigation.Dongia;

            hd.Chitiethoadons.Add(x);
            //dgchitiet.ItemsSource = hd.Chitiethoadons.ToList();
            stackHoaDon.DataContext = CHoaDon.saochep(hd);
        }

        private void chon_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void lap_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CHoaDon x = stackHoaDon.DataContext as CHoaDon;
            Hoadon y = CHoaDon.chuyendoi(x);
            foreach(Chitiethoadon c in y.Chitiethoadons)
            {
                c.Sohd = y.Sohd;
            }
            hoadonContext db = new hoadonContext();
            db.Hoadons.Add(y);
            db.SaveChanges();
            dgHoaDon.ItemsSource = db.Hoadons.ToList();
            hd = new CHoaDon();
            stackHoaDon.DataContext = hd;


        }

        private void lap_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
