using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Entities;
using OneMorePortfolio.Dal.Context;

namespace OneMorePortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        OneMorePortfolioContext context=new OneMorePortfolioContext();
        public IActionResult ExperienceList()
        {
            var experiences = context.Experiences.ToList();
            return View(experiences);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList", "Experience");  
        }
        public IActionResult DeleteExperience(int id)
        {
            var val=context.Experiences.Find(id);
            context.Experiences.Remove(val);
            context.SaveChanges();
            return RedirectToAction("ExperienceList", "Experience");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var val = context.Experiences.Find(id);
            return View(val);
        }
        [HttpPost]

        public IActionResult UpdateExperience(Experience exp)
        {
          
            context.Experiences.Update(exp);
            context.SaveChanges();
            return RedirectToAction("ExperienceList", "Experience");
        }

    }
}
