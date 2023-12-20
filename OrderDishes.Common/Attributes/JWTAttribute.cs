using OrderDishes.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDishes.Common.Attributes {
    public class JWTAttribute : Attribute {
        public UserType UserType { get; private set; }
        public JWTAttribute(UserType userType) {
            UserType = userType;
        }
    }
}
