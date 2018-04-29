using LvivSocialServices.Models;
using System.Collections;
using System.Collections.Generic;

namespace LvivSocialServices.Models.ViewModels
{
    public class TaskBagIndexViewModel
    {
        public IEnumerable<Task> Tasks { get; set; }
        public string ReturnUrl { get; set; }
    }
}
