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
using Hoadon.UI;
using Hoadon.MyModels;

namespace Hoadon.UI
{
    /// <summary>
    /// Interaction logic for Windowhoadon.xaml
    /// </summary>
    public partial class Windowhoadon : Window
    {
        public Windowhoadon()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hoadonContext db = new hoadonContext();
            dghoadon.ItemsSource = db.Hoadons.ToList();
        }

        private void dghoadon_LoadingRowDetails(object sender, DataGridRowDetailsEventArgs e)
        {
            Hoadon.Models.Hoadon hd = e.Row.Item as Hoadon.Models.Hoadon;
            hoadonContext db = new hoadonContext();
            hd.Chitiethoadons=db.Chitiethoadons.Where(t=>t.Sohd == hd.Sohd).ToList();
            foreach(Chitiethoadon c in hd.Chitiethoadons)
            {
                c.MahangNavigation = db.Hanghoas.Find(c.Mahang);
            }
            Choadon x = Choadon.chuyendoi(hd);
            FrameworkElement fw = e.DetailsElement;
            StackPanel sp = fw.FindName("stackhoadon") as StackPanel;
            sp.DataContext = x;
        }
    }
}
