using Microsoft.AspNetCore.Mvc;
using LvivSocialServices.Models;
using LvivSocialServices.Models.ViewModels;
using System.Linq;

namespace LvivSocialServices.Controllers
{
    public class TaskController : Controller
    {
        private ITaskRepository taskRepository;
        public int PageSize = 4;

        public TaskController(ITaskRepository taskRepo)
        {
            taskRepository = taskRepo;
        }

        public ViewResult List(string category, int taskPage = 1)
            => View(new TaskListViewModel
            {
                Tasks = taskRepository.Tasks
                        .Where(t => category == null || t.Category == category)
                        .OrderBy(t => t.TaskID)
                        .Skip((taskPage - 1) * PageSize)
                        .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = taskPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        taskRepository.Tasks.Count() :
                        taskRepository.Tasks.Where(t => t.Category == category).Count()

                },
                CurrentCategory = category
            });
    }
}
