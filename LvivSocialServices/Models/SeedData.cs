using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace LvivSocialServices.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            // clean the context
            //foreach (var entity in context.Tasks)
            //    context.Tasks.Remove(entity);
            //context.SaveChanges();

            if (!context.People.Any())
            {
                context.People.AddRange(
                    new Person
                    {
                        FirstName = "Ivan",
                        LastName = "Ivanenko",
                        Address = "IvanAddress"
                    },
                    new Person
                    {
                        FirstName = "Petro",
                        LastName = "Petro",
                        Address = "PetroAddress"
                    },
                    new Person
                    { FirstName = "Olha",
                        LastName = "Olhenko",
                        Address = "OlhaAddress"
                    },
                    new Person
                    {
                        FirstName = "Taras",
                        LastName = "Tarasenko",
                        Address = "Address"
                    },
                    new Person
                    {
                        FirstName = "Ira",
                        LastName = "Irenko",
                        Address = "IrenkoAddress"
                    },
                    new Person
                    {
                        FirstName = "Vasyl",
                        LastName = "Vasylenko",
                        Address = "VasylAddress"
                    },
                    new Person
                    {
                        FirstName = "Tania",
                        LastName = "Taniaenko",
                        Address = "TaniaAddress"
                    },
                    new Person
                    {
                        FirstName = "Anna",
                        LastName = "Annaenko",
                        Address = "AnnaAddress"
                    }
                );
                context.SaveChanges();

            }

            if (!context.Tasks.Any())
            {
                context.Tasks.AddRange(
                new Task
                {
                    Category = "Shopping",
                    Description = "Buy some products for disabled person",
                    CreationDateTime = new DateTime(2018, 1, 1),
                    PersonId =1
                    //Volunteer = "volunteer"
                },

                new Task
                {
                    Category = "Medicine",
                    Description = "Buy some medicines for disabled person",
                    CreationDateTime = new DateTime(2018, 1, 2),
                    PersonId = 2
                },

                new Task
                {
                    Category = "Cleaning",
                    Description = "Clean something for disabled person",
                    CreationDateTime = new DateTime(2018, 1, 3),
                    PersonId = 3
                },

                new Task
                {
                    Category = "Documents",
                    Description = "Collectiong documents for disabled person",
                    CreationDateTime = new DateTime(2018, 1, 4),
                    PersonId = 4
                    //Volunteer = "volunteer"
                },

                new Task
                {
                    Category = "Letters",
                    Description = "Writing letters for disabled person",
                    CreationDateTime = new DateTime(2018, 1, 5),
                    PersonId = 5
                },

                new Task
                {
                    Category = "Shopping",
                    Description = "Buy some products for disabled person",
                    CreationDateTime = new DateTime(2018, 1, 6),
                    PersonId = 6
                },

                new Task
                {
                    Category = "Medicine",
                    Description = "Buy some Medicine for disabled person",
                    CreationDateTime = new DateTime(2018, 1, 7),
                    PersonId = 7
                },
                
                new Task
                {
                    Category = "Shopping",
                    Description = "Buy some products for disabled person",
                    CreationDateTime = new DateTime(2018, 1, 8),
                    PersonId = 8
                });

                context.SaveChanges();
            }
        }
    }
}