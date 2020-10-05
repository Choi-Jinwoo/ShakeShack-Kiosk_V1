using SheckSheck_Kiosk.Model;
using SheckSheck_Kiosk.Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.ViewModel
{
    class OrderViewModel
    {
        private CategoryDao categoryDao = new CategoryDao();
        private FoodDao foodDao = new FoodDao();

        public List<Category> categories { get; set; }
        public List<Food> foods { get; set; }

        public OrderViewModel()
        {
            categories = categoryDao.GetCategories();
            
            // 카테고리가 없다면 음식 리스트에 빈배열, 존재한다면 가장 처음 카테고리의 음식으로 초기화
            if (categories.Count <= 0)
            {
                foods = new List<Food>();
            }
            else
            {
                foods = foodDao.GetFoodsByCategory(categories[0].Id);
            }
            // TODO: 음식 리스트 뷰 부분 만들기, 이미지 관련 처리 및 카테고리 선택 시 리스트 변경
        }
    }
}
