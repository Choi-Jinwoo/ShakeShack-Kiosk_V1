using SheckSheck_Kiosk.Model;
using SheckSheck_Kiosk.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        private const int MAX_FOOD_ITEM_COUNT = 9;

        private OrderViewModel orderViewModel = new OrderViewModel();

        public OrderView()
        {
            InitializeComponent();

            this.DataContext = orderViewModel;

            // 가장 처음 카테고리로 리스트박스 초기화
            if (orderViewModel.Categories.Count > 0)
            {
                lbFood.ItemsSource = orderViewModel.GetSelectedCategoryFoods(MAX_FOOD_ITEM_COUNT).ToList();
            }
        }

        private void lbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbCategory.SelectedIndex == -1) return;

            Category category = (Category)lbCategory.SelectedItem;

            orderViewModel.PageCount = 0;
            orderViewModel.SelectedCategory = category;
            lbFood.ItemsSource = orderViewModel.GetSelectedCategoryFoods(MAX_FOOD_ITEM_COUNT).ToList();
        }

        private void btnPreItem_Click(object sender, RoutedEventArgs e)
        {
            int pageCount = orderViewModel.PageCount;

            if (pageCount > 0)
            {
                lbFood.ItemsSource = orderViewModel.GetSelectedCategoryFoods(
                    (pageCount - 1) * MAX_FOOD_ITEM_COUNT,
                    MAX_FOOD_ITEM_COUNT)
                    .ToList();
                orderViewModel.PageCount -= 1;
            }
        }

        private void btnNextItem_Click(object sender, RoutedEventArgs e)
        {
            int pageCount = orderViewModel.PageCount;

            List<Food> categoryFoods = orderViewModel.GetSelectedCategoryFoods();

            if (categoryFoods.Count > MAX_FOOD_ITEM_COUNT * (pageCount + 1))
            {
                lbFood.ItemsSource = orderViewModel.GetSelectedCategoryFoods(
                    (pageCount + 1) * MAX_FOOD_ITEM_COUNT,
                    MAX_FOOD_ITEM_COUNT)
                    .ToList();
                orderViewModel.PageCount += 1;
            }
        }

        private void lbFood_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbFood.SelectedIndex == -1) return;

            Food food = (Food)lbFood.SelectedItem;

            // 주문 음식에 추가
            orderViewModel.addOrderFood(food);
        }

        private void btnIncreaseOrderFood_Click(object sender, RoutedEventArgs e)
        {
            Button btnIncraseOrderFood = (Button)sender;
            OrderFood orderFood = (OrderFood)btnIncraseOrderFood.DataContext;

            orderViewModel.increaseOrderFoodCount(orderFood);
        }

        private void btnDecreaseOrderFood_Click(object sender, RoutedEventArgs e)
        {
            Button btnDecraseOrderFood = (Button)sender;
            OrderFood orderFood = (OrderFood)btnDecraseOrderFood.DataContext;

            orderViewModel.decreaseOrderFoodCount(orderFood);
        }
    }
}
