using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace CoreDemo.Areas.Admin.Controllers
{
    public class WidgetController : Controller
    {
        [Area("Admin")]
        [Authorize(Roles = "Admin,Moderator")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
