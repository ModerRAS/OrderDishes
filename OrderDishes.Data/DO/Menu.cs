namespace OrderDishes.Data.DO {
    public class Menu {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public MenuTime Time { get; set; }
        public List<Guid> Foods {  get; set; }
        public bool AlreadyStarted { get; set; }
    }
}
