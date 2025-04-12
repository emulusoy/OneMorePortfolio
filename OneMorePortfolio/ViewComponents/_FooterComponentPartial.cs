using Microsoft.AspNetCore.Mvc;

namespace OneMorePortfolio.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
