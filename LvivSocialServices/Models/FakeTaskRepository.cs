using System.Collections.Generic;
using System.Linq;
using System;

namespace LvivSocialServices.Models
{
    public class FakeTaskRepository : ITaskRepository
    {
        public IQueryable<Task> Tasks => new List<Task>{
            new Task
                {
                    Category = "Shopping",
                    Description = "Buy some products for disabled person",
                    //Person = new Person { FirstName = "Ivan", LastName = "Ivanenko", Address = "IvanAddress" },
                    CreationDateTime = new DateTime(2018, 1, 1),
                    Volunteer = "volunteer"
                },

                new Task
                {
                    Category = "Medicine",
                    Description = "Buy some medicines for disabled person",
                    //Person = new Person { FirstName = "Petro", LastName = "Petro", Address = "PetroAddress" },
                    CreationDateTime = new DateTime(2018, 1, 2)
                },

                new Task
                {
                    Category = "Cleaning",
                    Description = "Clean something for disabled person",
                    //Person = new Person { FirstName = "Olha", LastName = "Olhenko", Address = "OlhaAddress" },
                    CreationDateTime = new DateTime(2018, 1, 3)
                },

                new Task
                {
                    Category = "Documents",
                    Description = "Collectiong documents for disabled person",
                    //Person = new Person { FirstName = "Taras", LastName = "Tarasenko", Address = "Address" },
                    CreationDateTime = new DateTime(2018, 1, 4),
                    Volunteer = "volunteer"
                },

                new Task
                {
                    Category = "Letters",
                    Description = "Writing letters for disabled person",
                    //Person = new Person { FirstName = "Ira", LastName = "Irenko", Address = "IrenkoAddress" },
                    CreationDateTime = new DateTime(2018, 1, 5)
                },

                new Task
                {
                    Category = "Shopping",
                    Description = "Buy some products for disabled person",
                    //Person = new Person { FirstName = "Vasyl", LastName = "Vasylenko", Address = "VasylAddress" },
                    CreationDateTime = new DateTime(2018, 1, 6)
                },

                new Task
                {
                    Category = "Medicine",
                    Description = "Buy some Medicine for disabled person",
                    //Person = new Person { FirstName = "Tania", LastName = "Taniaenko", Address = "TaniaAddress" },
                    CreationDateTime = new DateTime(2018, 1, 7)
                },

                new Task
                {
                    Category = "Shopping",
                    Description = "Buy some products for disabled person",
                    //Person = new Person { FirstName = "Anna", LastName = "Annaenko", Address = "AnnaAddress" },
                    CreationDateTime = new DateTime(2018, 1, 8)
                }
        }.AsQueryable<Task>();

        public void SaveTask(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
