using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EscapedCakeAPI.Forms
{
    public class AddUserForm
    {

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Passwd { get; set; }  
        public int Phone { get; set; }

    }
}
