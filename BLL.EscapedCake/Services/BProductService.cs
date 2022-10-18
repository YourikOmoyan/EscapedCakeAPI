using BLL.EscapedCake.Entities;
using BLL.EscapedCake.Mapper;
using DAL.EscapedCake.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal = DAL.EscapedCake.Services;

namespace BLL.EscapedCake.Services
{
    public class BProductService
    {
        private readonly Dal.DProductService _dalService;

        public BProductService(Dal.DProductService dalService)
        {
            _dalService = dalService;
        }

        //Add new product
        public int NewProduct(BProduct product)
        {
           return _dalService.NewProduct(product.toDal());
        }

        //Get product list
        public IEnumerable<BProduct> GetProducts()
        {
            return _dalService.GetProducts().Select(pr => pr.toBll());
        }

        //Get sigle
        public BProduct? GetSingleProduct(int id)
        {
            return _dalService.GetSingleProduct(id)?.toBll();
        }

        //Get by category
        public IEnumerable<BProduct> GetProductsByCategory()
        {
            return _dalService.GetDProductsByCategory().Select(pr => pr.toBll());
        }

        //Update product
        public void UpdateProduct(int id, BProduct product)
        {
             _dalService.UpdateProduct(id,product.toDal());
        }










    }
}
