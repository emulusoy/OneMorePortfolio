using Microsoft.AspNetCore.Mvc;
using OneMorePortfolio.Dal.Context;

namespace OneMorePortfolio.Controllers
{
    public class StatisticController : Controller
    {
        OneMorePortfolioContext context = new OneMorePortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            
            return View();
        }
    }
}
