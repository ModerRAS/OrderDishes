using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDishes.Data.DO {
    public class UserList {
        public required HashSet<string> Users { get; set; }
    }
}
