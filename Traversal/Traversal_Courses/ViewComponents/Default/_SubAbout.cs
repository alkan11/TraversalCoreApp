using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.ViewComponents.Default
{
    public class _SubAbout:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());
            var values = subAboutManager.TGetAll();
            return View(values);
        }

    }
}
