using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
