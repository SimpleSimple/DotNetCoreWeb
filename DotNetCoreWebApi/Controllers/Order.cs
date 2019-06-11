using System;

namespace DotNetCoreWebApi.Controllers
{
    public class Order
    {
        public long Id { get; set; }

        public string OrderName { get; set; }
        /// <summary>
        /// 订单创建人
        /// </summary>
        public long CreateId { get; set; }

        public DateTime CreateTime { get; set; }
    }
}