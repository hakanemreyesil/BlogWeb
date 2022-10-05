using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        BlogManager _blogManager= new BlogManager(new EfBlogRepository());
        //private readonly BlogManager _blogManager;
       

        //public BlogController(BlogManager blogManager)
        //{
        //    _blogManager = blogManager;
            
        //}
        [HttpGet]
        public IActionResult ListBlog()
        {
            var values = _blogManager.GetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBlog(Blog p)
        {
            using var c = new Context();   
            c.Add(p);
            c.SaveChanges();
            return Ok();

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            using var c = new Context();
            var value = c.Blogs.Find(id);
            if(value == null)
            {
                return NotFound();
            }
            else
            {
                c.Blogs.Remove(value);
                c.SaveChanges();
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult EditBlog(Blog p)
        {
            using var c = new Context();
            var value = c.Blogs.Find(p.BlogID);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                value.BlogContent = p.BlogContent;
                value.BlogStatus=true;
                value.BlogTitle=p.BlogTitle;
                value.BlogImage=p.BlogImage;
                value.BlogCreateDate= DateTime.Parse(DateTime.Now.ToShortDateString());
                value.CategoryID=p.CategoryID;
                value.WriterID = p.WriterID;
                c.Blogs.Update(value);
                c.SaveChanges();
                return Ok();
            }
        }

    }
}
