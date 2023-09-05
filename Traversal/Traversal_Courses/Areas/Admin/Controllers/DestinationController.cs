using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager _destination = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
             
            var values = _destination.TGetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination() 
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination model)
        {
            _destination.TAdd(model);
            return RedirectToAction("Index");
        }
       
        public IActionResult DeleteDestination(int id)
        {
            var values=_destination.TGetById(id);
            _destination.TRemove(values);
            return RedirectToAction("Index","Destination","Admin");
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destination.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateDestination(Destination model)
        {
            _destination.TUpdate(model);
            return RedirectToAction("Index");
        }
    }
}
