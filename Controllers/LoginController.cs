using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace WebShopping.Controllers
{
    public class LoginController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
    }
}
