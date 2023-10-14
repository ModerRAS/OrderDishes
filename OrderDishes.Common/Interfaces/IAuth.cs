using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDishes.Common.Interfaces {
    public interface IAuth {
        public bool Add(string content);
        public bool Remove(string content);
        public bool Has(string content);
        public string CreateToken(string content);
    }
}
