namespace OrderDishes.Data {
    public class LogJson {
        public string DateTime { get; set; }
        public string LogLevel { get; set; }
        public string LogName { get; set; }
        public int EventId { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; } 
    }
}
