namespace OrderDishes.Data.DO {
    public class Order {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid Canteen {  get; set; }
        public MenuTime MenuTime { get; set; }
        public List<Guid> Dishes { get; set; }
    }
}
