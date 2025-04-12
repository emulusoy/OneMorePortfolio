using Microsoft.AspNetCore.Mvc;

namespace OneMorePortfolio.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
