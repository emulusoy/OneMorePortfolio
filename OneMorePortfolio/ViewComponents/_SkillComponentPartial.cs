using Microsoft.AspNetCore.Mvc;
using OneMorePortfolio.Dal.Context;


namespace OneMorePortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        OneMorePortfolioContext context = new OneMorePortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
