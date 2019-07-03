using MyProject.Core;
using System.Collections;

namespace DotNetCoreWeb.DTO
{
    public class GoodsOutput:BaseEntity<long>
    {
        public string Name { get; set; }

        public string Operate { get; set; }

        public GoodsOutput()
        {
        }
    }
}