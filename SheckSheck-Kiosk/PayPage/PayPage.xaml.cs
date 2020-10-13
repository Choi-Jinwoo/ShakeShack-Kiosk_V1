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

namespace SheckSheck_Kiosk.PayPage
{
    /// <summary>
    /// PayPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PayPage : Page
    {
        public PayPage()
        {
            InitializeComponent();
        }

        private void backToPage(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
            else
            {
                Order.OrderPage orderPage = new Order.OrderPage();
                NavigationService.Navigate(orderPage);
            }
        }
    }
}
