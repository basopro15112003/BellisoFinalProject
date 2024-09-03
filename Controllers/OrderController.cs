using Microsoft.AspNetCore.Mvc;

namespace BellisoProject.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CheckOut()
        {
            return View();
        }
    }
}
