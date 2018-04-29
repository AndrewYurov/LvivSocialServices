using System.Collections.Generic;
using System.Linq;

namespace LvivSocialServices.Models
{
    public class TaskBag
    {
        private List<Task> taskCollection = new List<Task>();
        public virtual void AddItem(Task task)
        {
            taskCollection.Add(task);
        }
        public virtual void RemoveItem(Task task) => taskCollection.RemoveAll(t => t.TaskId == task.TaskId);

        public virtual decimal ComputeTotalAmount() => taskCollection.Count;
        public virtual void Clear() => taskCollection.Clear();
        public virtual IEnumerable<Task> Tasks => taskCollection;
    }
}
