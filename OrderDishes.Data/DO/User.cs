namespace OrderDishes.Data.DO {
    public class User {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public UserType UserType { get; set; }
    }
}
