using Microsoft.AspNetCore.Mvc;

namespace OneMorePortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
