using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
namespace Traversal_Courses.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        private readonly UserManager<User> _userManager;

        public DashboardController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName=values.Name+" "+values.Surname;
            ViewBag.userImage = values.ImageUrl;
            return View();
        }
    }
}
