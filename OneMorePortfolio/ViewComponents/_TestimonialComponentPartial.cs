using Microsoft.AspNetCore.Mvc;

namespace OneMorePortfolio.ViewComponents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
