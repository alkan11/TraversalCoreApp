using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.ViewComponents.Default
{
    public class SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
