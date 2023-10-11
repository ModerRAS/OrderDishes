using OrderDishes.Data.DO;

namespace OrderDishes.Data.DTO {
    public class Menu {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public List<Food> Breakfast { get; set; }
        public List<Food> Lunch { get; set; }
        public List<Food> Dinner { get; set; }
    }
}
