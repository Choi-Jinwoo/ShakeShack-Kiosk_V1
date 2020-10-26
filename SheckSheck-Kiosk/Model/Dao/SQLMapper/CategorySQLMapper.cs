using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.Model.Dao.SQLMapper
{
    class CategorySQLMapper
    {
        public static string FindAllSQL = "SELECT id, name FROM category;";
    }
}
