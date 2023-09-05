using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        TestimonialManager tmanager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = tmanager.TGetAll();
            return View(values);
        }
    }
}
