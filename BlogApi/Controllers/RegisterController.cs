using BlogApi.DTO;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpDto p)
        {
                AppUser user = new AppUser()
                {
                    Email = p.Mail,
                    UserName = p.UserName,
                    NameSurname = p.NameSurname

                };
                var result = await _userManager.CreateAsync(user, p.Password);
                
                return Ok(result);
             
            
        }
    }
}
