using OrderDishes.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDishes.Data.DTO {
    public class UserSession {
        public string JWTToken { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string PubKey { get; set; } = string.Empty;
        public UserType UserType { get; set; } = UserType.User;
    }
}
