using Microsoft.AspNetCore.Mvc;

namespace OneMorePortfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
