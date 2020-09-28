using MySqlConnector;
using SheckSheck_Kiosk.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.Order.Model
{
    class CategoryDAO
    {
        public List<Category> GetCategories()
        {
            DBConnection connection = new DBConnection();
            connection.Connect();
            connection.OpenConnection();
            connection.SetCommand(OrderSQLMapper.getCategoriesSQL);
            MySqlDataReader reader = connection.ExecuteQuery();

            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.Id = Convert.ToInt32(reader["id"]);
                category.Name = Convert.ToString(reader["name"]);
                categories.Add(category);
            }

            connection.CloseConnection();

            return categories;
        }
    }
}
