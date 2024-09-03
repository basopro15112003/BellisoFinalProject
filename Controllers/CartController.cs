using Microsoft.AspNetCore.Mvc;

namespace BellisoProject.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
