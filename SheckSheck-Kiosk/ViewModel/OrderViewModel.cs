using SheckSheck_Kiosk.Model;
using SheckSheck_Kiosk.Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SheckSheck_Kiosk.ViewModel
{
    class OrderViewModel
    {
        private CategoryDao categoryDao = new CategoryDao();
        private FoodDao foodDao = new FoodDao();

        public List<Category> Categories { get; set; }
        public List<Food> Foods { get; set; }

        public OrderViewModel()
        {
            Categories = categoryDao.GetCategories();
            Foods = foodDao.GetFoods();
        }
    }
}
