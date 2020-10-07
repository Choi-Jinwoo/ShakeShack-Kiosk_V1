using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.Model.Dao.SQLMapper
{
    class FoodSQLMapper
    {
        public static string FindAllSQL = "SELECT id, category_id, name, image_path, price FROM food;";
        public static string FindAllByCategorySQL(int categoryId) 
        {
            return string.Format("SELECT id, category_id, name, image_path, price FROM food WHERE category_id = {0};", categoryId);
        }
    }
}
