using DemoThi.UI;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoThi;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void menuHannghoa_Click_1(object sender, RoutedEventArgs e)
    {
        Windowhanghoa f = new Windowhanghoa();
        f.Show();
    }


    private void menuHoadon_Click(object sender, RoutedEventArgs e)
    {
        Windowhoadon f = new Windowhoadon();
        f.Show();
    }

    private void menuHodobmvvm_Click(object sender, RoutedEventArgs e)
    {

    }
}