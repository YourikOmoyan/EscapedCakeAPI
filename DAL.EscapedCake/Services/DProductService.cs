using DAL.EscapedCake.Entities;
using System;
using DBconnectionTool;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EscapedCake.Mapper;

namespace DAL.EscapedCake.Services
{
    public class DProductService
    {
        private readonly DbConnection _connection;

        public DProductService(DbConnection connection)
        {
            _connection = connection;
        }


        public int NewProduct(DProduct entity)
        {
            try
            {
               return _connection.ExecuteNonQuery("YSP_newProduct", true, new { entity.Name, entity.Description, entity.Price, entity.Photo, entity.Video, entity.CategoryId });
            }
            catch (Exception ex)
            {
                throw;
            }
        }
      
        public IEnumerable<DProduct> GetProducts()
        {
            using (_connection)
            {
                return _connection.ExecuteReader("YSP_GetProductList", dr => dr.ToProduct()).ToList();
            }
        }


        public DProduct? GetSingleProduct(int id)
        {
            using (_connection)
            {
                return _connection.ExecuteReader($"exec YSP_GetProductById {id}", dr => dr.ToProduct()).SingleOrDefault();
            }
        }


        public IEnumerable<DProduct> GetDProductsByCategory()
        {
            using (_connection)
            {
                return _connection.ExecuteReader("YSP_GetProductByCategory", dr => dr.ToProduct()).ToList();
            }
        }



        public void UpdateProduct(int id, DProduct entity)
        {
            try
            {
                 _connection.ExecuteScalar("YSP_updateProduct", true, new  {id, entity.Name, entity.Description, entity.Price, entity.Photo, entity.Video, entity.CategoryId });
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
