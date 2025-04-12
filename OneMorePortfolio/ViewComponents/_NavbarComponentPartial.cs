using Microsoft.AspNetCore.Mvc;

namespace OneMorePortfolio.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
