using Microsoft.AspNetCore.Mvc;

namespace WebShopping.Controllers
{
    public class ShopController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
