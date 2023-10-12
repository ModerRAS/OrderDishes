namespace OrderDishes.Data.DO {
    public class Menu {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public List<Guid> Breakfast {  get; set; }
        public List<Guid> Lunch { get; set; }
        public List<Guid> Dinner { get; set; }
    }
}
