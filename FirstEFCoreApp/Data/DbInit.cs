using FirstEFCoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEFCoreApp.Data
{
    public static class DbInit
    {
        public static void SeedFakeData(AppDbContext context)
        {
            Console.WriteLine("Seeding Fake Data");
            context.Database.EnsureCreated();

            if (!context.Contacts.Any())
            {
                Console.WriteLine("Creating Contacts");
                context.Contacts.Add(new Contact(){FirstName = "John", LastName = "Smith",Email = "john.smith@email.com"});
                context.Contacts.Add(new Contact(){FirstName = "Jane",LastName = "Smith",Email = "jane.smith@email.com"});
                context.Contacts.Add(new Contact(){FirstName = "Mark",LastName = "Andrews",Email = "mark.andrews@email.com"});
            }


            if (!context.ToDos.Any())
            {
                Console.WriteLine("Creating Todos");
                context.ToDos.Add(new ToDo() { Text = "Wash the dishes", Completed = false });
                context.ToDos.Add(new ToDo() { Text = "Take out the trash", Completed = true });
                context.ToDos.Add(new ToDo() { Text = "Buy Groceries", Completed = true });
               
            }

            context.SaveChanges();


        }
    }
}
