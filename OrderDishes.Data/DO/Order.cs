namespace OrderDishes.Data.DO {
    public class Order {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Guid> Breakfast { get; set; }
        public List<Guid> Lunch { get; set; }
        public List<Guid> Dinner { get; set; }
    }
}
