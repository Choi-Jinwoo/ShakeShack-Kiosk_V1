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
using System.Windows.Threading;

namespace SheckSheck_Kiosk.Home
{
    /// <summary>
    /// HomePage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {  
            InitializeComponent();
            myMedia.Play();
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_Manager(object sender, RoutedEventArgs e)
        {
            Manager1 manager = new Manager1();
            manager.Show();
        }

        private void myMedia_MediaEnded(object sender, RoutedEventArgs e)
        {
            myMedia.Stop();
            myMedia.Position = TimeSpan.FromSeconds(0);
            myMedia.Play();
        }
    }
}
