using System.ComponentModel.DataAnnotations;

namespace EscapedCakeAPI.Forms
{
    public class UpdateProductForm
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public float? Price { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public string Video { get; set; }
        [Required]
        public int CategoryId { get; set; }


    }
}
