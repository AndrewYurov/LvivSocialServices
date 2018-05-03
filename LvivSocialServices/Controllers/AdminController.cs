using Microsoft.AspNetCore.Mvc;
using LvivSocialServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LvivSocialServices.Controllers
{
    public class AdminController:Controller
    {
        private ITaskRepository repository;
        public AdminController(ITaskRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index() => View(repository.Tasks.Include(t => t.Person));

        public ViewResult Edit(int taskId) => 
            View( repository.Tasks.Include(t => t.Person).FirstOrDefault(t => t.TaskId== taskId));

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                repository.SaveTask(task);
                TempData["message"] = "Task has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(task);
            }
        }

        public ViewResult Create() => View("Edit", new Task());

        [HttpPost]
        public IActionResult Delete(int taskId)
        {
            Task deletedTask = repository.DeleteTask(taskId);
            if ( deletedTask != null )
            {
                TempData["message"] = $"task with id {deletedTask.TaskId} was deleted";
            }
            return RedirectToAction("Index");
        }

    }
}
