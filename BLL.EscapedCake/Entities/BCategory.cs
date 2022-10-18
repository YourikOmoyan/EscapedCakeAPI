using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EscapedCake.Entities
{
    public class BCategory
    {

        public int Id { get; init; }
        public string Name { get; init; }


        public BCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public BCategory(string name)
        {
            Name = name;
        }
    }
}
