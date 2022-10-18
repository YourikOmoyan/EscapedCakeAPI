using BLL.EscapedCake.Entities;
using BLL.EscapedCake.Mapper;
using DAL.EscapedCake.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EscapedCake.Services
{
    public class BCategoryService
    {
        private readonly DCategoryService _categoryService;

        public BCategoryService(DCategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public void AddCategory(BCategory entity)
        {
            _categoryService.AddCategory(entity.ToDal());
        }

        public IEnumerable<BCategory> GetBCategories()
        {
            return _categoryService.GetCategories().Select(cat => cat.ToBll());
        }
    }
}
