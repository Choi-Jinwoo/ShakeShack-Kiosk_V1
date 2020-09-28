using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.Order
{
    class OrderSQLMapper
    {
        public static string getCategoriesSQL = "SELECT id, name FROM category;";
    }
}
