using System;

namespace LvivSocialServices.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public PersonInformation PersonInfo  { get; set; }
        public DateTime CreationDateTime { get; set; }
    }

    public class PersonInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
