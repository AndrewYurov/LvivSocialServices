using System.Collections.Generic;
using System.Linq;
using System;

namespace LvivSocialServices.Models
{
    public class FakeTaskRepository : ITaskRepository
    {
        public IQueryable<Task> Tasks => new List<Task>{
            new Task{ TaskID = 1, Category = "Shopping", Description="Buy some products for disabled person", PersonInfo = new PersonInformation{ FirstName="Ivan", LastName = "Ivanenko", Address="IvanAddress"}, CreationDateTime = new DateTime(2018, 1, 1) },
            new Task{ TaskID = 2, Category = "Medicine", Description="Buy some medicines for disabled person", PersonInfo = new PersonInformation{ FirstName="Petro", LastName = "Petro", Address="PetroAddress"}, CreationDateTime = new DateTime(2018, 1, 2) },
            new Task{ TaskID = 3, Category = "Cleaning", Description="Clean something for disabled person", PersonInfo = new PersonInformation{ FirstName="Olha", LastName = "Olhenko", Address="OlhaAddress"}, CreationDateTime = new DateTime(2018, 1, 3) },
            new Task{ TaskID = 4, Category = "Documents", Description="Collectiong documents for disabled person", PersonInfo = new PersonInformation{ FirstName="Taras", LastName = "Tarasenko", Address="Address"}, CreationDateTime = new DateTime(2018, 1, 4) },
            new Task{ TaskID = 5, Category = "Letters", Description="Writing letters for disabled person", PersonInfo = new PersonInformation{ FirstName="Ira", LastName = "Irenko", Address="IrenkoAddress"}, CreationDateTime = new DateTime(2018, 1, 5) },
            new Task{ TaskID = 6, Category = "Shopping", Description="Buy some products for disabled person", PersonInfo = new PersonInformation{ FirstName="Vasyl", LastName = "Vasylenko", Address="VasylAddress"}, CreationDateTime = new DateTime(2018, 1, 6) },
            new Task{ TaskID = 7, Category = "Medicine", Description="Buy some Medicine for disabled person", PersonInfo = new PersonInformation{ FirstName="Tania", LastName = "Taniaenko", Address="TaniaAddress"}, CreationDateTime = new DateTime(2018, 1, 7) },
            new Task{ TaskID = 8, Category = "Shopping", Description="Buy some products for disabled person", PersonInfo = new PersonInformation{ FirstName="Anna", LastName = "Annaenko", Address="AnnaAddress"}, CreationDateTime = new DateTime(2018, 1, 8) }
        }.AsQueryable<Task>();
    }
}
