using OrderDishes.Data.Enums;

namespace OrderDishes.Data.DO {
    /// <summary>
    /// 存储在数据库中的每顿饭的食物列表和时间，早中晚饭
    /// </summary>
    public class Menu {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public MenuTime Time { get; set; }
        public List<Guid> Foods {  get; set; }
        public bool AlreadyStarted { get; set; }
    }
}
