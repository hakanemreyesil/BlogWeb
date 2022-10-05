using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        CommentManager _commentManager = new CommentManager(new EfCommentRepository());
        [HttpGet]
        public IActionResult ListComment()
        {
            var values = _commentManager.GetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult ListComment(int id)
        {
            //blog idsine göre getiriyor
            var values = _commentManager.GetList(id);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBlog(Comment p)
        {
            using var c = new Context();
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            c.Add(p);
            c.SaveChanges();
            return Ok();

        }
        [HttpDelete]
        public IActionResult DeleteComment(int id)
        {
            var value = _commentManager.TGetById(id);
            _commentManager.TDelete(value);
            return Ok();
        }
    }
}
