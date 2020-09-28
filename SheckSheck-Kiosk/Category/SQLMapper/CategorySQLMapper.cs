using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.Category
{
    class CategorySQLMapper
    {
        public static string GetCategoriesSQL = "SELECT id, name FROM category;";
    }
}
