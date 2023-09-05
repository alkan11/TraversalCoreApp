using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.Controllers
{
    public class CommentController:Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

        [HttpGet]
        public PartialViewResult AddComment()
        {

            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment c)
        {
            c.CommentState = true;
            c.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            commentManager.TAdd(c);
            return RedirectToAction("Index","Destination");
        }
    }
}
