using SheckSheck_Kiosk.Model;
using SheckSheck_Kiosk.Model.Dao;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SheckSheck_Kiosk.ViewModel
{
    class OrderViewModel
    {
        private CategoryDao categoryDao = new CategoryDao();
        private FoodDao foodDao = new FoodDao();

        public List<Category> Categories { get; set; }
        public List<Food> Foods { get; set; }
        public int PageCount { get; set; } = 0;
        public Category SelectedCategory { get; set; }
        public ObservableCollection<OrderFood> OrderFoods { get; set; } = new ObservableCollection<OrderFood>();


        public OrderViewModel()
        {
            Categories = categoryDao.GetCategories();
            Foods = foodDao.GetFoods();

            if (Categories.Count > 0)
            {
                SelectedCategory = Categories[0];
            }
        }

        public List<Food> GetSelectedCategoryFoods() => Foods.Where(x => x.CategoryId == SelectedCategory.Id).ToList();
        public List<Food> GetSelectedCategoryFoods(int takeCount) {
            List<Food> foods = Foods
                                .Where(x => x.CategoryId == SelectedCategory.Id)
                                .Take(takeCount)
                                .ToList();
            return foods;
        }
        public List<Food> GetSelectedCategoryFoods(int skipCount, int takeCount) => Foods
                                .Where(x => x.CategoryId == SelectedCategory.Id)
                                .Skip(skipCount)
                                .Take(takeCount)
                                .ToList();
        public void addOrderFood(Food food)
        {
            foreach (OrderFood orderFood in OrderFoods)
            {
                if (orderFood.Food.Equals(food)) return;
            }

            OrderFood newOrderFood = new OrderFood() { Food = food };
            OrderFoods.Add(newOrderFood);
        }
        public void increaseOrderFoodCount(OrderFood orderFood)
        {
            orderFood.Count += 1;
        }
        public void decreaseOrderFoodCount(OrderFood orderFood)
        {
            // 주문 개수가 1개 이하인 주문음식을 경우
            if (orderFood.Count <= 1)
            {
                OrderFoods.Remove(orderFood);
            } else
            {
                orderFood.Count -= 1;
            }
        }
    }
}
