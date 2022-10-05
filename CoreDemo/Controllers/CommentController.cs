
using BusinessLayer.Concrete;
using CoreDemo.ViewComponents;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Windows.Markup;

namespace CoreDemo.Controllers
{
    
    public class CommentController : Controller
	{
        CommentManager cm = new CommentManager(new EfCommentRepository());
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IActionResult Index()
		{
            var values = cm.GetCommentWithBlog();
            return View(values);
        }
        [AllowAnonymous]
        [HttpGet]
		public  PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
        [AllowAnonymous]
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {          
            p.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			cm.CommentAdd(p);
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult CommentListByBlog(int id)
		{
			var values = cm.GetList(id);
			return PartialView(values);
		}
        public IActionResult CommentDelete(int id)
        {
            var value = cm.TGetById(id);
            cm.TDelete(value);
            return RedirectToAction("Index");
        }

    }
}
