using DAL.EscapedCake.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EscapedCake.Mapper
{
    internal static class CategoryMapper
    {
        internal static DCategory ToCategory(this IDataRecord record)
        {
            return new DCategory()
            {
                Id = (int)record["Id"],
                Name = (string)record["Name"],
            };
        }
    }
}
