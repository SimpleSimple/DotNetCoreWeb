using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core
{
    public class Goods : BaseEntity<long>
    {
        public string Name { get; set; }
    }
}
