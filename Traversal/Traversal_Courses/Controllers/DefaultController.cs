using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
