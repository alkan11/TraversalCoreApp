using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Traversal_Courses.Areas.Member.Controllers
{
    [Area("Member")]
    public class RezervationController:Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        RezervationManager rezervationManager = new RezervationManager(new EfRezervationDal());
        private readonly UserManager<User> _userManager;

        public RezervationController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentRezervation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = rezervationManager.GetListWithRezervationBywithAccepted(values.Id);
            return View(result);
        }
        public async Task<IActionResult> MyOldRezervation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = rezervationManager.GetListWithRezervationBywithPrevious(values.Id);
            return View(result);
        }
        [AllowAnonymous]
        public async Task<IActionResult> MyApprovalRezervation() 
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var result = rezervationManager.GetListWithRezervationBywithApproval(values.Id);
            return View(result);
        }
        [HttpGet]
        public IActionResult NewRezervation()
        {
            List<SelectListItem> list=(from x in destinationManager.TGetAll()
                                       select new SelectListItem
                                       {
                                           Text=x.City,
                                           Value=x.DestinationID.ToString()
                                       }).ToList();
            ViewBag.v = list;
            return View();
        }

        [HttpPost]
        public IActionResult NewRezervation(Rezervation r)
        {
            r.UserId = 1;
            r.Status = 0;//Onay bekliyor
            rezervationManager.TAdd(r);
            return RedirectToAction("MyCurrentRezervation");
        }
    }
}
