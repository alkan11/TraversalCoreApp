using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            
            var values = destinationManager.TGetAll();
            return View(values);
            
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id) 
        {
            var values=destinationManager.TGetById(id);
            ViewBag.id = id;
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination d)
        {
            return View();
        }
    }
}
