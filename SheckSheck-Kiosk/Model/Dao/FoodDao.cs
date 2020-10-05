using MySqlConnector;
using SheckSheck_Kiosk.Model.Dao.SQLMapper;
using SheckSheck_Kiosk.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.Model.Dao
{
    class FoodDao
    {
        public List<Food> GetFoods()
        {
            DBConnection connection = new DBConnection();

            connection.Connect();
            connection.SetCommand(FoodSQLMapper.FindAllSQL);

            MySqlDataReader reader = connection.ExecuteQuery();

            List<Food> foods = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    CategoryId = Convert.ToInt32(reader["category_id"]),
                    Name = Convert.ToString(reader["name"]),
                    ImagePath = Convert.ToString(reader["image_path"]),
                    Price = Convert.ToInt32(reader["price"])
                };

                foods.Add(food);
            }

            connection.CloseConnection();
            return foods;
        }

        public List<Food> GetFoodsByCategory(int categoryId)
        {
            DBConnection connection = new DBConnection();

            connection.Connect();
            connection.SetCommand(FoodSQLMapper.FindAllByCategorySQL(categoryId));

            MySqlDataReader reader = connection.ExecuteQuery();

            List<Food> foods = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food()
                {
                    Id = Convert.ToInt32(reader["id"]),
                    CategoryId = Convert.ToInt32(reader["category_id"]),
                    Name = Convert.ToString(reader["name"]),
                    ImagePath = Convert.ToString(reader["image_path"]),
                    Price = Convert.ToInt32(reader["price"])
                };

                foods.Add(food);
            }

            connection.CloseConnection();
            return foods;
        }
    }
}
