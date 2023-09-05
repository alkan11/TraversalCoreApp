using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.ViewComponents.MemberDashboard
{
    public class ProfileInformation:ViewComponent
    {

        private readonly UserManager<User> _userManager;

        public ProfileInformation(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userName = values.Name + " " + values.Surname;
            ViewBag.phone = values.PhoneNumber;
            ViewBag.email= values.Email;
            ViewBag.Loc = "Bursa";

            return View();
        }
    }
}
