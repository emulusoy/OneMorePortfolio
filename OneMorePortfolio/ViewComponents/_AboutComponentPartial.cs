using Microsoft.AspNetCore.Mvc;
using OneMorePortfolio.Dal.Context;

namespace OneMorePortfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        OneMorePortfolioContext context = new OneMorePortfolioContext();
        public IViewComponentResult Invoke()
        {

            ViewBag.aboutTitle = context.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription= context.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail= context.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
