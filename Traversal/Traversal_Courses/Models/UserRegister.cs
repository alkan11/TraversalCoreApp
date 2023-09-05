using System.ComponentModel.DataAnnotations;

namespace Traversal_Courses.Models
{
	public class UserRegister
	{
		[Required(ErrorMessage = "Lütfen adınızı giriniz")]
		public string? Name { get; set; }
		
		[Required(ErrorMessage = "Lütfen soyadınızı  giriniz")]
		public string? Surname { get; set; }
		
		[Required(ErrorMessage = "Lütfen kullanıcı Adınızı giriniz")]
		public string? UserName { get; set; }
		
		[Required(ErrorMessage = "Lütfen Mail adresinizi giriniz")]
		public string? Mail { get; set; }
		
		[Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
		
		public string? Password { get; set; }
		

		[Required(ErrorMessage = "Lütfen şifrenizi tekrar giriniz")]
		[Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil")]
		public string? ConfirmPassword { get; set; }
		
	}
}
