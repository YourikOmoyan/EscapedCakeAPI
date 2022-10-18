using BLL.EscapedCake.Entities;
using BLL.EscapedCake.Services;
using EscapedCakeAPI.Forms;
using Microsoft.AspNetCore.Mvc;
namespace EscapedCakeAPI.Controllers
{


    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController : ControllerBase 
    {
        private readonly BProductService _service;

        public ProductController(BProductService productService)
        {
            _service = productService;
        }



        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            try
            {
                List<BProduct> products = _service.GetProducts().ToList();
                return Ok(products);
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


        [HttpGet("GetOne")]
        public IActionResult GetOne(int id)
        {
            try
            {
                BProduct? product = _service.GetSingleProduct(id);
                return Ok(product);
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
      
        [HttpPost("AddProduct")]
        public IActionResult Post([FromBody] AddProductForm product)
        {
            try
            {
                int rows = _service.NewProduct(new BProduct( product.Name, product.Description, product.Price, product.Photo, product.Video, product.CategoryId));
                if (rows == 0)
                    return BadRequest();
                return NoContent();
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



        [HttpPut("UpdateProduct")]
        public IActionResult Update(UpdateProductForm form)
        {
            try
            {
               _service.UpdateProduct( form.Id, new BProduct( form.Name, form.Description, form.Price,form.Photo,form.Video, form.CategoryId));
                return NoContent();
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







    }

}
