using Microsoft.AspNetCore.Mvc;

namespace BellisoProject.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
