using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDishes.Data.DO {
    public class CanteenList {
        public required HashSet<string> Canteens { get; set; }
    }
}
