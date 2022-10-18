using DAL.EscapedCake.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EscapedCake.Mapper
{
    internal static class ProductMapper
    {
        internal static DProduct ToProduct(this IDataRecord reader)
        {
            return new DProduct()
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Description = (string)reader["Description"],
                Price = reader["Price"] as double?,
                Photo = (string)reader["Photo"],
                Video = (string)reader["Video"],
                CategoryId = (int)reader["CategoryId"]


            };
        }
    }
}
