using OrderDishes.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDishes.Data.DTO {
    public class TotalOrder {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public MenuTime Time { get; set; }

    }
}
