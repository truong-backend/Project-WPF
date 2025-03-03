using Demothidecu.Models;
using Demothidecu.Mymodels;
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

namespace Demothidecu.UI
{
    /// <summary>
    /// Interaction logic for Windowdienke.xaml
    /// </summary>
    public partial class Windowdienke : Window
    {
        public static RoutedUICommand lenhThem = new RoutedUICommand();
        public static RoutedUICommand lenhXoa = new RoutedUICommand();
        private Cdienke hd = new Cdienke();
        public Windowdienke()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            csdl_dienkeContext db = new csdl_dienkeContext();
            dgDienke.ItemsSource = db.Dienkes.ToList();
            cmbMakhachhang.ItemsSource = db.Khachhangs.ToList();
        }

        private void them_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            Cdienke dk1 = stackDienke.DataContext as Cdienke;

            csdl_dienkeContext db = new csdl_dienkeContext();
            if (db.Dienkes.Find(dk1.Madk) != null)
            {
                MessageBox.Show("Không thể thêm vì mã điện kế đã tồn tại");
                return;
            }
            else
            {
                Dienke a = new Dienke();

                a.Madk = dk1.Madk;
                a.Ngaydk = dk1.Ngaydk;
                a.Makh = dk1.Makh;

                db.Dienkes.Add(a);
                db.SaveChanges();

                dgDienke.ItemsSource = db.Dienkes.ToList();
            }
            
        }


        private void them_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void xoa_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (dgDienke == null || dgDienke.SelectedItem == null)
            {
                e.CanExecute = false;
                return;
            }
            csdl_dienkeContext db = new csdl_dienkeContext();
            Dienke a = dgDienke.SelectedItem as Dienke;

            e.CanExecute = true;
        }

        private void xoa_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult notice = MessageBox.Show("Bạn có muốn xóa hay không?", "Cảnh báo",
                MessageBoxButton.OKCancel, MessageBoxImage.Warning);

            if (notice == MessageBoxResult.OK)
            {

                Dienke a = dgDienke.SelectedItem as Dienke;



                csdl_dienkeContext db = new csdl_dienkeContext();

                foreach (Sudungdien sdd in db.Sudungdiens.Where(t => t.Madk == a.Madk))
                {
                    MessageBox.Show("không thể xóa điện kế này vì bạn đã vi phạm ràng buộc");
                    return;
                }

                Dienke x = db.Dienkes.Find(a.Madk);
                if (x != null)
                {
                    db.Dienkes.Remove(x);
                    db.SaveChanges();
                    dgDienke.ItemsSource = db.Dienkes.ToList();
                }
            }
        }

        private void dgDienke_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (dgDienke == null || dgDienke.SelectedItem as Cdienke == null)
            //    return;
            Cdienke a = dgDienke.SelectedItem as Cdienke;
            csdl_dienkeContext db = new csdl_dienkeContext();
            Cdienke x = new Cdienke();
            x.Madk = a.Madk;
            x.Ngaydk = a.Ngaydk;
            x.Makh = a.Makh;
            stackDienke.DataContext = x;
        }
    }
}
