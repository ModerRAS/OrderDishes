namespace OrderDishes.Data.DO {
    public class Food {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhotoName { get => $"{Id}-{Name}"; }
        public decimal Price { get; set; }
    }
}
