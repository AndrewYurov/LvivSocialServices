using Microsoft.AspNetCore.Mvc;
using LvivSocialServices.Models;
using System.Linq;

namespace LvivSocialServices.Components
{
    public class TaskBagSummaryViewComponent : ViewComponent
    {
        private ITaskRepository repository;
        public TaskBagSummaryViewComponent(ITaskRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Tasks.Where(t => t.Volunteer == "volunteer"));
        }
    }
}
