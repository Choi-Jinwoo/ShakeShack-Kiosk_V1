using SheckSheck_Kiosk.Order;
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

namespace SheckSheck_Kiosk.ChoicePay
{
    /// <summary>
    /// Interaction logic for ChoicePay.xaml
    /// </summary>
    public partial class ChoicePay : Page
    {
        public ChoicePay()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoForward) //앞으로 이동 가능하다면 그냥 ㄱㄱ 
            { 
                NavigationService.GoForward(); 
            } 
            else 
            { 
                OrderPage orderPage = new OrderPage();
                NavigationService.Navigate(orderPage); }

            
        }
    }
}
