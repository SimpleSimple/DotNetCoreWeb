using System;

namespace MyProject.Core
{
    public class Customer: BaseEntity<long>
    {
        public string Name { get; set; }

        public byte Status { get; set; }

        //public long CreateId { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
