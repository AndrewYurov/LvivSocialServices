using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LvivSocialServices.Models;
using LvivSocialServices.Infrastructure;
using Microsoft.AspNetCore.Http;
using LvivSocialServices.Models.ViewModels;

namespace LvivSocialServices.Controllers
{
    public class TaskBagController : Controller
    {

        private ITaskRepository repository;

        public TaskBagController(ITaskRepository repo)
        {
            repository = repo;
        }

        public RedirectToActionResult AddToTaskBag(int taskId, string returnUrl)
        {
            Models.Task task = repository.Tasks.FirstOrDefault(p => p.TaskID == taskId);
            if (task != null)
            {
                TaskBag taskBag = GetTaskBag();
                taskBag.AddItem(task);
                SaveTaskBag(taskBag);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromTaskBag(int taskId, string returnUrl)
        {
            Models.Task task = repository.Tasks.FirstOrDefault(p => p.TaskID == taskId);
            if (task != null)
            {
                TaskBag taskBag = new TaskBag();
                taskBag.RemoveLine(task);
                SaveTaskBag(taskBag);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        private TaskBag GetTaskBag()
        {
            TaskBag taskBag = HttpContext.Session.GetJson<TaskBag>("TaskBag") ?? new TaskBag();
            return taskBag;
        }

        private void SaveTaskBag(TaskBag taskBag)
        {
            HttpContext.Session.SetJson("TaskBag", taskBag);
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new TaskBagIndexViewModel
            {
                TaskBag = GetTaskBag(),
                ReturnUrl = returnUrl
            }
                );
        }
    }
}