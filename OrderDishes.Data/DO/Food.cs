namespace OrderDishes.Data.DO {
    /// <summary>
    /// 存储在数据库中的食物用的数据
    /// 包含名称、图片、价格、Id和一些标签
    /// </summary>
    public class Food {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public string PhotoName { get => $"{Id}-{Name}"; }
        public decimal Price { get; set; }
        public List<string> Tags { get; set; }
    }
}
