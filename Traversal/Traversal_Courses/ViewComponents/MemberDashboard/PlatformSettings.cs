using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.ViewComponents.MemberDashboard
{
    public class PlatformSettings:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            //var values = guideManager.TGetAll();

            return View();
        }
    }
}
