using SheckSheck_Kiosk.Category.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.Category.Service
{
    class CategoryService
    {
        private CategoryDAO categoryDAO = new CategoryDAO();

        public List<CategoryModel> GetCategories()
        {
            return categoryDAO.GetCategories();
        }
    }
}
