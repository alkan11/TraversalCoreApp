using System.ComponentModel.DataAnnotations;

namespace Traversal_Courses.Models
{
    public class UserSignIn
    {
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi  giriniz")]
        public string? Password { get; set; }


    }
}
