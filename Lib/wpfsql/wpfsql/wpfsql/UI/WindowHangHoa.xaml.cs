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
using wpfsql.Models;
using wpfsql.UI;

namespace wpfsql.UI
{
    /// <summary>
    /// Interaction logic for WindowHangHoa.xaml
    /// </summary>
    public partial class WindowHangHoa : Window
    {
        public static RoutedUICommand lenhThem = new RoutedUICommand();
        public static RoutedUICommand lenhXoa = new RoutedUICommand();
        public static RoutedUICommand lenhSua = new RoutedUICommand();

        public WindowHangHoa()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hoadonContext db = new hoadonContext();
            dgHanghoa.ItemsSource = db.Hanghoas.ToList();

        }

        private void them_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            Hanghoa hh = gridHangHoa.DataContext as Hanghoa;
            hoadonContext db = new hoadonContext();
            if (string.IsNullOrEmpty(hh.Mahang))
            {
                e.CanExecute = false;
                return;
            }
            if(db.Hanghoas.Find(hh.Mahang) != null)
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
            
        }

        private void them_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Hanghoa hh = gridHangHoa.DataContext as Hanghoa;
            hoadonContext db = new hoadonContext();
            Hanghoa a= new Hanghoa();
            a.Mahang = hh.Mahang;
            a.Tenhang = hh.Tenhang;
            a.Dvt = hh.Dvt;
            a.Dongia = hh.Dongia;
            db.Hanghoas.Add(a);
            db.SaveChanges();

            dgHanghoa.ItemsSource = db.Hanghoas.ToList();
        }

        private void xoa_Executed(object sender, ExecutedRoutedEventArgs e)
        {
           
            Hanghoa a = dgHanghoa.SelectedItem as Hanghoa;
            hoadonContext db = new hoadonContext();
            Hanghoa x = db.Hanghoas.Find(a.Mahang);
            if (x != null)
            {
                db.Hanghoas.Remove(x);
                db.SaveChanges();
                dgHanghoa.ItemsSource = db.Hanghoas.ToList();
            }
        }

        private void xoa_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (dgHanghoa == null || dgHanghoa.SelectedItem == null)
            {
                e.CanExecute = false;
                return;
            }
            hoadonContext db = new hoadonContext();
            Hanghoa a = dgHanghoa.SelectedItem as Hanghoa;
            foreach (Chitiethoadon ct in db.Chitiethoadons.Where(t => t.Mahang == a.Mahang))
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
        }

        private void dgHanghoa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Hanghoa a = dgHanghoa.SelectedItem as Hanghoa;
            //Hanghoa x = gridHangHoa.DataContext as Hanghoa;
            //x.Mahang = a.Mahang;
            //x.Tenhang = a.Tenhang;
            //x.Dvt = a.Dvt;
            //x.Dongia = a.Dongia;

        }
    }
}
