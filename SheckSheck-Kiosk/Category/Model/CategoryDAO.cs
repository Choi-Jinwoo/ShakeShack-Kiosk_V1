using MySqlConnector;
using SheckSheck_Kiosk.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.Category.Model
{
    class CategoryDAO
    {
        public List<CategoryModel> GetCategories()
        {
            DBConnection connection = new DBConnection();
            connection.Connect();
            connection.OpenConnection();
            connection.SetCommand(CategorySQLMapper.GetCategoriesSQL);
            MySqlDataReader reader = connection.ExecuteQuery();

            List<CategoryModel> categories = new List<CategoryModel>();
            while (reader.Read())
            {
                CategoryModel category = new CategoryModel();
                category.Id = Convert.ToInt32(reader["id"]);
                category.Name = Convert.ToString(reader["name"]);
                categories.Add(category);
            }

            connection.CloseConnection();

            return categories;
        }
    }
}
