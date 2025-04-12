using Microsoft.AspNetCore.Mvc;
using OneMorePortfolio.Dal.Context;


namespace OneMorePortfolio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        OneMorePortfolioContext Context = new OneMorePortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = Context.Features.ToList();
            return View(values);
        }
    }
}
