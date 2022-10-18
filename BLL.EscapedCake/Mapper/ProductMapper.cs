using BLL.EscapedCake.Entities;
using DAL.EscapedCake.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EscapedCake.Mapper
{
    public static partial class ProductMapper
    {

        public static DProduct toDal(this BProduct entity)
        {
            if (entity is null) return null;
            return new DProduct() { Id = entity.Id, Name = entity.Name, Description = entity.Description,
                                   Price = entity.Price, Photo = entity.Photo, 
                                   Video = entity.Video, CategoryId = entity.CategoryId};
        }

        public static BProduct toBll(this DProduct entity)
        {
            if (entity is null) return null;
            return new BProduct(entity.Id, entity.Name, entity.Description, entity.Price,
                                entity.Photo, entity.Video, entity.CategoryId);
        }


    }
}
