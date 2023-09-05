using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(EntityLayer.Concrete.Comment comment) 
        //{
        //    CommentManager commentManager = new CommentManager(new EfCommentDal());
        //    comment.CommentState = true;
        //    comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    commentManager.TAdd(comment);
        //    return View();
        //}
    }
}
