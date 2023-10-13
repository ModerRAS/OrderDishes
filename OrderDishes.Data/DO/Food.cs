namespace OrderDishes.Data.DO {
    public class Food {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string PhotoName { get => $"{Id}-{Name}"; }
        public decimal Price { get; set; }
        public List<string> Tags { get; set; }
    }
}
