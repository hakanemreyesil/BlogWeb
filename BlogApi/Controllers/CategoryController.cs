using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());
        [HttpGet]
        public IActionResult ListCategory()
        {
            var values = _categoryManager.GetList();
            return Ok(values);
        }
    }
}
