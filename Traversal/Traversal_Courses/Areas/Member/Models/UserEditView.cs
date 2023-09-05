using System.ComponentModel.DataAnnotations;

namespace Traversal_Courses.Areas.Member.Models
{
	public class UserEditView
	{

		public string? Name { get; set; }


		public string? Surname { get; set; }

		public string? Password { get; set; }

		public string? ImageUrl { get; set; }
		public string? Phone { get; set; }
		public string? Mail { get; set; }
		public string? ConfirmPassword { get; set; }
		public IFormFile Image { get; set; }
	}
}
