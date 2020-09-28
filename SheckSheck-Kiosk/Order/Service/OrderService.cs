using SheckSheck_Kiosk.Category.Model;
using SheckSheck_Kiosk.Category.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.Order.Service
{
    class OrderService
    {
        private readonly CategoryService categoryService = new CategoryService();

        public readonly List<CategoryModel> Categories;

        public OrderService()
        {
            Categories = categoryService.GetCategories();
        }
    }
}
