using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDishes.Data.DTO {
    /// <summary>
    /// 这个不用入库,直接用私钥加密一下之后塞进客户端的本地存储就行.
    /// </summary>
    public class AuthToken {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ExpirationTime { get; set; }

    }
}
