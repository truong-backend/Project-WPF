using Hoadon.Models;
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

namespace Hoadon.UI
{
    /// <summary>
    /// Interaction logic for Windowhanghoa.xaml
    /// </summary>
    public partial class Windowhanghoa : Window
    {
        //nút them
        public static RoutedUICommand lenhthem = new RoutedUICommand();
        //lệnh xóa

        public static RoutedUICommand lenhxoa = new RoutedUICommand();
        //lệnh sửa
        public static RoutedUICommand lenhsua = new RoutedUICommand();
        public Windowhanghoa()
        {
            InitializeComponent();
        }
        //
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hoadonContext db = new hoadonContext();
            dghanghoa.ItemsSource = db.Hanghoas.ToList();//liên kết và truy cập đối tượng
        }
        //thực thi lệnh
        private void lenhThem_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Hanghoa hh = gridHangHoa.DataContext as Hanghoa;
            hoadonContext db = new hoadonContext();
            Hanghoa a = new Hanghoa();
            a.Mahang = hh.Mahang;
            a.Tenhang = hh.Tenhang;
            a.Dvt = hh.Dvt;
            a.Dongia = hh.Dongia;
            db.Hanghoas.Add(a);
            db.SaveChanges();

            dghanghoa.ItemsSource = db.Hanghoas.ToList();
        }
        //xác định lệnh có thực thi không?
        private void lenhThem_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            Hanghoa hh = gridHangHoa.DataContext as Hanghoa;
            hoadonContext db = new hoadonContext();
            if (string.IsNullOrEmpty(hh.Mahang))// kiểm tra nếu để trống
            {
                e.CanExecute = false; // cho nút thêm có thực thi không nếu không là false
                return;
            }
            if (db.Hanghoas.Find(hh.Mahang) != null) //kiểm tra nếu trùng
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
        }

        private void lenhXoa_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (dghanghoa == null || dghanghoa.SelectedItem == null)
                return;
            Hanghoa a = dghanghoa.SelectedItem as Hanghoa;
            hoadonContext db = new hoadonContext();
            Hanghoa x = db.Hanghoas.Find(a.Mahang);
            if (x != null)
            {
                db.Hanghoas.Remove(x);
                db.SaveChanges();
                dghanghoa.ItemsSource = db.Hanghoas.ToList();
            }
        }

        private void lenhXoa_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (dghanghoa == null || dghanghoa.SelectedItem == null)
            {
                e.CanExecute = false;
                return;
            }
            hoadonContext db = new hoadonContext();
            Hanghoa a = dghanghoa.SelectedItem as Hanghoa;
            foreach (Chitiethoadon ct in db.Chitiethoadons.Where(t => t.Mahang == a.Mahang))
            {
                e.CanExecute = false;
                return;

            }
            e.CanExecute = true;
        }

        private void dghanghoa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dghanghoa == null || dghanghoa.SelectedItem == null)
                return;
            Hanghoa a = dghanghoa.SelectedItem as Hanghoa;
            Hanghoa x = new Hanghoa();
            x.Mahang = a.Mahang;
            x.Tenhang = a.Tenhang;
            x.Dvt = a.Dvt;
            x.Dongia = a.Dongia;

            gridHangHoa.DataContext = x;
        }

        private void lenhSua_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Hanghoa hh = gridHangHoa.DataContext as Hanghoa;
            hoadonContext db = new hoadonContext();
            Hanghoa x = db.Hanghoas.Find(hh.Mahang);
            if(x != null)
            {
                x.Tenhang = hh.Tenhang;
                x.Dvt = hh.Dvt;
                x.Dongia =hh.Dongia;
                db.SaveChanges();

                dghanghoa.ItemsSource =db.Hanghoas.ToList();
            }
        }

        private void lenhSua_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            Hanghoa hh = gridHangHoa.DataContext as Hanghoa;//lấy dữ liệu trên báng xuống
            hoadonContext db = new hoadonContext();
            if (db.Hanghoas.Find(hh.Mahang) == null)
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
        }
    }
}
