using buoi2.Models;
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
    /// Interaction logic for WindowHangHoa.xaml
    /// </summary>
    public partial class WindowHangHoa : Window
    {
        //Thêm 1 cái lệnh 
        public static RoutedUICommand Lenhthem = new RoutedUICommand();
        public static RoutedUICommand Lenhxoa = new RoutedUICommand();
        public static RoutedUICommand Lenhsua = new RoutedUICommand();
        public WindowHangHoa()
        {
            InitializeComponent();
        }

  
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hoadonContext db = new hoadonContext();
            dgHangHoa.ItemsSource = db.Hanghoas.ToList();
        }


        private void them_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //dữ liệu thêm vào là đối tượng hàng hóa
            Hanghoa hh = GirdHangHoa.DataContext as Hanghoa;
            hoadonContext db = new hoadonContext();
            db.Hanghoas.Add(hh);
            db.SaveChanges();
            dgHangHoa.ItemsSource = db.Hanghoas.ToList();


        }

        private void them_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            //kiểm tra xem có hiệu lực khoinog
            e.CanExecute = true;

            Hanghoa hh = GirdHangHoa.DataContext as Hanghoa;
            hoadonContext db = new hoadonContext();
            if (hh == null | string.IsNullOrEmpty(hh.Mahang))
            {
                e.CanExecute = false;
                return;
            }
            if (db.Hanghoas.Find(hh.Mahang) != null)
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
        }

        private void xoa_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Hanghoa hh = dgHangHoa.SelectedItem as Hanghoa;
            hoadonContext db = new hoadonContext();
            Hanghoa x = db.Hanghoas.Find(hh.Mahang);
            if (x != null)
            {
                db.Hanghoas.Remove(x);
                db.SaveChanges();
                dgHangHoa.ItemsSource = db.Hanghoas.ToList();
            }
        }

        private void xoa_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (dgHangHoa == null || dgHangHoa.SelectedItem == null)
            {
                e.CanExecute = false;
                return;
            }
            Hanghoa hh = dgHangHoa.SelectedItem as Hanghoa;
            hoadonContext db = new hoadonContext();
            foreach(Chitiethoadon ct in db.Chitiethoadons.Where(t => t.Mahang == hh.Mahang))
            {
                e.CanExecute = false;
                return;

            }
            e.CanExecute = true;
        }

        private void sua_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Hanghoa hh = GirdHangHoa.DataContext as Hanghoa;
            hoadonContext db = new hoadonContext();
            Hanghoa x = db.Hanghoas.Find(hh.Mahang);
            if (x != null)
            {
                x.Tenhang = hh.Tenhang;
                x.Dvt = hh.Dvt;
                x.Dongia = hh.Dongia;
                db.SaveChanges();
                dgHangHoa.ItemsSource = db.Hanghoas.ToList();
            }
        }

        private void sua_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            Hanghoa hh = GirdHangHoa.DataContext as Hanghoa;
            hoadonContext db = new hoadonContext();
            if (db.Hanghoas.Find(hh.Mahang) == null)
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
        } 

        private void dgHangHoa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgHangHoa == null || dgHangHoa.SelectedItem == null)
                return;
            Hanghoa hh = dgHangHoa.SelectedItem as Hanghoa;
            Hanghoa x = new Hanghoa();
            x.Mahang = hh.Mahang;
            x.Tenhang = hh.Tenhang;
            x.Dvt = hh.Dvt;
            x.Dongia = hh.Dongia;
            GirdHangHoa.DataContext = x;

        }
    }
}
