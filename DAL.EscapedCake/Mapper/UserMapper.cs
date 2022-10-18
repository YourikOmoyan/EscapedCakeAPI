using DAL.EscapedCake.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EscapedCake.Mapper
{
    internal static class UserMapper
    {
       internal static DUser ToUser(this IDataRecord reader)
        {
            return new DUser()
            {
                Id = (int)reader["Id"],
                FirstName = (string)reader["FirstName"],
                LastName = (string)reader["LastName"],
                Email = (string)reader["Email"],
                Passwd = (string)reader["Passwd"],
                Phone = (int)reader["Phone"],
                CreatedDate = (DateTime)reader["CreatedDate"]
            };
        }
    }
}
