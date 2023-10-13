namespace OrderDishes.Data.DO {
    public class Order {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Canteen { get; set; }
        public string User { get; set; }
        public MenuTime MenuTime { get; set; }
        /// <summary>
        /// 用`List<Food>`的原因是保留当时的订单相关的食物的原始数据
        /// </summary>
        public List<Food> Foods { get; set; }
    }
}
