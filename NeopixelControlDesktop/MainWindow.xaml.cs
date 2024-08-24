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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NeopixelControlDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnOff_ClickAsync(object sender, RoutedEventArgs e)
        {
           
            var res = await AdafruitIOService.SendValue("z");
            MessageBox.Show(res);
        }

        private async void btnNorm_Click(object sender, RoutedEventArgs e)
        {
            var res = await AdafruitIOService.SendValue("n");
            MessageBox.Show(res);
        }

        private async void btnJuly_Click(object sender, RoutedEventArgs e)
        {
            var res = await AdafruitIOService.SendValue("j");
            MessageBox.Show(res);
        }

        private async void btnFall_Click(object sender, RoutedEventArgs e)
        {
            var res = await AdafruitIOService.SendValue("f");
            MessageBox.Show(res);
        }

        private async void btnXmas_Click(object sender, RoutedEventArgs e)
        {
            var res = await AdafruitIOService.SendValue("c");
            MessageBox.Show(res);
        }

        
    }
}
