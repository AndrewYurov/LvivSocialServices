using Microsoft.AspNetCore.Mvc;
using System.Linq;
using LvivSocialServices.Models;

namespace LvivSocialServices.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private ITaskRepository repository;


        public NavigationMenuViewComponent(ITaskRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Tasks
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}