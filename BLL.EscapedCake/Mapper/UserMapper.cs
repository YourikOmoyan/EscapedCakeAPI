using BLL.EscapedCake.Entities;
using DAL.EscapedCake.Entities;

namespace BLL.EscapedCake.Mapper
{
    internal static partial class UserMapper
    {
        public static DUser ToDal(this BUser entity)
        {
            if (entity == null) return null;
            return new DUser() { Id=entity.Id, FirstName=entity.FirstName, LastName=entity.LastName, Email=entity.Email,Passwd=entity.Passwd,Phone=entity.Phone,CreatedDate=entity.CreatedDate };
        }

        public static BUser ToBll(this DUser entity)
        {
            if (entity == null) return null;
            return new BUser(entity.Id, entity.FirstName, entity.LastName, entity.Email, entity.Passwd, entity.Phone, entity.CreatedDate);
        }
    }
}
