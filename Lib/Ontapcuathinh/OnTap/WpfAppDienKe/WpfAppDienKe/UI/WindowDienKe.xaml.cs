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
using WpfAppDienKe.Models;
using WpfAppDienKe.MyModels;

namespace WpfAppDienKe.UI
{
    /// <summary>
    /// Interaction logic for WindowDienKe.xaml
    /// </summary>
    public partial class WindowDienKe : Window
    {
        csdl_dienkeContext db = new csdl_dienkeContext();
        public static RoutedUICommand lenhXoa = new RoutedUICommand();
        public static RoutedUICommand lenhThem = new RoutedUICommand();
        public WindowDienKe()
        {
            InitializeComponent();
        }
        private void hienThi()
        {
            gridDienKe.ItemsSource = db.Dienkes.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbMakh.ItemsSource = db.Khachhangs.ToList();
            hienThi();
        }

        private void nutXoa_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void nutXoa_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Dienke a = gridDienKe.SelectedItem as Dienke;
            MessageBoxResult notice = MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo",
                MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (notice == MessageBoxResult.OK)
            {
                Dienke dk = db.Dienkes.Find(a.Madk);
                    foreach(Sudungdien sdd in db.Sudungdiens.Where(t => t.Madk == dk.Madk))
                    {
                        MessageBox.Show("không thể xóa điện kế này vì bạn đã vi phạm ràng buộc");
                        return;
                    }
                if (dk != null)
                {
                    db.Dienkes.Remove(dk);
                    db.SaveChanges();
                    hienThi();
                }
                
            }
        }

        private void nutThem_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            CDienKe a = stackDienKe.DataContext as CDienKe;
            if (a == null || a.Makh == null || a.Madk == null || a.Ngaydk == null)
            {
                e.CanExecute = false;
                return;
            }
            foreach(Dienke dk in db.Dienkes)
            {
                if (dk.Madk == a.Madk)
                {
                    e.CanExecute = false;
                    return;
                }
            }
            e.CanExecute = true;
        }

        private void nutThem_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CDienKe a=stackDienKe.DataContext as CDienKe;
            Dienke x = CDienKe.chuyenDoi(a);
            db.Dienkes.Add(x);
            db.SaveChanges();
            hienThi();

        }
    }
}
