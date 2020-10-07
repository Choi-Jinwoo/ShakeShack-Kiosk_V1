using SheckSheck_Kiosk.Model;
using SheckSheck_Kiosk.ViewModel;
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

namespace SheckSheck_Kiosk.View
{

    /// <summary>
    /// OrderView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OrderView : Page
    {
        private OrderViewModel orderViewModel = new OrderViewModel();

        public OrderView()
        {
            InitializeComponent();

            this.DataContext = orderViewModel;

            // 가장 처음 카테고리로 리스트박스 초기화
            if (orderViewModel.Categories.Count > 0)
            {
                lbFood.ItemsSource = orderViewModel.Foods.Where(x =>
                    x.CategoryId == orderViewModel.Categories[0].Id).ToList();
            }
        }

        private void lbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          if (lbCategory.SelectedIndex == -1)
            {
                return;
            }

            Category category = (Category)lbCategory.SelectedItem;
            lbFood.ItemsSource = orderViewModel.Foods.Where(x => x.CategoryId == category.Id).ToList();
        }
    }
}
