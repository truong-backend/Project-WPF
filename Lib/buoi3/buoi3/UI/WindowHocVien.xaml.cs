﻿using buoi3.MyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using waMonhoc.Models;

namespace buoi3.UI
{
    /// <summary>
    /// Interaction logic for WindowHocVien.xaml
    /// </summary>

    public partial class WindowHocVien : Window
    {
        public static RoutedUICommand lenhThem = new RoutedUICommand();
        public static RoutedUICommand lenhXoa = new RoutedUICommand();
        public static RoutedUICommand lenhSua = new RoutedUICommand();

        public WindowHocVien()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            qlhvContext db = new qlhvContext();
            cmMalop.ItemsSource = db.Lops.Select(t => CLop.chuyendoi(t)).ToList();
            display();
        }

        private void display()
        {
            qlhvContext db = new qlhvContext();
            List<Lylich> ds = db.Lyliches.ToList();
            dgHocVien.ItemsSource = ds;
            foreach (Lylich a in ds)
            {
                a.MalopNavigation = db.Lops.Find(a.Malop);

            }
            dgHocVien.ItemsSource = ds.Select(t => CHocVien.chuyendoi(t)).ToList();
        }

        private void them_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CHocVien hv = gridHocVien.DataContext as CHocVien;
            Lylich x = CHocVien.chuyendoi(hv);
            qlhvContext db = new qlhvContext();
            db.Lyliches.Add(x);
            db.SaveChanges();
            display();
        }

        private void them_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            CHocVien hv = gridHocVien.DataContext as CHocVien;
            qlhvContext db = new qlhvContext();
            if (string.IsNullOrEmpty(hv.Malop) || hv.Ngaysinh == null || hv.Phai == null || string.IsNullOrEmpty(hv.Mshv))
            {
                e.CanExecute = false;
                return;
            }
            if (db.Lyliches.Find(hv.Mshv) != null)
            {
                e.CanExecute = false; return;
            }
            e.CanExecute = true;
        }

        private void xoa_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CHocVien hv = dgHocVien.SelectedItem as CHocVien;
            MessageBoxResult ok = MessageBox.Show("Bạn có thật sự xóa hoc viên này không?", "Cảnh báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (ok == MessageBoxResult.OK)
            {
                qlhvContext db = new qlhvContext();
                Lylich x = db.Lyliches.Find(hv.Mshv);
                if (x != null)
                {
                    db.Lyliches.Remove(x);
                    db.SaveChanges();

                    display();

                }
            }
        }

        private void sua_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            CHocVien hv = gridHocVien.DataContext as CHocVien;
            qlhvContext db = new qlhvContext();
            Lylich x = db.Lyliches.Find(hv.Mshv);
            if (x!= null)
            {
                x.Tenhv = hv.Tenhv;
                x.Ngaysinh = hv.Ngaysinh;
                x.Phai = hv.Phai;
                x.Malop = hv.Malop;
                db.SaveChanges();
                display();
            }
        }

        private void sua_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            CHocVien hv = gridHocVien.DataContext as CHocVien;
            qlhvContext db = new qlhvContext();
            if (string.IsNullOrEmpty(hv.Mshv) || hv.Ngaysinh == null || hv.Phai == null || string.IsNullOrEmpty(hv.Malop))
            {
                e.CanExecute = false;
                return;
            }
            if (db.Lyliches.Find(hv.Mshv) == null)
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
        }

        private void xoa_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (dgHocVien == null || dgHocVien.SelectedItem == null)
            {
                e.CanExecute = false;
                return;
            }
            qlhvContext db = new qlhvContext();
            CHocVien hv = dgHocVien.SelectedItem as CHocVien;
            foreach (Diemthi d in db.Diemthis.Where(t => t.Mshv == hv.Mshv))
            {
                e.CanExecute = false;
                return;
            }
            e.CanExecute = true;
        }

        private void dgHocVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dgHocVien == null || dgHocVien.SelectedItem == null)
            {
                return;
            }
            CHocVien hv = dgHocVien.SelectedItem as CHocVien;
            CHocVien uphv = new CHocVien();
            uphv.Mshv = hv.Mshv;
            uphv.Tenhv = hv.Tenhv;
            uphv.Ngaysinh = hv.Ngaysinh;
            uphv.Phai = hv.Phai;
            uphv.Malop = hv.Malop;

            gridHocVien.DataContext = uphv;
        }
    }
}
