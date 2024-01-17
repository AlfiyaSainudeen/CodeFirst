using System.ComponentModel.DataAnnotations;
namespace HandsOnAPIUsingModelValidation.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Please Enter username")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Please enter Password")]
        public string Password { get; set; }
    }
}
