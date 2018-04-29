using System.Linq;

namespace LvivSocialServices.Models
{
    public interface ITaskRepository
    {
        IQueryable<Task> Tasks { get; }

        void SaveTask(Task task);
    }
}
