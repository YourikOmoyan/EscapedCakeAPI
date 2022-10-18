using BLL.EscapedCake.Entities;
using BLL.EscapedCake.Services;
using EscapedCakeAPI.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EscapedCakeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly BCategoryService _service;

        public CategoryController(BCategoryService service)
        {
            _service = service;
        }

        [HttpGet("GetCategories")]
        public IActionResult GetCategories()
        {
            try
            {
                List<BCategory> categories = _service.GetBCategories().ToList();
                return Ok(categories);
            }
            catch (Exception ex)
            {
#if DEBUG
                return BadRequest(new { Message = ex.Message });
#else
                return BadRequest(new { Message = "Erreur durant le traitement, contactez l'admin..." });
#endif
            }
        }

        [HttpPost("AddCategory")] 

        public IActionResult AddCategory([FromBody] AddCategoryForm form)
        {
            try
            {
                _service.AddCategory(new BCategory(form.Name));
                return NoContent();
            }
            catch (Exception ex)
            {
#if DEBUG
                return BadRequest(new { Message = ex.Message });
#else
                return BadRequest(new { Message = "Quelque chose n'a pas fonctionné lors de l'enregistrement... Contactez l'administrateur du site" });
#endif
            }
        }

    }
}
