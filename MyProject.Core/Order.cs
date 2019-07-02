using System;

namespace MyProject.Core
{
    public class Order: BaseEntity<long>
    {
        public string OrderNo { get; set; }

        public Customer Customer { get; set; }

        public Goods Goods { get; set; }

        public decimal Total { get; set; }

        public long CreateId { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
