using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager=new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {

            var values = featureManager.TGetAll();

            return View(values);
        }
    }
}
