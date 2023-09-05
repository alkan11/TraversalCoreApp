using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal_Courses.Models;

namespace Traversal_Courses.Controllers
{
    [AllowAnonymous]
    public class LoginController:Controller
    {
        private readonly UserManager<User> _usermanager;
        private readonly SignInManager<User> _signInManager;

        public LoginController(UserManager<User> usermanager, SignInManager<User> signInManager)
        {
            _usermanager = usermanager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SingUp()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SingUp(UserRegister u)
        {
            User user = new User()
            {
                Name = u.Name,
                Surname = u.Surname,
                Email = u.Mail,
                UserName = u.UserName,
            };
            if (u.Password == u.ConfirmPassword)
            {
                var result=await _usermanager.CreateAsync(user,u.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SingIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(u);
        }
        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SingIn(UserSignIn us)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(us.Username, us.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile",new {area="Member"});
                }
                else
                {
                    return RedirectToAction("SingIn", "Login");
                }
            }
            return View();
        }

    }
}
