﻿using SheckSheck_Kiosk.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheckSheck_Kiosk.ViewModel
{
    class OrderFoodViewModel : INotifyPropertyChanged
    {
        private static OrderFoodViewModel instance;
        private OrderFoodViewModel() { }

        public static OrderFoodViewModel Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderFoodViewModel();
                }
                return instance;
            }
        }

        public ObservableCollection<OrderFood> OrderFoods { get; } = new ObservableCollection<OrderFood>();

        private int orderFoodTotalPrice { get; set; } = 0;
        public int OrderFoodTotalPrice
        {
            get => orderFoodTotalPrice;
            private set
            {
                orderFoodTotalPrice = value;
                OnPropertyChanged("OrderFoodTotalPrice");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private int CalcOrderFoodTotalPrice()
        {
            int totalPrice = 0;
            foreach (OrderFood orderFood in OrderFoods)
            {
                totalPrice += orderFood.TotalPrice;
            }

            return totalPrice;
        }
        private OrderFood GetExistFood(Food food)
        {
            foreach (OrderFood orderFood in OrderFoods)
            {
                if (orderFood.Food.Equals(food))
                {
                    return orderFood;
                }
            }

            return null;
        }

        public void IncreaseOrderFood(OrderFood orderFood)
        {
            orderFood.Count += 1;
            OrderFoodTotalPrice = CalcOrderFoodTotalPrice();
        }
        public void DecreaseOrderFood(OrderFood orderFood)
        {
            if (orderFood.Count <= 1)
            {
                OrderFoods.Remove(orderFood);
            } else
            {
                orderFood.Count -= 1;
            }
            OrderFoodTotalPrice = CalcOrderFoodTotalPrice();
        }

        public int OrderFoodSize => OrderFoods.Count;
        // 매개변수로 Food를 받는 것이 옳은가?
        public void AddOrderFood(Food food)
        {
            OrderFood existOrderFood = GetExistFood(food);

            // 해당 음식 존재하지 않는다면 리스트에 추가
            if (existOrderFood == null)
            {
                OrderFoods.Add(new OrderFood(food));
            } else
            {
                existOrderFood.Count += 1;
            }
            OrderFoodTotalPrice = CalcOrderFoodTotalPrice();
        }
        public void RemoveOrderFood(OrderFood orderFood)
        {
            OrderFoods.Remove(orderFood);
            OrderFoodTotalPrice = CalcOrderFoodTotalPrice();
        }
        public void RemoveAllOrderFood()
        {
            OrderFoods.Clear();
            OrderFoodTotalPrice = CalcOrderFoodTotalPrice();
        }
    }
}
