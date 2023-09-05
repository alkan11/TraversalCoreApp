using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.ViewComponents.MemberDashboard
{
    public class GuideList:ViewComponent
    {
        GuideManager guideManager=new GuideManager(new EfGuideDal());
        public IViewComponentResult Invoke()
        {

            var values = guideManager.TGetAll();

            return View(values);
        }
    }
}
