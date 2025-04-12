using Microsoft.AspNetCore.Mvc;

namespace OneMorePortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
