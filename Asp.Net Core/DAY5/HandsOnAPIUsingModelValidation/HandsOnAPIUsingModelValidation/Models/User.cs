using System.ComponentModel.DataAnnotations;
namespace HandsOnAPIUsingModelValidation.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Enetr Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enetr Gender")]
       
        [Range(18,90,ErrorMessage ="Age between 18 to 90")]
        public int Age { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enetr Email")]
        [EmailAddress(ErrorMessage ="Invalid EmailId")]//validate input value with email format
        public string Email { get; set; }
        [Required(ErrorMessage = "Enetr Mobile")]
        [RegularExpression("[6-9]\\d{9}",ErrorMessage ="Invalid Mobile no")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Enetr username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Enetr Password")]
        [RegularExpression("[a-zA-z0-9]{6,8}", ErrorMessage = "Invalid Mobile no")]
        public string Password { get; set; }

    }
}
