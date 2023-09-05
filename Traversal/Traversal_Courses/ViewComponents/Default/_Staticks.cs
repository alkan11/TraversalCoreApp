using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.ViewComponents.Default
{
    public class _Staticks:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2=c.Guides.Count();
            ViewBag.v3 = "258";
            ViewBag.v4 = "10";
            
            return View();
        }
    }
}
