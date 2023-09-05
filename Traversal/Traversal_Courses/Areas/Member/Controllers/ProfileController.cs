using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal_Courses.Areas.Member.Models;

namespace Traversal_Courses.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<User> _userManager;

        public ProfileController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditView uew = new UserEditView();
            uew.Name = values.Name;
            uew.Surname = values.Surname;
            uew.Mail = values.Email;
            uew.Phone = values.PhoneNumber;
            return View(uew);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditView uew)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (uew.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension=Path.GetExtension(uew.Image.FileName);
                var imagename=Guid.NewGuid()+extension;
                var savelocation = resource + "/wwwroot/UserImage/" + imagename;
                var stream = new FileStream(savelocation,FileMode.Create);
                await uew.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            user.Name = uew.Name;
            user.Surname=uew.Surname;
            user.PasswordHash=_userManager.PasswordHasher.HashPassword(user,uew.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SingIn", "Login");
            }
            return View();
        }
    }
}
