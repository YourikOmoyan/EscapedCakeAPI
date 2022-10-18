using DAL.EscapedCake.Entities;
using DAL.EscapedCake.Mapper;
using DBconnectionTool;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EscapedCake.Services
{
    public class DCategoryService
    {
        private readonly DbConnection _connection;

        public DCategoryService(DbConnection connection)
        {
            _connection = connection;
        }

        public void AddCategory(DCategory entity)
        {
            try
            {
                _connection.ExecuteNonQuery("YSP_newCategory", true, new { entity.Name });
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IEnumerable<DCategory> GetCategories()
        {
            using (_connection)
            {
                return _connection.ExecuteReader("YSP_GetCategoryList", dr => dr.ToCategory()).ToList();
            }
        }





    }
}
