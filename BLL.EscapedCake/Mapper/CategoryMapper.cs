using BLL.EscapedCake.Entities;
using DAL.EscapedCake.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EscapedCake.Mapper
{
    public static partial  class CategoryMapper
    {
        public static DCategory ToDal(this BCategory entity)
        {
            if(entity == null) return null;
            return new DCategory() { Id = entity.Id, Name = entity.Name };
        }

       public static BCategory ToBll(this DCategory entity)
        {
            if (entity==null) return null;
            return new BCategory(entity.Id, entity.Name);

        }
    }
}
