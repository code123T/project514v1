using Microsoft.AspNetCore.Mvc;

namespace WebShopping.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
