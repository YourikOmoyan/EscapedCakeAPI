using System.ComponentModel.DataAnnotations;

namespace EscapedCakeAPI.Forms
{
    public class AddCategoryForm
    {
        [Required]
        public string Name { get; set; }
    }
}
