using EntityFrameworkWithAspNetCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkWithAspNetCore.Data.Initializer
{
    public class CustomerContextInitializer
    {
        public void Initialize(CustomerContext context)
        {
            context.Database.EnsureCreated();

            if (context.Customers.Any())
            {
                return;
            }

            context.Customers.Add(
                new Customer {Name = "John", Surname = "Doe", Age = 21, Email = "johndoe@mail.com" }
            );
            context.SaveChanges();
        }
    }
}
