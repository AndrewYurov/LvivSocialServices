using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LvivSocialServices.Infrastructure;
using LvivSocialServices.Models;
using LvivSocialServices.Models.ViewModels;

namespace LvivSocialServices.Controllers
{
    public class TaskBagController:Controller
    {
        private ITaskRepository repository;
        public TaskBagController(ITaskRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new TaskBagIndexViewModel{ Tasks = repository.Tasks.Where(t => t.Volunteer == "volunteer"), ReturnUrl = returnUrl });
        }

        public RedirectToActionResult Subscribe(int taskId, string returnUrl)
        {
            Task task = repository.Tasks.FirstOrDefault(t => t.TaskId == taskId);
            if (task != null)
            {
                task.Volunteer = "volunteer";
                repository.SaveTask(task);
            }

            return RedirectToAction("Index", new { returnUrl });
        }
        public RedirectToActionResult Unsubscribe(int taskId, string returnUrl)
        {
            Task task = repository.Tasks
                .FirstOrDefault(t => t.TaskId == taskId);
            if (task != null)
            {
                task.Volunteer = null;
                repository.SaveTask(task);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
