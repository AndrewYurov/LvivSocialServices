using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LvivSocialServices.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        //[Required(ErrorMessage = "Please enter a task category")]
        public string Category { get; set; }

        //[Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }

        public DateTime CreationDateTime { get; set; }

        public string Volunteer  { get; set; }

        public int? PersonId { get; set; }
        public Person Person { get; set; }
    }

    public class Person
    {
        public int PersonId { get; set; }

        //[Required(ErrorMessage = "Please enter a first name")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Please enter a last name")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Please enter an adress")]
        public string Address { get; set; }
    }
}
