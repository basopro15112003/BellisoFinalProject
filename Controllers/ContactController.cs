using Microsoft.AspNetCore.Mvc;

namespace BellisoProject.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
