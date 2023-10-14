﻿using OrderDishes.Data.DO;

namespace OrderDishes.Data.DTO {
    public class Menu {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public MenuTime Time { get; set; }
        public List<Food> Foods { get; set; }
    }
}