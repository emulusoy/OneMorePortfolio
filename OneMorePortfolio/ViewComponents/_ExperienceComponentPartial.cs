using Microsoft.AspNetCore.Mvc;

using OneMorePortfolio.Dal.Context;

namespace OneMorePortfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        OneMorePortfolioContext context = new OneMorePortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
    }
}
