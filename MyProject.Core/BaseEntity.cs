using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}
