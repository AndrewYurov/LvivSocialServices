using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LvivSocialServices.Models.ViewModels
{
    public class TaskListViewModel
    {
        public IEnumerable<Task> Tasks { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
