
using SheckSheck_Kiosk.CardPay;
using SheckSheck_Kiosk.ChoicePay;
using SheckSheck_Kiosk.PayPage;
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

namespace SheckSheck_Kiosk.Order
{
    /// <summary>
    /// OrderPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        private void backToMain(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoForward) {
                NavigationService.GoForward(); 
            }
            else {
                ChoicePay.ChoicePay choicepay = new ChoicePay.ChoicePay();
                NavigationService.Navigate(choicepay); }

        

        }

        private void goToPayPage(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
            else
            {
            PayCard payCard = new PayCard();
                NavigationService.Navigate(payCard);
            }
        }
        }

        
    }

