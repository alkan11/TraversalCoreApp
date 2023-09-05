using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Traversal_Courses.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            //YoRum Ekleme Videosunda kaldım
            CommentManager commentManager = new CommentManager(new EfCommentDal());
            var values = commentManager.TGetDestinationById(id);
            ViewBag.CommentCount=values.Count();
            return View(values);
        }

    }
}
