using Microsoft.AspNetCore.Mvc;

namespace OneMorePortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
