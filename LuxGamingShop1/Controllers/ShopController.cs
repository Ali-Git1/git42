using Microsoft.AspNetCore.Mvc;

namespace LuxGamingShop1.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
