using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EscapedCake.Entities
{
    public class DProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public string Photo { get; set; }
        public string Video { get; set; }
        public int CategoryId { get; set; }


    }
}
