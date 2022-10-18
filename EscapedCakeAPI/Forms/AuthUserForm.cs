using System.ComponentModel.DataAnnotations;

namespace EscapedCakeAPI.Forms
{
    public class AuthUserForm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Passwd { get; set; }
    }
}
