using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LvivSocialServices.Models
{
    public class EFTaskRepository : ITaskRepository, IPersonRepository
    {
        private ApplicationDbContext context;

        public EFTaskRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Task> Tasks => context.Tasks;

        public IQueryable<Person> People => context.People;

        public void SaveTask(Task task)
        {
            if (task.TaskId == 0)
            {
                context.Tasks.Add(task);
            }
            else
            {
                Task dbEntry = context.Tasks
                    .FirstOrDefault(t => t.TaskId == task.TaskId);
                if (dbEntry != null)
                {
                    dbEntry.Category = task.Category;
                    dbEntry.Description = task.Description;
                    dbEntry.CreationDateTime = task.CreationDateTime;
                    dbEntry.Volunteer = task.Volunteer;
                }
            }
            context.SaveChanges();
        }

        public Task DeleteTask(int taskId)
        {
            Task dbEntry = context.Tasks.Include(t => t.Person).FirstOrDefault(t => t.TaskId == taskId);
            if (dbEntry != null)
            {
                context.Tasks.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}